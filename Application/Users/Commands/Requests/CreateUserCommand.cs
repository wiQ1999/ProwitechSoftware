using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Users.Commands.Requests;
public record CreateUserCommand : BaseUserDataCommand, IRequest<Guid>
{
    [Required]
    [MinLength(8)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8}$")]
    public string? Password { get; set; }
}
