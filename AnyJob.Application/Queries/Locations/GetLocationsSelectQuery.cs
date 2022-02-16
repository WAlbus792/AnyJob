using AnyJob.Application.Queries.Locations.Models;
using AnyJob.Domain;
using AnyJob.Persistence.Repositories;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace AnyJob.Application.Queries.Locations;

/// <summary>
/// Query for returning job locations to select
/// </summary>
public class GetLocationsSelectQuery
{
    #region Constructor

    public GetLocationsSelectQuery(IRepository<Location> locationRepository, IMapper mapper)
    {
        this.locationRepository = locationRepository;
        this.mapper = mapper;
    }

    #endregion Constructor

    #region Fields

    private readonly IRepository<Location> locationRepository;
    private readonly IMapper mapper;

    #endregion Fields

    #region Methods

    public Task<List<LocationSelectModel>> Build() => locationRepository
       .AsNoTracking()
       .ProjectTo<LocationSelectModel>(mapper.ConfigurationProvider)
       .ToListAsync();

    #endregion Methods
}