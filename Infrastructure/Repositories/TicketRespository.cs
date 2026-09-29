using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class TicketRespository(AppDbContext appDbContext) : ITicketRepository
{
    private readonly AppDbContext context = appDbContext;

    public async Task<bool> AddTicketAsync(Ticket ticket)
    {
        context.Tickets.Add(ticket);
        var res = await context.SaveChangesAsync();
        return res > 0;
    }

    public async Task<List<Ticket>> GetTicketsAsync()
    {
        return await context.Tickets.ToListAsync();
    }
}