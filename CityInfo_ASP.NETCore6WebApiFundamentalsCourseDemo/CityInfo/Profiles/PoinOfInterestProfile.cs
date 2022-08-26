using AutoMapper;

namespace CityInfo.Profiles
{
    public class PoinOfInterestProfile : Profile
    {
        public PoinOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDto>();
        }
    }
}
