using AnyJob.Domain;
using AutoMapper;

namespace AnyJob.Application.Queries.Locations.Models;

public class LocationSelectModel
{
    public int Id { get; set; }
    public string Name { get; set; }

    private class MappingProfile : Profile
    {
        public MappingProfile() => CreateMap<Location, LocationSelectModel>()
            .ForMember(d => d.Name, opts => opts.MapFrom(e => $"{e.City}{(e.State == null ? null : $", {e.State}")}, {e.Country}"));
    }
}