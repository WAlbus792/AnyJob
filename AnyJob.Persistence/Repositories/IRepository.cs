using AnyJob.Domain.Shared;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AnyJob.Persistence.Repositories;

/// <summary>
/// Interface that implements Repository
/// </summary>
/// <typeparam name="TEntity">type of Entity</typeparam>
public interface IRepository<TEntity> : IRepository<TEntity, int>
    where TEntity : EntityWithId
{

}

/// <summary>
/// Interface that implements Repository
/// </summary>
/// <typeparam name="TEntity">type of Entity</typeparam>
/// <typeparam name="TId">type of Entity Id</typeparam>
public interface IRepository<TEntity, in TId> : IQueryable<TEntity>
    where TEntity : class, IEntityWithId<TId>
    where TId : IComparable
{
    #region Add

    /// <summary>
    /// Adds a new object
    /// </summary>
    EntityEntry<TEntity> Add(TEntity objectToAdd);

    /// <summary>
    /// Adds a new object asynchronous
    /// </summary>
    ValueTask<EntityEntry<TEntity>> AddAsync(TEntity objectToAdd);

    /// <summary>
    /// Adds a collection of new objects
    /// </summary>
    void AddRange(IEnumerable<TEntity> objectsToAdd);

    /// <summary>
    /// Adds a collection of new objects asynchronous
    /// </summary>
    Task AddRangeAsync(IEnumerable<TEntity> objectsToAdd);

    #endregion Add

    #region Remove

    /// <summary>
    /// Removes the instance by its id
    /// </summary>
    /// <param name="instanceId">id of instance</param>
    void Remove(TId instanceId);

    /// <summary>
    /// Removes the instance by its id asynchronous
    /// </summary>
    /// <param name="instanceId">id of instance</param>
    Task RemoveAsync(TId instanceId);

    /// <summary>
    /// Removes the instances by their ids
    /// </summary>
    /// <param name="ids">ids of instances</param>
    void RemoveRange(IEnumerable<TId> ids);

    /// <summary>
    /// Removes the instances by their ids asynchronous
    /// </summary>
    /// <param name="ids">ids of instances</param>
    Task RemoveRangeAsync(IEnumerable<TId> ids);

    #endregion Remove

    #region Queries

    /// <summary>
    /// Method gets all instances by their Ids
    /// </summary>
    /// <param name="ids">ids of instances</param>
    IQueryable<TEntity> GetByIds(IEnumerable<TId> ids);

    /// <summary>
    /// Returns the instance by its Id
    /// </summary>
    /// <param name="id">id of the instance</param>
    IQueryable<TEntity> GetById(TId id);

    #endregion Queries
}