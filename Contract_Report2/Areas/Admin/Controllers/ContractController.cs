using Contract_Report2.ModelDataLayer.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Contract_Report2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContractController(IUnitOfwork unitOfwork) : Controller
    {
        public IActionResult Index()
        {
            //var model = unitOfwork.companyUW.Get();
            //return View(model);
            return View();


        }
        [HttpGet]
        public IActionResult AddContract()
        {
            return View();
        }
        //123
    }
}
