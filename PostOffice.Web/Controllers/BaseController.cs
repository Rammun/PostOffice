using System.Web.Mvc;
using AutoMapper;
using PostOffice.Web.Mapping;
using PostOffice.Web.Models;

namespace PostOffice.Web.Controllers
{
    public class BaseController : Controller
    {
        protected ApplicationDbContext Db { get; }
        protected IMapper Mapper;

        public BaseController()
        {
            Db = new ApplicationDbContext();
            Mapper = AutoMapperConfiguration.CreateMappings();
        }

        #region DISPOSE

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Db.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion
    }
}