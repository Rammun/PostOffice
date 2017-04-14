using System.Linq;
using AutoMapper;
using PostOffice.Web.Entity;
using PostOffice.Web.Models;

namespace PostOffice.Web.Mapping.Profiles
{
    public class ViewModelToEntitylMappingProfile : Profile
    {
        public ViewModelToEntitylMappingProfile()
        {
            CreateMap<ParcelViewModel, Parcel>();

            CreateMap<ThingViewModel, Thing>();

            CreateMap<ParcelRegisterViewModel, Parcel>()
                .ForMember(x => x.Inventory, y => y.MapFrom(z => z.Inventory
                                                                  .Split(',')
                                                                  .Select(t => new Thing { Name = t })
                                                                  .ToList()));
        }
    }
}