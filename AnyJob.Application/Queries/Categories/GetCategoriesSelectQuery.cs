using AnyJob.Application.Queries.Categories.Models;
using AnyJob.Domain;
using AnyJob.Persistence.Repositories;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace AnyJob.Application.Queries.Categories;

/// <summary>
/// Query for returning job categories to select
/// </summary>
public class GetCategoriesSelectQuery
{
    #region Constructor

    public GetCategoriesSelectQuery(IRepository<Category> categoryRepository, IMapper mapper)
    {
        this.categoryRepository = categoryRepository;
        this.mapper = mapper;
    }

    #endregion Constructor

    #region Fields

    private readonly IRepository<Category> categoryRepository;
    private readonly IMapper mapper;

    #endregion Fields

    #region Methods

    public Task<List<CategorySelectModel>> Build() => categoryRepository
       .AsNoTracking()
       .ProjectTo<CategorySelectModel>(mapper.ConfigurationProvider)
       .ToListAsync();

    #endregion Methods
}