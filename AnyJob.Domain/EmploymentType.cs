using System.ComponentModel.DataAnnotations;
using AnyJob.Domain.Shared;

namespace AnyJob.Domain;

public enum EmploymentTypeId
{
    [Display(Name = "Full Time")]
    FullTime = 1,
    [Display(Name = "Part Time")]
    PartTime,
    [Display(Name = "Contractor")]
    Contractor,
    [Display(Name = "Intern")]
    Intern,
    [Display(Name = "Seasonal / Temp")]
    SeasonalOrTemp,
}

public class EmploymentType : EntityWithId<EmploymentTypeId>
{
    public string Name { get; set; }

    #region Navigation properties

    public ICollection<JobPosting> JobPostings { get; set; } = new HashSet<JobPosting>();

    #endregion
}