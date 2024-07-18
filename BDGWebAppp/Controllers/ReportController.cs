using BDGWebAppp.Models;
using BDGWebAppp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace BDGWebAppp.Controllers
{
    public class ReportController : Controller
    {
        private readonly IUtilityService _utilityService;
        public ReportController(IUtilityService utilityService) 
        {
            this._utilityService = utilityService;
        }
        public IActionResult Index()
        {            
            return View();
        }

        public async Task<IActionResult> Report()
        {
            var data = await GetUsersData();
            return View(data);
        }

        #region Helper Methods
        private async Task<List<User>> GetUsersData() 
        {
            var results = await _utilityService.GetListOfUsers();
            return results;
        }
        #endregion
    }
}
