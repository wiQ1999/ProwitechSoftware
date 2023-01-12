﻿using Infrastructure.Database;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenericRolesRepository : GenericRepository<Role>
{
    public GenericRolesRepository(ProwitechDbContext dbContext) 
        : base(dbContext, AppSource.Roles)
    { }

    public override async Task<Guid> CreateAsync(Role role, CancellationToken cancellationToken)
    {
        await ThrowIfNotValid(role, cancellationToken);
        return await base.CreateAsync(role, cancellationToken);
    }

    private async Task ThrowIfNotValid(Role role, CancellationToken cancellationToken)
    {
        if (role.Name == null)
            throw new RequiredValueException(Source, nameof(role.Name));

        if (role.Name!.Length > 50)
            throw new InvalidLengthException(Source, nameof(role.Name), 50);

        if (await DbSet.AnyAsync(r => r.Name == role.Name, cancellationToken))
            throw new NotUniqueInDbException(Source, role.Name, nameof(role.Name));
    }

    public override async Task UpdateAsync(Role role, CancellationToken cancellationToken)
    {
        await ThrowIfNotValid(role, cancellationToken);
        await base.UpdateAsync(role, cancellationToken);
    }
}