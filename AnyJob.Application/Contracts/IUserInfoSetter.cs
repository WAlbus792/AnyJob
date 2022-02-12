namespace AnyJob.Application.Contracts
{
    /// <summary>
    /// Setter of information (session) about current user
    /// </summary>
    public interface IUserInfoSetter : IUserInfoProvider
    {
        new Guid AnonymousId { get; set; }
    }
}
