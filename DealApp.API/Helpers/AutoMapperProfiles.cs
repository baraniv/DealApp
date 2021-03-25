using AutoMapper;
using DealApp.API.Models;
using DealApp.API.Dtos;
using System.Linq;

namespace DealApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Property, PropertyForListDto>()
             .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
             .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City.Name));
            // .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City.Name))
              
            CreateMap<Property, PropertyForDetailedDto>()
             .ForMember(dest => dest.PhotoUrl, opt => 
              opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url));
            CreateMap<Photo, PhotosForDetailedDto>();
            CreateMap<City, CityForListDto>();
        }
    }
}




     //    CreateMap<Property, PropertyForListDto>()
        //      .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain)));
              //.ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City.Name));