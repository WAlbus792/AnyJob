using AnyJob.Application.Queries.Categories;
using AnyJob.Application.Queries.Categories.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnyJob.WebApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    #region Fields

    private readonly GetCategoriesSelectQuery getCategoriesSelectQuery;

    #endregion

    #region Constructors

    public CategoriesController(GetCategoriesSelectQuery getCategoriesSelectQuery) => this.getCategoriesSelectQuery = getCategoriesSelectQuery;

    #endregion

    #region Public methods

    [HttpGet]
    public Task<List<CategorySelectModel>> GetCategoriesToSelect() => getCategoriesSelectQuery.Build();

    #endregion
}