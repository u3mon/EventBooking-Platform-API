using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class OrganizerRepository(AppDbContext appDbContext):IOrganizerRepository
{
    private readonly AppDbContext context = appDbContext;

    public async Task<bool> AddOrganizerAsync(Organizer organizer)
    {
        context.Organizers.Add(organizer);
        var res = await context.SaveChangesAsync();
        return res > 0;
    }

    public async Task<List<Organizer>> GetOrganizersAsync()
    {
        return await context.Organizers.ToListAsync();
    }

    public async Task<List<Organizer>> GetOrganizersWithEventsAsync()
    {
        return await context.Organizers 
                        .Include(x=> x.Events)
                        .ToListAsync();
    }
}