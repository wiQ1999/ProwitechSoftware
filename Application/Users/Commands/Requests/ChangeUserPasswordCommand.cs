using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Users.Commands.Requests;
public record ChangeUserPasswordCommand : IRequest
{
    public Guid Id { get; set; }
    [Required]
    [MinLength(8)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8}$")]
    public string? Password { get; set; }
}
