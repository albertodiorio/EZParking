using MediatR;

namespace EZParking.Common.DomainEvents
{
    public interface IDomainEventHandler<TEvent> : INotificationHandler<TEvent>
    where TEvent : IDomainEvent
    {
    }
}
