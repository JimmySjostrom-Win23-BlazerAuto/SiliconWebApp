using System.ComponentModel.DataAnnotations;

namespace SiliconWebApp.Entities;

public class OrderEntity
{
    [Key]
    public int Id { get; set; }
    public string CourseId { get; set; } = null!;
    public string UserId { get; set; } = null!;
}