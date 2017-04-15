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
            CreateMap<ParcelRegisterViewModel, Parcel>();

            CreateMap<MemberViewModel, Member>();
        }
    }
}