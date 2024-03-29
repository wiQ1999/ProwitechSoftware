﻿using Infrastructure.Models.Enums;

namespace Application.Permissions.DTOs;

public class PermissionDto
{
    public AppSource Source { get; set; }
    public bool Create { get; set; }
    public bool Read { get; set; }
    public bool Update { get; set; }
    public bool Delete { get; set; }
}
