﻿using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to availabilities.
/// </summary>
public class AvailabilityRepository : Repository<Availability>, IAvailabilityRepository
{
    protected AvailabilityRepository(PatDbContext context) 
        : base(context)
    {
    }
}