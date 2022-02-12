using AnyJob.Domain.Shared;

namespace AnyJob.Persistence.Repositories
{
    /// <summary>
    /// Interface that implements Repository
    /// </summary>
    /// <typeparam name="TEntity">type of Entity</typeparam>
    public interface IRepository<TEntity> : IQueryable<TEntity>
        where TEntity : EntityWithId
    {
        #region Add

        /// <summary>
        /// Adds a new object
        /// </summary>
        void Add(TEntity objectToAdd);

        /// <summary>
        /// Adds a new object asynchronous
        /// </summary>
        Task AddAsync(TEntity objectToAdd);

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
        void Remove(int instanceId);

        /// <summary>
        /// Removes the instance by its id asynchronous
        /// </summary>
        /// <param name="instanceId">id of instance</param>
        Task RemoveAsync(int instanceId);

        /// <summary>
        /// Removes the instances by their ids 
        /// </summary>
        /// <param name="ids">ids of instances</param>
        void RemoveRange(IEnumerable<int> ids);

        /// <summary>
        /// Removes the instances by their ids asynchronous
        /// </summary>
        /// <param name="ids">ids of instances</param>
        Task RemoveRangeAsync(IEnumerable<int> ids);

        #endregion Remove

        #region Queries

        /// <summary>
        /// Method gets all instances by their Ids 
        /// </summary>
        /// <param name="ids">ids of instances</param>
        IQueryable<TEntity> GetByIds(IEnumerable<int> ids);

        /// <summary>
        /// Returns the instance by its Id 
        /// </summary>
        /// <param name="id">id of the instance</param>
        IQueryable<TEntity> GetById(int id);

        #endregion Queries
    }
}