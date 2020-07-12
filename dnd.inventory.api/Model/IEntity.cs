using System;

namespace dnd.inventory.api.Model
{
    public interface IEntity<TKey>
        where TKey : struct, IComparable<TKey>
    {
        TKey Id { get; }
    }

    public interface IEntity : IEntity<int>
    {
    }
}
