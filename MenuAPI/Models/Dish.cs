namespace MenuBackend.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public required string SystemDishName { get; set; }
        public required string SystemDishDescription { get; set; }
        public required string ClientDishName { get; set; }
        public required string ClientDishDescription { get; set; }
        public required string ClientDishPicture { get; set; }
        public required string DishType { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<MenuDish>? MenuDishes { get; set; }
    }

}
