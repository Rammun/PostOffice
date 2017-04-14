using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using PostOffice.Web.Entity;
using PostOffice.Web.Models;

namespace PostOffice.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var parcels = Db.Parcels.ToList();
            ViewBag.Parcels = Mapper.Map<IEnumerable<Parcel>, IEnumerable<ParcelViewModel>>(parcels);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ParcelRegister(ParcelRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var parcel = Mapper.Map<ParcelRegisterViewModel, Parcel>(model);

                Db.Parcels.Add(parcel);
                Db.SaveChanges();
            }

            var parcels = Mapper.Map<IEnumerable<Parcel>, IEnumerable<ParcelViewModel>>(Db.Parcels.ToList());
            
            return PartialView("ParselSearch", parcels);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ParcelSearch(string search = null)
        {
            var parcels = Db.Parcels.ToList();
            var models = Mapper.Map<IEnumerable<Parcel>, IEnumerable<ParcelViewModel>>(parcels);

            if (string.IsNullOrEmpty(search))
                return PartialView(models);
            
            var result = models
                .Where(x =>
                       x.RecipAdress.Contains(search) ||
                       x.SendAdress.Contains(search) ||
                       x.RecipientFio.Contains(search) ||
                       x.SenderFio.Contains(search));

            return PartialView(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}