using AnyJob.Application.Queries.Users;
using AnyJob.Application.Queries.Users.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnyJob.WebApp.Controllers;

[Route("api/[controller]")]
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

    [HttpGet("[action]")]
    public Task<AnonymousUserViewModel?> Anonymous() => getAnonymousUserQuery.Build();

    #endregion
}