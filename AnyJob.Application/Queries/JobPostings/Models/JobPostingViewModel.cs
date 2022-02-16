namespace AnyJob.Application.Queries.JobPostings.Models;

public class JobPostingViewModel
{
    public int Total { get; set; }
    public List<JobPostingViewItemModel> Data { get; set; }
}