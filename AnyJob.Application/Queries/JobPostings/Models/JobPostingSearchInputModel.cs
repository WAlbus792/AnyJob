using AnyJob.Domain;

namespace AnyJob.Application.Queries.JobPostings.Models;

public class JobPostingSearchInputModel : InputModelBase
{
    public List<int>? Categories { get; set; }
    public List<int>? Locations { get; set; }
    public List<EmploymentTypeId>? EmploymentTypes { get; set; }
    public string? SearchTitle { get; set; }
    public SortBy SortBy { get; set; }
    public int Page { get; set; }
    public int PageSize { get; set; }
}