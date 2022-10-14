using Application.Errors.Queries.Requests;
using Infrastructure.Models.ExceptionResponses;
using Infrastructure.Models.Exceptions;
using MediatR;
using System.Net;

namespace Application.Errors.Queries.Handlers;
public class GetHandledExceptionResponseQuerieHandler : IRequestHandler<GetHandledExceptionResponseQuerie, ExceptionResponse>
{
    public Task<ExceptionResponse> Handle(GetHandledExceptionResponseQuerie request, CancellationToken cancellationToken)
    {
        var response = new ExceptionResponse
        {
            Title = "Błąd",
            StatusCode = HttpStatusCode.InternalServerError
        };

        if (request.Exception is NotFoundInDbExcption ex)
        {
            response.Title = ex.Message;
            response.StatusCode = HttpStatusCode.BadRequest;
        }
        // ...
        else response.Title = request.Exception.Message;

        return Task.FromResult(response);
    }
}
