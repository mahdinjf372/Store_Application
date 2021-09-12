using System;
using System.Security.Claims;
using System.Security.Principal;

namespace EndPoint.WebSite.Utilities
{
    public class ClaimUtility
    {

        public int GetUserId(ClaimsPrincipal User)
        {
            try
            {
                if (!User.Identity.IsAuthenticated)
                    throw new Exception();
                var claimsIdentity = User.Identity as ClaimsIdentity;
                int userId = int.Parse(claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value);
                return userId;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool IsAuthenticated(ClaimsPrincipal User)
        {
            try
            {
                var res = User.Identity.IsAuthenticated;
                return res;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public string GetUserEmail(ClaimsPrincipal User)
        {
            try
            {
                if (!User.Identity.IsAuthenticated)
                    throw new Exception();

                var claimsIdentity = User.Identity as ClaimsIdentity;
                return claimsIdentity.FindFirst(ClaimTypes.Email).Value;
            }
            catch (Exception)
            {

                return null;
            }

        }


        public int GetRolse(ClaimsPrincipal User)
        {
            try
            {
                if (!User.Identity.IsAuthenticated)
                    throw new Exception();

                var claimsIdentity = User.Identity as ClaimsIdentity;
                var role = int.Parse(claimsIdentity.FindFirst(ClaimTypes.Role).Value);
                return role;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
