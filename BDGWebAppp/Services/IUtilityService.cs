using BDGWebAppp.Models;

namespace BDGWebAppp.Services
{
    public interface IUtilityService
    {
        Task<List<User>> GetListOfUsers();
    }
}
