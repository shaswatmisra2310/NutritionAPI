using System.ComponentModel.DataAnnotations;

namespace NutritionAPI.Models
{
    public class Product
    {
        [Key]
        public int Fssai_Lic_no { get; set; }

        public string product_name { get; set; }

        public Nutritional_Info nutri_info { get; set; }

        public size_options[] size_range { get; set; }
    }
}
