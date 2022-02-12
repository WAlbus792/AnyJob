using AnyJob.Domain.Shared;

namespace AnyJob.Domain;

public class Category : EntityWithId
{
    public string Name { get; set; }

    #region Navigation properties

    public ICollection<JobPosting> JobPostings { get; set; }

    #endregion
}