using AnyJob.Application.Commands.JobPostings.Models;
using AnyJob.Application.Exceptions;
using AnyJob.Application.Queries.Users;
using AnyJob.Application.Queries.Users.Models;
using AnyJob.Domain;
using AnyJob.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AnyJob.Application.Commands.JobPostings;

/// <summary>
/// Command to bookmark job posting for user
/// </summary>
public class JobPostingBookmarkCommand
{
    #region Fields

    private readonly IDbChangesUpdater dbChangesUpdater;
    private readonly GetAnonymousUserQuery getAnonymousUserQuery;
    private readonly IRepository<JobPosting> jobPostingRepository;
    private readonly IRepository<JobPostingBookmark> jobPostingBookmarkRepository;

    #endregion

    #region Constructors

    public JobPostingBookmarkCommand(
        IRepository<JobPosting> jobPostingRepository,
        GetAnonymousUserQuery getAnonymousUserQuery,
        IDbChangesUpdater dbChangesUpdater,
        IRepository<JobPostingBookmark> jobPostingBookmarkRepository
    )
    {
        this.jobPostingRepository = jobPostingRepository;
        this.getAnonymousUserQuery = getAnonymousUserQuery;
        this.dbChangesUpdater = dbChangesUpdater;
        this.jobPostingBookmarkRepository = jobPostingBookmarkRepository;
    }

    #endregion

    #region Public methods

    public async Task Execute(JobPostingBookmarkModel model)
    {
        JobPosting? jobPosting = await jobPostingRepository
           .GetById(model.Id)
           .Include(i => i.Bookmarks)
           .FirstOrDefaultAsync();
        if (jobPosting is null)
            throw new BusinessException("Job posting not found");

        AnonymousUserViewModel user = await getAnonymousUserQuery.Build();
        JobPostingBookmark? bookmark = jobPosting.Bookmarks.FirstOrDefault(b => b.UserId == user.Id);
        if(bookmark is null)
            jobPosting.Bookmarks.Add(new JobPostingBookmark { UserId = user.Id });
        else await jobPostingBookmarkRepository.RemoveAsync(bookmark.Id);

        await dbChangesUpdater.SaveChangesAsync();
    }

    #endregion
}