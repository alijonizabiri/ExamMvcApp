using Web.Data.Entities;
using Web.Data.Models;

namespace Web.Services.Profile;
using AutoMapper;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<CreateCategory, Category>();
    }
}