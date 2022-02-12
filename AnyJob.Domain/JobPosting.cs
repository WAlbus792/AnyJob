using AnyJob.Domain.Shared;

namespace AnyJob.Domain;

public class JobPosting : EntityWithId
{
    public string Title { get; set; }
    public DateTime CreationDate { get; set; }

    #region Navigation properties

    #region Category

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    #endregion

    #region Location

    public int LocationId { get; set; }
    public Location Location { get; set; }

    #endregion

    #region EmploymentType

    public EmploymentTypeId EmploymentTypeId { get; set; }
    public EmploymentType EmploymentType { get; set; }

    #endregion

    #region Bookmarks

    public ICollection<JobPostingBookmark> Bookmarks { get; set; } = new HashSet<JobPostingBookmark>();

    #endregion

    #endregion
}