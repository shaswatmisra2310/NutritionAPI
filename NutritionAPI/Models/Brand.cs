namespace NutritionAPI.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public Product[] product_lineup { get; set; }



    }
}
