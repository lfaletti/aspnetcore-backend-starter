using System.Threading.Tasks;

namespace Core.Interfaces.Identity
{
    public interface IIdentityService
    {
        Task<bool> Authenticate(string username, string password);
        Task<bool> Register(string userName, string password);
    }
}