using AnyJob.Domain;
using AutoMapper;

namespace AnyJob.Application.Queries.Users.Models;

public class AnonymousUserViewModel
{
    public int Id { get; set; }

    public Guid AnonymousId { get; set; }
    public IEnumerable<int> Bookmarks { get; set; } = new List<int>();

    private class MappingProfile : Profile
    {
        public MappingProfile() => CreateMap<User, AnonymousUserViewModel>()
           .ForMember(d => d.Bookmarks, opts => opts.MapFrom(e => e.Bookmarks.Select(b => b.JobPostingId)));
    }
}