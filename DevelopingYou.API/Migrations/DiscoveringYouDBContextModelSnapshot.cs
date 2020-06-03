﻿// <auto-generated />
using System;
using DevelopingYou.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DevelopingYou.API.Migrations
{
    [DbContext(typeof(DiscoveringYouDBContext))]
    partial class DiscoveringYouDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("GoalId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GoalId");

                    b.ToTable("Instance");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Played Candy Crush instead of coding, could have utilized my time better",
                            EndTime = new DateTime(2020, 6, 13, 4, 45, 12, 0, DateTimeKind.Utc),
                            GoalId = 1,
                            StartTime = new DateTime(2020, 6, 13, 4, 30, 12, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Video called sister and nephew, was fun",
                            EndTime = new DateTime(2020, 6, 13, 7, 0, 12, 0, DateTimeKind.Utc),
                            GoalId = 1,
                            StartTime = new DateTime(2020, 6, 13, 6, 5, 12, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Coffee Zoom Meeting, beneficial networking",
                            EndTime = new DateTime(2020, 6, 13, 10, 0, 12, 0, DateTimeKind.Utc),
                            GoalId = 1,
                            StartTime = new DateTime(2020, 6, 13, 9, 0, 12, 0, DateTimeKind.Utc)
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
