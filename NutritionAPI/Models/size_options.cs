using System.ComponentModel.DataAnnotations;

namespace NutritionAPI.Models
{
    public class size_options
    {
        [Key]
        public int Size { get; set; }

        public int Price { get; set; }

        public int Servigs_in_size { get; set; }
    }
}
