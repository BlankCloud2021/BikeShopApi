// <auto-generated />
using System;
using BikeShopApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BikeShopApi.Migrations
{
    [DbContext(typeof(BikeShopApiDbContext))]
    [Migration("20210427145146_homebikeshop")]
    partial class homebikeshop
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BikeExtraFeature", b =>
                {
                    b.Property<int>("BikesId")
                        .HasColumnType("int");

                    b.Property<int>("ExtraFeaturesId")
                        .HasColumnType("int");

                    b.HasKey("BikesId", "ExtraFeaturesId");

                    b.HasIndex("ExtraFeaturesId");

                    b.ToTable("BikeExtraFeature");
                });

            modelBuilder.Entity("BikeShopApi.Models.Bike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<float>("FrameSize")
                        .HasColumnType("real");

                    b.Property<int>("HomeBikeShopId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnHire")
                        .HasColumnType("bit");

                    b.Property<int>("OnHireCustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("HomeBikeShopId");

                    b.ToTable("Bikes");
                });

            modelBuilder.Entity("BikeShopApi.Models.BikeShop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BikeShops");
                });

            modelBuilder.Entity("BikeShopApi.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BikeShopApi.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BikeShopId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BikeShopId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BikeShopApi.Models.ExtraFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Feature")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExtraFeatures");
                });

            modelBuilder.Entity("BikeShopApi.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BikeId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("ResrvationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnByDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnedOnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BikeId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BikeShopApi.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CurrentBikeShopId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentLocationId")
                        .HasColumnType("int");

                    b.Property<int?>("PickUpBikeShopId")
                        .HasColumnType("int");

                    b.Property<int>("PickUpLocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PickUpdate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CurrentBikeShopId");

                    b.HasIndex("PickUpBikeShopId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("BikeExtraFeature", b =>
                {
                    b.HasOne("BikeShopApi.Models.Bike", null)
                        .WithMany()
                        .HasForeignKey("BikesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BikeShopApi.Models.ExtraFeature", null)
                        .WithMany()
                        .HasForeignKey("ExtraFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BikeShopApi.Models.Bike", b =>
                {
                    b.HasOne("BikeShopApi.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("BikeShopApi.Models.BikeShop", "HomeBikeShop")
                        .WithMany()
                        .HasForeignKey("HomeBikeShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("HomeBikeShop");
                });

            modelBuilder.Entity("BikeShopApi.Models.Employee", b =>
                {
                    b.HasOne("BikeShopApi.Models.BikeShop", "BikeShop")
                        .WithMany()
                        .HasForeignKey("BikeShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BikeShop");
                });

            modelBuilder.Entity("BikeShopApi.Models.Order", b =>
                {
                    b.HasOne("BikeShopApi.Models.Bike", "Bike")
                        .WithMany()
                        .HasForeignKey("BikeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BikeShopApi.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BikeShopApi.Models.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId");

                    b.Navigation("Bike");

                    b.Navigation("Customer");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("BikeShopApi.Models.Reservation", b =>
                {
                    b.HasOne("BikeShopApi.Models.BikeShop", "CurrentBikeShop")
                        .WithMany()
                        .HasForeignKey("CurrentBikeShopId");

                    b.HasOne("BikeShopApi.Models.BikeShop", "PickUpBikeShop")
                        .WithMany()
                        .HasForeignKey("PickUpBikeShopId");

                    b.Navigation("CurrentBikeShop");

                    b.Navigation("PickUpBikeShop");
                });
#pragma warning restore 612, 618
        }
    }
}
