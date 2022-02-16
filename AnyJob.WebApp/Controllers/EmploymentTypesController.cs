using AnyJob.Application.Queries.EmploymentTypes;
using AnyJob.Application.Queries.EmploymentTypes.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnyJob.WebApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmploymentTypesController : ControllerBase
{
    #region Fields

    private readonly GetEmploymentTypesSelectQuery getEmploymentTypesSelectQuery;

    #endregion

    #region Constructors

    public EmploymentTypesController(GetEmploymentTypesSelectQuery getEmploymentTypesSelectQuery) => this.getEmploymentTypesSelectQuery = getEmploymentTypesSelectQuery;

    #endregion

    #region Public methods

    [HttpGet]
    public Task<List<EmploymentTypeSelectModel>> GetEmploymentTypesToSelect() => getEmploymentTypesSelectQuery.Build();

    #endregion
}