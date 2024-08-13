using Microsoft.AspNetCore.Mvc;
using Contract_Report2.ModelDataLayer;
using Contract_Report2.ModelDataLayer.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Contract_Report2.ModelDataLayer.Entities;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Contract_Report2.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CompanyController(IUnitOfwork unitOfwork) : Controller

    {

        // private readonly INotyfService notyf;
        public IActionResult Index()
        {
            var model = unitOfwork.companyUW.Get();
            return View(model);

        }

        [HttpGet]
        public IActionResult AddCompany()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public Task<IActionResult> AddCompany(Company model)
        {

            if (ModelState.IsValid)
            {
                unitOfwork.companyUW.create(model);
                unitOfwork.Save();

                // notyf.Success("اطلاعات با موفقیت ثبت شد.", 3);

                return Task.FromResult<IActionResult>(RedirectToAction(nameof(Index)));
            }
            return Task.FromResult<IActionResult>(View(model));
        }
        [HttpGet]
        public IActionResult EditCompany(int CompanyID)
        {
            if (CompanyID == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var Company = unitOfwork.companyUW.GetById(CompanyID);
            return View(Company);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCompany(Company model)
        {


            if (ModelState.IsValid)
            {

                //update
              //  var Company = unitOfwork.companyUW.GetById(model.CompanyID);
                unitOfwork.companyUW.update (model);
                unitOfwork.Save();
                //if (result.Succeeded)
                //{
                return RedirectToAction("Index", "Company");
                //}
            }
            return View(model);

        }


        [HttpGet]
        public IActionResult DeleteCompany(int CompanyID)
        {
            if (CompanyID == 0)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var model = unitOfwork.companyUW .GetById(CompanyID);
            if (model == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteapplicant", model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCompany(Company model )
        {
            if (model == null )
            {
                return RedirectToAction("ErrorView", "Home");
            }
            try
            {
                unitOfwork.companyUW.Delete(model);
                unitOfwork.Save();
                return RedirectToAction("Index");
            }
            catch
            {

                return RedirectToAction("ErrorView", "Home");





            }
        }


    }
}
