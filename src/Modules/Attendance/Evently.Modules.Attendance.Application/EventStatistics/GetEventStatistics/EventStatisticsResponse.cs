namespace Evently.Modules.Attendance.Application.EventStatistics.GetEventStatistics;

public sealed record EventStatisticsResponse
{
    public Guid EventId { get; init; }
    public string Title { get; init; } = null!;
    public string Description { get; init; } = null!;
    public string Location { get; init; } = null!;
    public DateTime StartsAtUtc { get; init; }
    public DateTime? EndsAtUtc { get; init; }
    public int TicketsSold { get; init; }
    public int AttendeesCheckedIn { get; init; }
    public string[] DuplicateCheckInTickets { get; init; } = [];
    public string[] InvalidCheckInTickets { get; init; } = [];
}
