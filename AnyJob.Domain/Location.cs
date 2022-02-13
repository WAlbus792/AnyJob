using AnyJob.Domain.Shared;

namespace AnyJob.Domain;

public class Location : EntityWithId
{
    public string City { get; set; }
    public string? State { get; set; }
    public string Country { get; set; }

    #region Navigation properties

    public ICollection<JobPosting> JobPostings { get; set; } = new HashSet<JobPosting>();

    #endregion
}