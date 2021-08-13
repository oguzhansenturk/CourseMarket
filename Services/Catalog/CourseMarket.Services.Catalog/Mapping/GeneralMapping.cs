using AutoMapper;
using CourseMarket.Services.Catalog.Dtos;
using CourseMarket.Services.Catalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMarket.Services.Catalog.Mapping
{
    internal class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();
            CreateMap<Course, CourseCreateDto>().ReverseMap();
            CreateMap<Course, CourseUpdateDto>().ReverseMap();
        }
    }
}
