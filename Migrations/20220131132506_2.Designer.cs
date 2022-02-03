﻿// <auto-generated />
using MVC_Basics.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_Basics.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220131132506_2")]
    partial class _2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_Basics.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Name = "Red Crabs"
                        },
                        new
                        {
                            CategoryID = 2,
                            Name = "Brown Crabs"
                        },
                        new
                        {
                            CategoryID = 3,
                            Name = "Blue Crabs"
                        });
                });

            modelBuilder.Entity("MVC_Basics.Models.Crab", b =>
                {
                    b.Property<int>("CrabID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCrabOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("CrabID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Crabs");

                    b.HasData(
                        new
                        {
                            CrabID = 1,
                            CategoryID = 1,
                            Description = "Description brown crab",
                            ImageUrl = "https://images.unsplash.com/photo-1615834751896-b15e2330b289?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1434&q=80",
                            IsCrabOfTheWeek = true,
                            Name = "Brown Crab",
                            Price = 1.0
                        },
                        new
                        {
                            CrabID = 2,
                            CategoryID = 2,
                            Description = "Description bluecrab",
                            ImageUrl = "https://images.unsplash.com/photo-1509415173911-37ff7a1aa29c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1135&q=80",
                            IsCrabOfTheWeek = false,
                            Name = "Blue Crab",
                            Price = 2.0
                        },
                        new
                        {
                            CrabID = 3,
                            CategoryID = 3,
                            Description = "Description bluecrab",
                            ImageUrl = "https://images.unsplash.com/photo-1580841129862-bc2a2d113c45?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2073&q=80",
                            IsCrabOfTheWeek = false,
                            Name = "Red Crab",
                            Price = 3.0
                        },
                        new
                        {
                            CrabID = 4,
                            CategoryID = 1,
                            Description = "Description brown crab",
                            ImageUrl = "https://images.unsplash.com/photo-1615834751896-b15e2330b289?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1434&q=80",
                            IsCrabOfTheWeek = false,
                            Name = "Browner Crab",
                            Price = 4.0
                        },
                        new
                        {
                            CrabID = 5,
                            CategoryID = 2,
                            Description = "Description bluercrab",
                            ImageUrl = "https://images.unsplash.com/photo-1509415173911-37ff7a1aa29c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1135&q=80",
                            IsCrabOfTheWeek = false,
                            Name = "Bluer Crab",
                            Price = 5.0
                        },
                        new
                        {
                            CrabID = 6,
                            CategoryID = 3,
                            Description = "Description bluecrab",
                            ImageUrl = "https://images.unsplash.com/photo-1580841129862-bc2a2d113c45?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2073&q=80",
                            IsCrabOfTheWeek = false,
                            Name = "Reder Crab",
                            Price = 6.0
                        });
                });

            modelBuilder.Entity("MVC_Basics.Models.Crab", b =>
                {
                    b.HasOne("MVC_Basics.Models.Category", null)
                        .WithMany("Crabs")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_Basics.Models.Category", b =>
                {
                    b.Navigation("Crabs");
                });
#pragma warning restore 612, 618
        }
    }
}
