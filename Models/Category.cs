namespace MealsAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public List<Meal>? Meals { get; set; }
    }
}
