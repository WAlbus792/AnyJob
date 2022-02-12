namespace AnyJob.Application.Contracts
{
    /// <summary>
    /// Provider of information (session) about current user
    /// </summary>
    public interface IUserInfoProvider
    {
        Guid AnonymousId { get; }
    }
}