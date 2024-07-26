﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_1.Entities;

#nullable disable

namespace Project_1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240719194325_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project_1.Entities.InventoryItem", b =>
                {
                    b.Property<int>("product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("product_id"));

                    b.Property<string>("last_received")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("product_id")
                        .HasName("PrimaryKey_inventory_id");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("Project_1.Entities.OrderedItem", b =>
                {
                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<string>("last_ordered")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<string>("product_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("product_id")
                        .HasName("PrimaryKey_order_id");

                    b.ToTable("OrderedItems");
                });

            modelBuilder.Entity("Project_1.Entities.OrderedItem", b =>
                {
                    b.HasOne("Project_1.Entities.InventoryItem", "inventory_item")
                        .WithOne("ordered_item")
                        .HasForeignKey("Project_1.Entities.OrderedItem", "product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("inventory_item");
                });

            modelBuilder.Entity("Project_1.Entities.InventoryItem", b =>
                {
                    b.Navigation("ordered_item");
                });
#pragma warning restore 612, 618
        }
    }
}
