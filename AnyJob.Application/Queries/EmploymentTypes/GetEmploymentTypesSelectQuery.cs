using AnyJob.Application.Queries.EmploymentTypes.Models;
using AnyJob.Domain;
using AnyJob.Persistence.Repositories;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace AnyJob.Application.Queries.EmploymentTypes;

/// <summary>
/// Query for returning employment types to select
/// </summary>
public class GetEmploymentTypesSelectQuery
{
    #region Constructor

    public GetEmploymentTypesSelectQuery(IRepository<EmploymentType, EmploymentTypeId> employmentTypeRepository, IMapper mapper)
    {
        this.employmentTypeRepository = employmentTypeRepository;
        this.mapper = mapper;
    }

    #endregion Constructor

    #region Fields

    private readonly IRepository<EmploymentType, EmploymentTypeId> employmentTypeRepository;
    private readonly IMapper mapper;

    #endregion Fields

    #region Methods

    public Task<List<EmploymentTypeSelectModel>> Build() => employmentTypeRepository
       .AsNoTracking()
       .ProjectTo<EmploymentTypeSelectModel>(mapper.ConfigurationProvider)
       .ToListAsync();

    #endregion Methods
}