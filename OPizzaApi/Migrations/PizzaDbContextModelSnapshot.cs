﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OPizzaApi.Data;

#nullable disable

namespace OPizzaApi.Migrations
{
    [DbContext(typeof(PizzaDbContext))]
    partial class PizzaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OPizzaApi.Model.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Anchovies")
                        .HasColumnType("bit");

                    b.Property<bool>("Bacon")
                        .HasColumnType("bit");

                    b.Property<string>("CheeseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FinalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("GreenPeppers")
                        .HasColumnType("bit");

                    b.Property<bool>("Ham")
                        .HasColumnType("bit");

                    b.Property<bool>("Jalapenos")
                        .HasColumnType("bit");

                    b.Property<bool>("Mushrooms")
                        .HasColumnType("bit");

                    b.Property<bool>("Olives")
                        .HasColumnType("bit");

                    b.Property<bool>("Onions")
                        .HasColumnType("bit");

                    b.Property<bool>("Pepperoni")
                        .HasColumnType("bit");

                    b.Property<bool>("Pineapple")
                        .HasColumnType("bit");

                    b.Property<string>("PizzaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TomatoSauce")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}