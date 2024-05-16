
using EZParking.Common.Validations;
using System.Diagnostics.CodeAnalysis;


namespace EZParking.Core.DomainObjects
{
    public abstract class Entity : IEqualityComparer<Entity>
    {
        public Guid Id { get; private init; }
        public ValidationResult? ValidationResult { get; protected set; }

        protected Entity()
            => Id = Guid.NewGuid();

        public bool Equals(Entity? x, Entity? y)
        {
            if (x is null && y is null)
                return true;

            if (x is null || y is null)
                return false;

            return x.Equals(y);
        }

        public int GetHashCode([DisallowNull] Entity obj)
            => (GetType().GetHashCode() * 907) + Id.GetHashCode();

        public override string ToString()
            => GetType().Name + " [Id=" + Id + "]";
    }
}
