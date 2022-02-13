using AnyJob.Domain.Shared;

namespace AnyJob.Domain;

public class User : EntityWithId
{
    public Guid AnonymousId { get; set; }

    #region Navigation properties

    #region Bookmarks

    public ICollection<JobPostingBookmark> Bookmarks { get; set; } = new HashSet<JobPostingBookmark>();

    #endregion

    #endregion
}