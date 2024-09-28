using Contract_Report2.ModelDataLayer.Entities;
using Contract_Report2.ModelDataLayer.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Contract_Report2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContractController(IUnitOfwork unitOfwork) : Controller
    {
        public IActionResult Index()
        {
            var model = unitOfwork.contractUW.Get();
            return View(model);
           // return View();


        }
        [HttpGet]
        public IActionResult AddContract()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public Task<IActionResult> AddContract(Contract model)
        {

            if (ModelState.IsValid)
            {
                unitOfwork.contractUW .create(model);
                unitOfwork.Save();

                // notyf.Success("اطلاعات با موفقیت ثبت شد.", 3);

                return Task.FromResult<IActionResult>(RedirectToAction(nameof(Index)));
            }
            return Task.FromResult<IActionResult>(View(model));
        }

       

        //123
    }
}
