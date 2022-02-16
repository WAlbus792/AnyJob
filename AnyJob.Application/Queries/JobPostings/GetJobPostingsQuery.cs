using AnyJob.Application.Queries.JobPostings.Models;
using AnyJob.Domain;
using AnyJob.Persistence.Repositories;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace AnyJob.Application.Queries.JobPostings;

/// <summary>
/// Query for returning job postings
/// </summary>
public class GetJobPostingsQuery
{
    #region Constructor

    public GetJobPostingsQuery(IRepository<JobPosting> jobPostingRepository, IMapper mapper)
    {
        this.jobPostingRepository = jobPostingRepository;
        this.mapper = mapper;
    }

    #endregion Constructor

    #region Fields

    private readonly IRepository<JobPosting> jobPostingRepository;
    private readonly IMapper mapper;

    #endregion Fields

    #region Methods

    public async Task<JobPostingViewModel> Build(JobPostingSearchInputModel model)
    {
        IQueryable<JobPosting> jobPostings = jobPostingRepository.AsNoTracking();
        if (model.Categories?.Any() == true)
            jobPostings = jobPostings.Where(p => model.Categories.Contains(p.CategoryId));
        if (model.Locations?.Any() == true)
            jobPostings = jobPostings.Where(p => model.Locations.Contains(p.LocationId));
        if (model.EmploymentTypes?.Any() == true)
            jobPostings = jobPostings.Where(p => model.EmploymentTypes.Contains(p.EmploymentTypeId));
        if(!string.IsNullOrEmpty(model.SearchTitle))
            jobPostings = jobPostings.Where(p => p.Title.Contains(model.SearchTitle));

        JobPostingViewModel result = new() { Total = await jobPostings.CountAsync() };

        jobPostings = model.SortBy switch
        {
            SortBy.MostRelevant => jobPostings.OrderByDescending(m => m.Title.StartsWith(model.SearchTitle)),
            SortBy.Newest => jobPostings.OrderBy(m => m.CreationDate),
            SortBy.Oldest => jobPostings.OrderByDescending(m => m.CreationDate),
            _ => jobPostings
        };

        if (model.Page * model.PageSize > result.Total)
            model.Page = result.Total / model.PageSize + 1;

        result.Data = await jobPostings
           .ProjectTo<JobPostingViewItemModel>(mapper.ConfigurationProvider)
           .Skip((model.Page - 1) * model.PageSize)
           .Take(model.PageSize)
           .ToListAsync();
        return result;
    }

    #endregion Methods
}