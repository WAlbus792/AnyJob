namespace AnyJob.Persistence.Repositories
{
    /// <summary>
    /// Database data updater
    /// </summary>
    public interface IDbChangesUpdater
    {
        /// <summary>
        /// Save all made changes to database
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// Save all made changes to database asynchronous
        /// </summary>
        Task SaveChangesAsync();
    }
}
