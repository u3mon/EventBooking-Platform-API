using Domain.Entities;

namespace Domain.Interfaces;

public interface IOrganizerRepository
{
    Task<bool> AddOrganizerAsync(Organizer organizer);
    Task<List<Organizer>> GetOrganizersAsync();
    Task<List<Organizer>> GetOrganizersWithEventsAsync(); 
}