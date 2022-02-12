using AnyJob.Application.Queries.Categories;
using AnyJob.Application.Queries.Categories.Models;
using AnyJob.Application.Queries.Locations;
using AnyJob.Application.Queries.Locations.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnyJob.WebApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LocationsController : ControllerBase
{
    #region Fields

    private readonly GetLocationsSelectQuery getLocationsSelectQuery;

    #endregion

    #region Constructors

    public LocationsController(GetLocationsSelectQuery getLocationsSelectQuery) => this.getLocationsSelectQuery = getLocationsSelectQuery;

    #endregion

    #region Public methods

    [HttpGet]
    public Task<List<LocationSelectModel>> GetLocationsToSelect() => getLocationsSelectQuery.Build();

    #endregion
}