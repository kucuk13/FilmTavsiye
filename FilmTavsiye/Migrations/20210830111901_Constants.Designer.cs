﻿// <auto-generated />
using System;
using FilmTavsiye.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FilmTavsiye.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210830111901_Constants")]
    partial class Constants
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("FilmTavsiye.Models.DbModels.Constant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CreatedMemberId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("DeletedMemberId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UpdatedMemberId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreatedMemberId");

                    b.HasIndex("DeletedMemberId");

                    b.HasIndex("UpdatedMemberId");

                    b.ToTable("Constants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(465),
                            CreatedMemberId = 1,
                            Name = "System Roles",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1220),
                            CreatedMemberId = 1,
                            Name = "Status",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateTime = new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1225),
                            CreatedMemberId = 1,
                            Name = "Task",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDateTime = new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1227),
                            CreatedMemberId = 1,
                            Name = "Movie Type",
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDateTime = new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1228),
                            CreatedMemberId = 1,
                            Name = "Country",
                            Status = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedDateTime = new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1231),
                            CreatedMemberId = 1,
                            Name = "Media Type",
                            Status = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedDateTime = new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1232),
                            CreatedMemberId = 1,
                            Name = "Photo Type",
                            Status = 1
                        },
                        new
                        {
                            Id = 8,
                            CreatedDateTime = new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1234),
                            CreatedMemberId = 1,
                            Name = "Video Type",
                            Status = 1
                        },
                        new
                        {
                            Id = 9,
                            CreatedDateTime = new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1235),
                            CreatedMemberId = 1,
                            Name = "Pegi",
                            Status = 1
                        });
                });

            modelBuilder.Entity("FilmTavsiye.Models.DbModels.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CreatedMemberId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("DeletedMemberId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UpdatedMemberId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2021, 8, 30, 14, 19, 0, 676, DateTimeKind.Local).AddTicks(7738),
                            CreatedMemberId = 1,
                            Name = "admin",
                            Password = "123456",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2021, 8, 30, 14, 19, 0, 677, DateTimeKind.Local).AddTicks(7768),
                            CreatedMemberId = 1,
                            Name = "editor",
                            Password = "123456",
                            Status = 1
                        });
                });

            modelBuilder.Entity("FilmTavsiye.Models.DbModels.Constant", b =>
                {
                    b.HasOne("FilmTavsiye.Models.DbModels.Member", "CreatedMember")
                        .WithMany()
                        .HasForeignKey("CreatedMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilmTavsiye.Models.DbModels.Member", "DeletedMember")
                        .WithMany()
                        .HasForeignKey("DeletedMemberId");

                    b.HasOne("FilmTavsiye.Models.DbModels.Member", "UpdatedMember")
                        .WithMany()
                        .HasForeignKey("UpdatedMemberId");

                    b.Navigation("CreatedMember");

                    b.Navigation("DeletedMember");

                    b.Navigation("UpdatedMember");
                });
#pragma warning restore 612, 618
        }
    }
}