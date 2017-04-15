using System.Collections.Generic;
using System.Data.Entity;
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
            var parcels = Db
                .Parcels
                .Include(r => r.Recipient)
                .Include(s => s.Sender)
                .ToList();

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
            IEnumerable<ParcelViewModel> result;

            var parcels = Db
                 .Parcels
                 .Include(r => r.Recipient)
                 .Include(s => s.Sender)
                 .ToList();
            
            var models = Mapper.Map<IEnumerable<Parcel>, IEnumerable<ParcelViewModel>>(parcels);

            if (string.IsNullOrEmpty(search))
            {
                result = models;
            }
            else
            {
                result = models
                            .Where(x =>
                                   x.RecipientAdress.Contains(search) ||
                                   x.SenderAdress.Contains(search) ||
                                   x.RecipientFullName.Contains(search) ||
                                   x.SenderFullName.Contains(search))
                            .ToList();
            }

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