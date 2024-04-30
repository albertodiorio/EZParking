using MediatR;

namespace EZParking.Common.Infra.Services
{
    public sealed class MediatorService(IMediator mediator) : IMediatorService, ISender
    {
        private readonly IMediator _mediator = mediator;

        public IAsyncEnumerable<TResponse> CreateStream<TResponse>(IStreamRequest<TResponse> request, CancellationToken cancellationToken = default)
            => _mediator.CreateStream(request, cancellationToken);

        public IAsyncEnumerable<object?> CreateStream(object request, CancellationToken cancellationToken = default)
            => _mediator.CreateStream(request, cancellationToken);

        public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
            => _mediator.Send(request, cancellationToken);

        public Task Send<TRequest>(TRequest request, CancellationToken cancellationToken = default) where TRequest : IRequest
            => _mediator.Send(request, cancellationToken);

        public Task<object?> Send(object request, CancellationToken cancellationToken = default)
            => _mediator.Send(request, cancellationToken);
    }
}
