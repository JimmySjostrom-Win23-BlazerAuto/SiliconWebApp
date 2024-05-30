namespace SiliconWebApp.Entities;

public class SavedCoursesEntity
{
    public int Id { get; set; }
    public string CourseId { get; set; } = null!;
    public string UserId { get; set; } = null!;
}
