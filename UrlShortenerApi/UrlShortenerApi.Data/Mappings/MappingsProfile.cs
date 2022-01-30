using AutoMapper;
using UrlShortenerApi.Data.Dto;
using UrlShortenerApi.Data.Entities;

namespace UrlShortenerApi.Data.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<ShortLink, ShortLinkDto>().ReverseMap();
        }
    }
}