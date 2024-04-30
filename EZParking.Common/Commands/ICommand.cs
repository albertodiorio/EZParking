using EZParking.Common.Validations;
using MediatR;

namespace EZParking.Common.Messaging
{
    public interface ICommand : IRequest<Result>
    {
    }

    public interface ICommand<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
