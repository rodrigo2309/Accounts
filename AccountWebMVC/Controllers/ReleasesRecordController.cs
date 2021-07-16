using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AccountWebMVC.Services;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace AccountWebMVC.Controllers
{
    public class ReleasesRecordController : Controller
    {
        private readonly ReleasesRecordService _releaseRecordService;

        public ReleasesRecordController(ReleasesRecordService releaseRecordService)
        {
            _releaseRecordService = releaseRecordService;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public async Task<IActionResult> SimpleSearch(DateTime? minDate,DateTime? maxDate)
        {
            _releaseRecordService.UserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _releaseRecordService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }
        [Authorize]
        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            _releaseRecordService.UserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _releaseRecordService.FindByDateGroupingAsync(minDate, maxDate);
            return View(result);
        }

    }
}