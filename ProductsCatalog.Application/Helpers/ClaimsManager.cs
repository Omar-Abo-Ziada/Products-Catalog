using System.Security.Claims;

namespace ProductsCatalog.Application.Helpers
{
    public static class ClaimsManager
    {
        public static List<string> GetRoles(ClaimsPrincipal user)
        {
            if (user == null)
            {
                return new List<string>();
            }

            return user.FindAll(ClaimTypes.Role).Select(c => c.Value).ToList();
        }

        public static Guid GetCurrentUserId(ClaimsPrincipal user)
        {
            if (user == null)
            {
                return Guid.Empty;
            }

            var userIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);

            if (userIdClaim == null)
            {
                return Guid.Empty;
            }

            return Guid.Parse(userIdClaim.Value); 
        }

    }
}