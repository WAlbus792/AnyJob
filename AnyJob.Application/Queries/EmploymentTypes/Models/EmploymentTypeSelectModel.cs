using AnyJob.Domain;
using AutoMapper;

namespace AnyJob.Application.Queries.EmploymentTypes.Models;

public class EmploymentTypeSelectModel
{
    public int Id { get; set; }
    public string Name { get; set; }

    private class MappingProfile : Profile
    {
        public MappingProfile() => CreateMap<EmploymentType, EmploymentTypeSelectModel>();
    }
}