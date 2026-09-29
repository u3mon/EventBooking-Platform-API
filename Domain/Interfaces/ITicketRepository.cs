using Domain.Entities;

namespace Domain.Interfaces;

public interface ITicketRepository
{
    Task<bool> AddTicketAsync(Ticket ticket);
    Task<List<Ticket>> GetTicketsAsync();
}