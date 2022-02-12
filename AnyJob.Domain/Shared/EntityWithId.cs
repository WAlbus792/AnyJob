namespace AnyJob.Domain.Shared;

/// <summary>
/// Interface for entities, which instances have Id
/// </summary>
/// <typeparam name="T">Type of Id</typeparam>
public interface IEntityWithId<out T>
    where T: IComparable
{
    T Id { get; }
}

public class EntityWithId : IEntityWithId<int>
{
    public int Id { get; set; }
}

public class EntityWithId<T> : IEntityWithId<T>
    where T : IComparable
{
    public T Id { get; set; }
}