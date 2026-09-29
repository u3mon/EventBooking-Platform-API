using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class VenueRepository(AppDbContext appDbContext): IVenueRepository
{
    private readonly AppDbContext context = appDbContext;

    public async Task<bool> AddVenueAsync(Venue venue)
    {
        context.Venues.Add(venue);
        var res = await context.SaveChangesAsync();
        return res > 0;
    }
    public async Task<List<Venue>> GetVenuesAsync()
    {
        return await context.Venues.ToListAsync();
    }
    public async Task<bool> DeleteVenueAsync(int id)
    {
        var venue = await context.Venues.SingleOrDefaultAsync(x=> x.Id == id);
        if(venue != null)
            context.Venues.Remove(venue);
        var res = await context.SaveChangesAsync();
        return res > 0;
    }
}