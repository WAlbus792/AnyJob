using AnyJob.Domain.Shared;

namespace AnyJob.Domain;

public class JobPostingBookmark : EntityWithId
{
    #region Navigation Properties

    #region JobPosting

    public int JobPostingId { get; set; }
    public JobPosting JobPosting { get; set; }

    #endregion

    #region User

    public int UserId { get; set; }
    public User User { get; set; }

    #endregion

    #endregion
}