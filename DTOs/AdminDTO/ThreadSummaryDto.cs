namespace ArcadeProject.DTOs.AdminDTO;

public class ThreadSummaryDto
{
    public int      Id         { get; init; }
    public string   Title      { get; init; } = string.Empty;
    public string   AuthorName { get; init; } = string.Empty;
    public int      PostCount  { get; init; }
    public DateTime CreatedAt  { get; init; }
}
