﻿// <auto-generated />
using ApiLocacaoCarro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiLocacaoCarro.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("ApiLocacaoCarro.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("ApiLocacaoCarro.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ModelCarsModelCarId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ModelId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PricePerDay")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("CarId");

                    b.HasIndex("ModelCarsModelCarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("ApiLocacaoCarro.Models.ModelCar", b =>
                {
                    b.Property<int>("ModelCarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrandId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ModelCarId");

                    b.HasIndex("BrandId");

                    b.ToTable("ModelCars");
                });

            modelBuilder.Entity("ApiLocacaoCarro.Models.Car", b =>
                {
                    b.HasOne("ApiLocacaoCarro.Models.ModelCar", "ModelCars")
                        .WithMany("Cars")
                        .HasForeignKey("ModelCarsModelCarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModelCars");
                });

            modelBuilder.Entity("ApiLocacaoCarro.Models.ModelCar", b =>
                {
                    b.HasOne("ApiLocacaoCarro.Models.Brand", "Brand")
                        .WithMany("ModelsCars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("ApiLocacaoCarro.Models.Brand", b =>
                {
                    b.Navigation("ModelsCars");
                });

            modelBuilder.Entity("ApiLocacaoCarro.Models.ModelCar", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
