using AnyJob.Application.Queries.Users;
using AnyJob.Application.Queries.Users.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnyJob.WebApp.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class AuthController : ControllerBase
{
    #region Fields

    private readonly GetAnonymousUserQuery getAnonymousUserQuery;

    #endregion

    #region Constructors

    public AuthController(GetAnonymousUserQuery getAnonymousUserQuery) => this.getAnonymousUserQuery = getAnonymousUserQuery;

    #endregion

    #region Public methods

    [HttpGet]
    public Task<AnonymousUserViewModel?> GetAnonymous() => getAnonymousUserQuery.Build();

    #endregion
}