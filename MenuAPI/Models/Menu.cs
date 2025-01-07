namespace MenuBackend.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string MainLanguage { get; set; }
        public required string Picture { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsAvailable { get; set; }

        public int CompanyId { get; set; }
        public required Company Company { get; set; }
        public ICollection<MenuDish>? MenuDishes { get; set; }
    }
}