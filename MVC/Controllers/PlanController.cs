using Microsoft.AspNetCore.Mvc;
using MVC.Dbcontext;
using Microsoft.EntityFrameworkCore;

namespace MVC.Controllers
{
    public class PlanController : Controller

    {
        private readonly GYMDbcontext _dbcontext;

        public PlanController()
        {
            _dbcontext = new GYMDbcontext();
        }

        public async Task<IActionResult> Index()
        {
            var Plans = await _dbcontext.Plans.ToListAsync();

            return View(Plans);
        }
    }
}
