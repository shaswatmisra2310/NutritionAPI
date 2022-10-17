using System.ComponentModel.DataAnnotations;

namespace NutritionAPI.Models
{
    public class Nutritional_Info
    {
        [Key]
        public string fssai_lic_no { get; set; }
        public int Serving_size { get; set; }

        public int Per_x_g { get; set; }
        public int Energy { get; set; }

        public int Energy_from_fat { get; set; }

        public int Total_Fat { get; set; }

        public int Saturated_fatty_acids { get; set; }

        public int Mono_Unsaturated_fatty_acids { get; set; }

        public int Poly_Unsaturated_fatty_acids { get; set; }

        public int Trans_fatty_acids { get; set; }

        public int Cholesterol { get; set; }

        public int Total_Carbohydrates { get; set; }

        public int Total_sugars_in_Carbs { get; set; }

        public int Total_added_sugars_in_carbs { get; set; }

        public int Dietary_fibers { get; set; }

        public int Protein { get; set; }

        public int Sodium { get; set; }

        public int Vitamin_C { get; set; }

        public int Vitamin_B1 { get; set; }

        public int Vitamin_B2 { get; set; }

        public int Vitamin_B3 { get; set; }

        public int Vitamin_B6 { get; set; }

        public int Vitamin_B12 { get; set; }

        public int Folate { get; set; }

        public int Iron { get; set; }

        public int Calcium { get; set; }

        public int Zinc { get; set; }


    }
}
