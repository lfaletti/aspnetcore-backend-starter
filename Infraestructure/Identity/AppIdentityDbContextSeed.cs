using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Infraestructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "demouser@microsoft.com",
                Email = "demouser@microsoft.com"
            };
            await userManager.CreateAsync(defaultUser, "Pass@word1");
        }
    }
}
