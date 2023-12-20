using Microsoft.AspNetCore.Mvc;

namespace EmployeesPieChart.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
