using AnyJob.Application.Commands.JobPostings;
using AnyJob.Application.Commands.JobPostings.Models;
using AnyJob.Application.Queries.JobPostings;
using AnyJob.Application.Queries.JobPostings.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnyJob.WebApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JobPostingsController : ControllerBase
{
    #region Fields

    private readonly GetJobPostingsQuery getJobPostingsQuery;
    private readonly JobPostingBookmarkCommand jobPostingBookmarkCommand;

    #endregion

    #region Constructors

    public JobPostingsController(GetJobPostingsQuery getJobPostingsQuery, JobPostingBookmarkCommand jobPostingBookmarkCommand)
    {
        this.getJobPostingsQuery = getJobPostingsQuery;
        this.jobPostingBookmarkCommand = jobPostingBookmarkCommand;
    }

    #endregion

    #region Public methods

    [HttpPost]
    public Task<JobPostingViewModel> GetJobPostings(JobPostingSearchInputModel model) => getJobPostingsQuery.Build(model);

    [HttpPut("{id}")]
    public Task Bookmark([FromRoute] JobPostingBookmarkModel model) => jobPostingBookmarkCommand.Execute(model);

    #endregion
}