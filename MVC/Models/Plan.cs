namespace MVC.Models
{
    public class Plan
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Description { get; set; } = null!;
        public int DurationDays { get; set; } = 0;
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

    }
}
