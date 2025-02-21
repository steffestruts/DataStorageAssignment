using System.ComponentModel.DataAnnotations;

namespace Data.Entites;

public class Project
{
    [Required]
    public int Id { get; set; }
    public string ProjectNumber { get; set; } = $"P-{Guid.NewGuid().ToString().Substring(0, 5)}";
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int ManagerId { get; set; }
    public int CustomerId { get; set; }
    public string Service { get; set; } = string.Empty;
    public int ServicePrice { get; set; }
    public int TotalPrice { get; set; }
    public string Status { get; set; } = "Ej påbörjat";
}
