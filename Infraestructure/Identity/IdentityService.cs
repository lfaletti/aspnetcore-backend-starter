using Core.Interfaces.Identity;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Infraestructure.Identity
{
    /// <summary>
    /// This class handles the authentication over the Microsoft Identity provider to to the database.
    /// </summary>
    public class IdentityService : IIdentityService
    {
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<ApplicationUser> _userManager;

        public IdentityService(
            RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<bool> Authenticate(string username, string password)
        {
            var user = _userManager.FindByNameAsync(username).Result;

            return await _userManager.CheckPasswordAsync(user, password);
        }

        public async Task<bool> Register(string userName, string password)
        {
            var user = new ApplicationUser { UserName = userName, Email = "" };

            if (!await _roleManager.RoleExistsAsync("admin"))
            {
                var role = new IdentityRole();
                role.Name = "admin";

                await _roleManager.CreateAsync(role);
            }

            if (!await _roleManager.RoleExistsAsync("guest"))
            {
                var role = new IdentityRole();
                role.Name = "guest";

                await _roleManager.CreateAsync(role);
            }

            var result = await _userManager.CreateAsync(user, password);

            if (result.Errors != null)
            {
                // log...
            }
            return (result.Succeeded);
        }
    }
}
