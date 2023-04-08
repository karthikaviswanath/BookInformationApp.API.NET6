using AutoMapper;
using BookInformationApp.API.Domain_Entities;
using BookInformationApp.API.DTOs;

namespace BookInformationApp.API.Mapping_Profiles
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Book, BookCreateDto>().ReverseMap();
        }
    }
}
