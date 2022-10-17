using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutritionAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brandstable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brandstable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutritiontable",
                columns: table => new
                {
                    fssai_lic_no = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Serving_size = table.Column<int>(type: "int", nullable: false),
                    Per_x_g = table.Column<int>(type: "int", nullable: false),
                    Energy = table.Column<int>(type: "int", nullable: false),
                    Energy_from_fat = table.Column<int>(type: "int", nullable: false),
                    Total_Fat = table.Column<int>(type: "int", nullable: false),
                    Saturated_fatty_acids = table.Column<int>(type: "int", nullable: false),
                    Mono_Unsaturated_fatty_acids = table.Column<int>(type: "int", nullable: false),
                    Poly_Unsaturated_fatty_acids = table.Column<int>(type: "int", nullable: false),
                    Trans_fatty_acids = table.Column<int>(type: "int", nullable: false),
                    Cholesterol = table.Column<int>(type: "int", nullable: false),
                    Total_Carbohydrates = table.Column<int>(type: "int", nullable: false),
                    Total_sugars_in_Carbs = table.Column<int>(type: "int", nullable: false),
                    Total_added_sugars_in_carbs = table.Column<int>(type: "int", nullable: false),
                    Dietary_fibers = table.Column<int>(type: "int", nullable: false),
                    Protein = table.Column<int>(type: "int", nullable: false),
                    Sodium = table.Column<int>(type: "int", nullable: false),
                    Vitamin_C = table.Column<int>(type: "int", nullable: false),
                    Vitamin_B1 = table.Column<int>(type: "int", nullable: false),
                    Vitamin_B2 = table.Column<int>(type: "int", nullable: false),
                    Vitamin_B3 = table.Column<int>(type: "int", nullable: false),
                    Vitamin_B6 = table.Column<int>(type: "int", nullable: false),
                    Vitamin_B12 = table.Column<int>(type: "int", nullable: false),
                    Folate = table.Column<int>(type: "int", nullable: false),
                    Iron = table.Column<int>(type: "int", nullable: false),
                    Calcium = table.Column<int>(type: "int", nullable: false),
                    Zinc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutritiontable", x => x.fssai_lic_no);
                });

            migrationBuilder.CreateTable(
                name: "productstable",
                columns: table => new
                {
                    Fssai_Lic_no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nutri_infofssai_lic_no = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productstable", x => x.Fssai_Lic_no);
                    table.ForeignKey(
                        name: "FK_productstable_brandstable_BrandId",
                        column: x => x.BrandId,
                        principalTable: "brandstable",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_productstable_Nutritiontable_nutri_infofssai_lic_no",
                        column: x => x.nutri_infofssai_lic_no,
                        principalTable: "Nutritiontable",
                        principalColumn: "fssai_lic_no");
                });

            migrationBuilder.CreateTable(
                name: "sizeoptionsstable",
                columns: table => new
                {
                    Size = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Servigs_in_size = table.Column<int>(type: "int", nullable: false),
                    ProductFssai_Lic_no = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sizeoptionsstable", x => x.Size);
                    table.ForeignKey(
                        name: "FK_sizeoptionsstable_productstable_ProductFssai_Lic_no",
                        column: x => x.ProductFssai_Lic_no,
                        principalTable: "productstable",
                        principalColumn: "Fssai_Lic_no");
                });

            migrationBuilder.CreateIndex(
                name: "IX_productstable_BrandId",
                table: "productstable",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_productstable_nutri_infofssai_lic_no",
                table: "productstable",
                column: "nutri_infofssai_lic_no");

            migrationBuilder.CreateIndex(
                name: "IX_sizeoptionsstable_ProductFssai_Lic_no",
                table: "sizeoptionsstable",
                column: "ProductFssai_Lic_no");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sizeoptionsstable");

            migrationBuilder.DropTable(
                name: "productstable");

            migrationBuilder.DropTable(
                name: "brandstable");

            migrationBuilder.DropTable(
                name: "Nutritiontable");
        }
    }
}
