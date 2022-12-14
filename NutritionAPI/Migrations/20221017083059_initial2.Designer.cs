// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NutritionAPI.Context;

#nullable disable

namespace NutritionAPI.Migrations
{
    [DbContext(typeof(Nutricontext))]
    [Migration("20221017083059_initial2")]
    partial class initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NutritionAPI.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("brandstable");
                });

            modelBuilder.Entity("NutritionAPI.Models.Nutritional_Info", b =>
                {
                    b.Property<string>("fssai_lic_no")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Calcium")
                        .HasColumnType("int");

                    b.Property<int>("Cholesterol")
                        .HasColumnType("int");

                    b.Property<int>("Dietary_fibers")
                        .HasColumnType("int");

                    b.Property<int>("Energy")
                        .HasColumnType("int");

                    b.Property<int>("Energy_from_fat")
                        .HasColumnType("int");

                    b.Property<int>("Folate")
                        .HasColumnType("int");

                    b.Property<int>("Iron")
                        .HasColumnType("int");

                    b.Property<int>("Mono_Unsaturated_fatty_acids")
                        .HasColumnType("int");

                    b.Property<int>("Per_x_g")
                        .HasColumnType("int");

                    b.Property<int>("Poly_Unsaturated_fatty_acids")
                        .HasColumnType("int");

                    b.Property<int>("Protein")
                        .HasColumnType("int");

                    b.Property<int>("Saturated_fatty_acids")
                        .HasColumnType("int");

                    b.Property<int>("Serving_size")
                        .HasColumnType("int");

                    b.Property<int>("Sodium")
                        .HasColumnType("int");

                    b.Property<int>("Total_Carbohydrates")
                        .HasColumnType("int");

                    b.Property<int>("Total_Fat")
                        .HasColumnType("int");

                    b.Property<int>("Total_added_sugars_in_carbs")
                        .HasColumnType("int");

                    b.Property<int>("Total_sugars_in_Carbs")
                        .HasColumnType("int");

                    b.Property<int>("Trans_fatty_acids")
                        .HasColumnType("int");

                    b.Property<int>("Vitamin_B1")
                        .HasColumnType("int");

                    b.Property<int>("Vitamin_B12")
                        .HasColumnType("int");

                    b.Property<int>("Vitamin_B2")
                        .HasColumnType("int");

                    b.Property<int>("Vitamin_B3")
                        .HasColumnType("int");

                    b.Property<int>("Vitamin_B6")
                        .HasColumnType("int");

                    b.Property<int>("Vitamin_C")
                        .HasColumnType("int");

                    b.Property<int>("Zinc")
                        .HasColumnType("int");

                    b.HasKey("fssai_lic_no");

                    b.ToTable("Nutritiontable");
                });

            modelBuilder.Entity("NutritionAPI.Models.Product", b =>
                {
                    b.Property<int>("Fssai_Lic_no")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Fssai_Lic_no"), 1L, 1);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("nutri_infofssai_lic_no")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Fssai_Lic_no");

                    b.HasIndex("BrandId");

                    b.HasIndex("nutri_infofssai_lic_no");

                    b.ToTable("productstable");
                });

            modelBuilder.Entity("NutritionAPI.Models.size_options", b =>
                {
                    b.Property<int>("Size")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Size"), 1L, 1);

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProductFssai_Lic_no")
                        .HasColumnType("int");

                    b.Property<int>("Servigs_in_size")
                        .HasColumnType("int");

                    b.HasKey("Size");

                    b.HasIndex("ProductFssai_Lic_no");

                    b.ToTable("sizeoptionsstable");
                });

            modelBuilder.Entity("NutritionAPI.Models.Product", b =>
                {
                    b.HasOne("NutritionAPI.Models.Brand", null)
                        .WithMany("product_lineup")
                        .HasForeignKey("BrandId");

                    b.HasOne("NutritionAPI.Models.Nutritional_Info", "nutri_info")
                        .WithMany()
                        .HasForeignKey("nutri_infofssai_lic_no");

                    b.Navigation("nutri_info");
                });

            modelBuilder.Entity("NutritionAPI.Models.size_options", b =>
                {
                    b.HasOne("NutritionAPI.Models.Product", null)
                        .WithMany("size_range")
                        .HasForeignKey("ProductFssai_Lic_no");
                });

            modelBuilder.Entity("NutritionAPI.Models.Brand", b =>
                {
                    b.Navigation("product_lineup");
                });

            modelBuilder.Entity("NutritionAPI.Models.Product", b =>
                {
                    b.Navigation("size_range");
                });
#pragma warning restore 612, 618
        }
    }
}
