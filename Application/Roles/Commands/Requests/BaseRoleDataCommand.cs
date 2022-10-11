using System.ComponentModel.DataAnnotations;

namespace Application.Roles.Commands.Requests;
public record BaseRoleDataCommand([Required]string Name);
