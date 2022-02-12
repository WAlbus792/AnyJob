using AnyJob.Domain;
using AutoMapper;

namespace AnyJob.Application.Queries.Categories.Models;

public class CategorySelectModel
{
    public int Id { get; set; }
    public string Name { get; set; }

    private class MappingProfile : Profile
    {
        public MappingProfile() => CreateMap<Category, CategorySelectModel>();
    }
}