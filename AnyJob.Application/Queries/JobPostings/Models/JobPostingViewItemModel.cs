using AnyJob.Domain;
using AutoMapper;

namespace AnyJob.Application.Queries.JobPostings.Models;

public class JobPostingViewItemModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CreationDate { get; set; }
    public string Category { get; set; }
    public string Location { get; set; }
    public string EmploymentType { get; set; }

    private class MappingProfile : Profile
    {
        public MappingProfile() => CreateMap<JobPosting, JobPostingViewItemModel>()
           .ForMember(d => d.Category, opts => opts.MapFrom(e => e.Category.Name))
           .ForMember(d => d.EmploymentType, opts => opts.MapFrom(e => e.EmploymentType.Name))
           .ForMember(d => d.Location,
                opts => opts.MapFrom(e => $"{e.Location.City}{(e.Location.State == null ? null : $", {e.Location.State}")}, {e.Location.Country}"));
    }
}