using EZParking.Common.Validations;
using MediatR;


namespace EZParking.Common.Queries
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
