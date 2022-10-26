using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Authentication.Queries.Requests;

public record LoginQuery : IRequest<string>
{
    [Required]
    public string Login { get; set; } = null!;

    public string Password { get; set; } = string.Empty;
}
