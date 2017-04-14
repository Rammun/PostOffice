using AutoMapper;
using PostOffice.Web.Mapping.Profiles;

namespace PostOffice.Web.Mapping
{
    public class AutoMapperConfiguration
    {
        public static IMapper CreateMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<EntityToViewModelMappingProfile>();
                cfg.AddProfile<ViewModelToEntitylMappingProfile>();
            }).CreateMapper();
        }
    }
}