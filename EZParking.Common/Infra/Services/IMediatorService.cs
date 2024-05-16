﻿using MediatR;

namespace EZParking.Common.Infra.Services
{
    public interface IMediatorService
    {
        IAsyncEnumerable<TResponse> CreateStream<TResponse>(IStreamRequest<TResponse> request, CancellationToken cancellationToken = default);
        IAsyncEnumerable<object?> CreateStream(object request, CancellationToken cancellationToken = default);
        Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default);
        Task Send<TRequest>(TRequest request, CancellationToken cancellationToken = default) where TRequest : IRequest;
        Task<object?> Send(object request, CancellationToken cancellationToken = default);
    }
}
