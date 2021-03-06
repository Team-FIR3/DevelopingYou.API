﻿// <auto-generated />
using System;
using DevelopingYou.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DevelopingYou.API.Migrations
{
    [DbContext(typeof(DiscoveringYouDBContext))]
    [Migration("20200603160713_start-end-dates")]
    partial class startenddates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DevelopingYou.API.Models.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("StartValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TargetValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Goal");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 4,
                            EndDate = new DateTime(2020, 6, 16, 1, 45, 12, 0, DateTimeKind.Utc),
                            StartDate = new DateTime(2020, 6, 12, 2, 45, 12, 0, DateTimeKind.Utc),
                            StartValue = 5m,
                            TargetValue = 2m,
                            Title = "Less social media",
                            UserId = 0
                        });
                });

            modelBuilder.Entity("DevelopingYou.API.Models.Instance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GoalId")
                        .HasColumnType("int");

                    b.Property<string>("StartTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GoalId");

                    b.ToTable("Instance");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Played Candy Crush instead of coding, could have utilized my time better",
                            EndTime = "2020-06-01 13:41:23",
                            GoalId = 1,
                            StartTime = "2020-06-01 09:41:23"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Video called sister and nephew, was fun",
                            EndTime = "2020-06-02 12:41:23",
                            GoalId = 1,
                            StartTime = "2020-06-02 11:41:23"
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Coffee Zoom Meeting, beneficial networking",
                            EndTime = "2020-06-02 9:41:33",
                            GoalId = 1,
                            StartTime = "2020-06-02 07:15:11"
                        });
                });

            modelBuilder.Entity("DevelopingYou.API.Models.Instance", b =>
                {
                    b.HasOne("DevelopingYou.API.Models.Goal", "Goal")
                        .WithMany("Instances")
                        .HasForeignKey("GoalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
