﻿// <auto-generated />
using System;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(FindMeDbContext))]
    partial class FindMeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationCore.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new { Id = 1, Name = "Baku" }
                    );
                });

            modelBuilder.Entity("ApplicationCore.Models.Institution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("CityId");

                    b.Property<int>("InstitutionTypeId");

                    b.Property<bool>("IsAdmin");

                    b.Property<double>("Latitude");

                    b.Property<string>("Login")
                        .IsRequired();

                    b.Property<double>("Longitude");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("OpeningHours")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Website")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("InstitutionTypeId");

                    b.ToTable("Institutions");

                    b.HasData(
                        new { Id = 1, Address = "Underground", CityId = 1, InstitutionTypeId = 1, IsAdmin = true, Latitude = 40.409264, Login = "admin", Longitude = 49.867092, Name = "admin", OpeningHours = "24/7", Password = "SIzsvsMpIVd0wR9vTjY7A/1Wth1tcMTx0OK3A2V9BI00UjTv", Phone = "+994-55-148-82-28", Website = "www.admin.com" }
                    );
                });

            modelBuilder.Entity("ApplicationCore.Models.InstitutionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("InstitutionTypes");

                    b.HasData(
                        new { Id = 1, Type = "Medical" }
                    );
                });

            modelBuilder.Entity("ApplicationCore.Models.Lost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgeBegin");

                    b.Property<int>("AgeEnd");

                    b.Property<string>("BodyType")
                        .IsRequired();

                    b.Property<string>("Clothes")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Comment")
                        .HasMaxLength(300);

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<string>("DetectionDescription")
                        .HasMaxLength(300);

                    b.Property<DateTime>("DetectionTime");

                    b.Property<string>("EyeColor");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30);

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("HairColor");

                    b.Property<int>("Height");

                    b.Property<string>("ImagePath")
                        .HasMaxLength(228);

                    b.Property<int>("InstitutionId");

                    b.Property<bool>("IsFound");

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50);

                    b.Property<string>("Signs")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("Losts");
                });

            modelBuilder.Entity("ApplicationCore.Models.Institution", b =>
                {
                    b.HasOne("ApplicationCore.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApplicationCore.Models.InstitutionType", "InstitutionType")
                        .WithMany()
                        .HasForeignKey("InstitutionTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApplicationCore.Models.Lost", b =>
                {
                    b.HasOne("ApplicationCore.Models.Institution", "Institution")
                        .WithMany()
                        .HasForeignKey("InstitutionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}