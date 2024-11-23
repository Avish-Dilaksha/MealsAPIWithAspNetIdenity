namespace MealsAPI.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public float Price { get; set; }
        public string? Rating { get; set; }
        public int CategoryId { get; set; }
    }
}
