using AutoMapper;
using PostOffice.Web.Entity;
using PostOffice.Web.Models;

namespace PostOffice.Web.Mapping.Profiles
{
    public class EntityToViewModelMappingProfile : Profile
    {
        public EntityToViewModelMappingProfile()
        {
            CreateMap<Parcel, ParcelViewModel>();

            CreateMap<Thing, ThingViewModel>();
        }
    }
}