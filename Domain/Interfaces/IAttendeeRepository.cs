using Domain.Entities;

namespace Domain.Interfaces;

public interface IAttendeeRepository
{
    Task<bool> AddAttendeeAsync(Attendee attendee);
    Task<List<Attendee>> GetAttendeesAsync();
    Task<bool> UpdateAttendeeAsync(Attendee attendee);
}