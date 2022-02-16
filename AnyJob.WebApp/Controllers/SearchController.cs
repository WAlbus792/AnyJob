using AnyJob.Application.Queries.JobPostings;
using AnyJob.Application.Queries.JobPostings.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnyJob.WebApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SearchController : ControllerBase
{
    #region Fields

    private readonly GetJobPostingsQuery getJobPostingsQuery;

    #endregion

    #region Constructors

    public SearchController(GetJobPostingsQuery getJobPostingsQuery) => this.getJobPostingsQuery = getJobPostingsQuery;

    #endregion

    #region Public methods

    [HttpPost]
    public Task<JobPostingViewModel> GetJobPostings(JobPostingSearchInputModel model) => getJobPostingsQuery.Build(model);

    #endregion
}