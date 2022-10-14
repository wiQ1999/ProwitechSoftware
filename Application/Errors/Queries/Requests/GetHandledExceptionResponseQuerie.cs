using Infrastructure.Models.ExceptionResponses;
using MediatR;

namespace Application.Errors.Queries.Requests;
public record GetHandledExceptionResponseQuerie(Exception Exception) : IRequest<ExceptionResponse>;
