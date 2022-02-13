using AnyJob.Application.Contracts;

namespace AnyJob.Application
{
    /// <summary>
    /// Provider of information (session) about current user
    /// </summary>
    public class UserInfoProvider : IUserInfoSetter
    {
        public Guid AnonymousId { get; set; }
    }
}
