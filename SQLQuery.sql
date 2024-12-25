--SELECT TOP (1000) [ID]
--      ,[Name]
--      ,[Description]
--      ,[CreatedOn]
--      ,[StartDate]
--      ,[Duration]
--      ,[Price]
--      ,[CurrentTimeFiltered]
--      ,[CategoryID]
--      ,[CreatedByID]
--      ,[ImageID]
--  FROM [ProductsCatalogDB].[dbo].[Products]

--  UPDATE Products
--SET StartDate = '2024-12-20'

--SELECT 
--    u.Id AS UserId, 
--    u.UserName, 
--    u.Email, 
--	u.PasswordHash,
--    r.Name AS RoleName
--FROM 
--    ApplicationUsers u
--JOIN 
--    AspNetUserRoles ur ON u.Id = ur.UserId
--JOIN 
--    AspNetRoles r ON ur.RoleId = r.Id;

--	select * from AspNetUserRoles ur  where ur.UserId = 'e8d727d7-27c8-4a68-8987-c4a45a9070f4'

