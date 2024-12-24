using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ProductsCatalog.Domain;
using ProductsCatalog.Presentaion.View_Models.User;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ProductsCatalog.Presentation.Controllers
{
    [Route("User")]
    [Route("Account")]  // This will make the controller accessible through /Account as well
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IConfiguration configuration;

        public UserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterVM userDTO)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { status = false, message = "بيانات غير صالحة , حاول مجددا." });
            }

            try
            {
                var existingUser = await userManager.FindByEmailAsync(userDTO.Email);
                if (existingUser != null)
                {
                    return Json(new { status = false, message = " , قم بتسجيل الدخول هذا المستخدم موجود بالفعل" });

                }

                ApplicationUser applicationUser = new ApplicationUser
                {
                    //UserName = userDTO.Email,
                    Email = userDTO.Email,
                    FirstName = userDTO.FirstName,
                    LastName = userDTO.FirstName,
                    UserName = $"{userDTO.Email}",
                };

                IdentityResult createAccResult = await userManager.CreateAsync(applicationUser, userDTO.Password);

                if (!createAccResult.Succeeded)
                {
                    foreach (var error in createAccResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return Json(new { status = false, message = "حدث خطا ما , حاول مجددا" });
                }

                IdentityResult addRoleResult = await userManager.AddToRoleAsync(applicationUser, "USER");

                if (!addRoleResult.Succeeded)
                {
                    await userManager.DeleteAsync(applicationUser); // Rollback if adding role fails
                    return Json(new { status = false, message = "حدث خطا ما , حاول مجددا" });

                }

                return Json(new { status = true, message = "تم التسجيل بنجاح", redirectUrl = "/User/Login" });
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = "حدث خطا ما , حاول مجددا" });
            }
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([FromBody] LoginVM userDTO)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { status = false, message = "بيانات غير صالحة , حاول مجددا." });
            }

            try
            {
                ApplicationUser? userFromDB = await userManager.FindByEmailAsync(userDTO.Email);
                if (userFromDB == null)
                {
                    return Json(new { status = false, message = "خطأ في اسم المستخدم أو كلمة المرور , حاول مجددا" });

                }

                bool isPasswordMatched = await userManager.CheckPasswordAsync(userFromDB, userDTO.Password);
                if (!isPasswordMatched)
                {
                    return Json(new { status = false, message = "خطأ في اسم المستخدم أو كلمة المرور , حاول مجددا" });
                }

                // If login is successful, generate JWT token
                List<Claim> claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, userFromDB.UserName),
                        new Claim(ClaimTypes.NameIdentifier, userFromDB.Id)
                    };

                IList<string> roles = await userManager.GetRolesAsync(userFromDB);
                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }

                await signInManager.SignInWithClaimsAsync(userFromDB, false, claims);


                // After sign-in, check if the user is authenticated
                if (User.Identity.IsAuthenticated)
                {
                    return Json(new { status = true, message = "تم تسجيل الدخول بنجاح", redirectUrl = "/Home/Index" });
                }
                else
                {
                    return Json(new { status = false, message = "حدث خطا ما , حاول مجددا" });
                }

                return Json(new { status = true, message = "تم تسجيل الدخول بنجاح", redirectUrl = "/Home/Index" });

            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = "حدث خطا ما , حاول مجددا" });
            }
        }

        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            try
            {
                await signInManager.SignOutAsync();

                return RedirectToAction("Login", "User");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Home", "Index");
            }
        }


        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            // You can retrieve the user data or token here if needed
            var token = HttpContext.Session.GetString("JWT_Token");
            if (token == null)
            {
                return RedirectToAction("Login"); // Redirect to login if token is not present
            }

            return View(); // Dashboard view
        }
    }
}
