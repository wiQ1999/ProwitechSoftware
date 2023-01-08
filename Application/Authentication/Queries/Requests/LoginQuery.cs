using Application.Authentication.DTOs;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Authentication.Queries.Requests;

public record LoginQuery : IRequest<AuthenticationResponse>
{
    [Required]
    public string Login { get; set; } = default!;

    public string Password { get; set; } = default!;
}
