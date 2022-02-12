using AnyJob.Application.Contracts;
using AnyJob.Application.Queries.Users.Models;
using AnyJob.Domain;
using AnyJob.Persistence.Repositories;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace AnyJob.Application.Queries.Users;

/// <summary>
/// Query for returning current anonymous user
/// </summary>
public class GetAnonymousUserQuery
{
    #region Constructor

    public GetAnonymousUserQuery(IRepository<User> userRepository, IUserInfoProvider userInfoProvider, IMapper mapper, IDbChangesUpdater dbChangesUpdater)
    {
        this.userRepository = userRepository;
        this.userInfoProvider = userInfoProvider;
        this.mapper = mapper;
        this.dbChangesUpdater = dbChangesUpdater;
    }

    #endregion Constructor

    #region Fields

    private readonly IRepository<User> userRepository;
    private readonly IUserInfoProvider userInfoProvider;
    private readonly IMapper mapper;
    private readonly IDbChangesUpdater dbChangesUpdater;

    #endregion Fields

    #region Methods

    public async Task<AnonymousUserViewModel> Build()
    {
        AnonymousUserViewModel? user = await userRepository
           .Where(u => u.AnonymousId == userInfoProvider.AnonymousId)
           .ProjectTo<AnonymousUserViewModel>(mapper.ConfigurationProvider)
           .FirstOrDefaultAsync();
        if (user is null)
        {
            User newUser = new() { AnonymousId = userInfoProvider.AnonymousId };
            await userRepository.AddAsync(newUser);

            user = mapper.Map<AnonymousUserViewModel>(newUser);

            await dbChangesUpdater.SaveChangesAsync();
        }

        return user;
    }

    #endregion Methods
}