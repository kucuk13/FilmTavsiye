// <auto-generated />
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
    [Migration("20210830120119_Notification")]
    partial class Notification
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
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(8649),
                            CreatedMemberId = 1,
                            Name = "System Roles",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9440),
                            CreatedMemberId = 1,
                            Name = "Status",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9446),
                            CreatedMemberId = 1,
                            Name = "Task",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9447),
                            CreatedMemberId = 1,
                            Name = "Movie Type",
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9449),
                            CreatedMemberId = 1,
                            Name = "Country",
                            Status = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9452),
                            CreatedMemberId = 1,
                            Name = "Media Type",
                            Status = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9454),
                            CreatedMemberId = 1,
                            Name = "Photo Type",
                            Status = 1
                        },
                        new
                        {
                            Id = 8,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9455),
                            CreatedMemberId = 1,
                            Name = "Video Type",
                            Status = 1
                        },
                        new
                        {
                            Id = 9,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9456),
                            CreatedMemberId = 1,
                            Name = "Pegi",
                            Status = 1
                        },
                        new
                        {
                            Id = 10,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9458),
                            CreatedMemberId = 1,
                            Name = "Menu Type",
                            Status = 1
                        },
                        new
                        {
                            Id = 11,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9459),
                            CreatedMemberId = 1,
                            Name = "Notification Type",
                            Status = 1
                        });
                });

            modelBuilder.Entity("FilmTavsiye.Models.DbModels.ConstantValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ConstantId")
                        .HasColumnType("integer");

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

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UpdatedMemberId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ConstantId");

                    b.HasIndex("CreatedMemberId");

                    b.HasIndex("DeletedMemberId");

                    b.HasIndex("UpdatedMemberId");

                    b.ToTable("ConstantValues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConstantId = 2,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(1690),
                            CreatedMemberId = 1,
                            Name = "Active",
                            Order = 0,
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            ConstantId = 2,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(2273),
                            CreatedMemberId = 1,
                            Name = "Passive",
                            Order = 0,
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            ConstantId = 2,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(2278),
                            CreatedMemberId = 1,
                            Name = "Deleted",
                            Order = 0,
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            ConstantId = 1,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(2280),
                            CreatedMemberId = 1,
                            Name = "Admin",
                            Order = 0,
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            ConstantId = 1,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(2281),
                            CreatedMemberId = 1,
                            Name = "Editor",
                            Order = 0,
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

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("text");

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
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 878, DateTimeKind.Local).AddTicks(7268),
                            CreatedMemberId = 1,
                            Name = "admin",
                            Password = "123456",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 879, DateTimeKind.Local).AddTicks(7449),
                            CreatedMemberId = 1,
                            Name = "editor",
                            Password = "123456",
                            Status = 1
                        });
                });

            modelBuilder.Entity("FilmTavsiye.Models.DbModels.MemberRole", b =>
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

                    b.Property<int>("MemberId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UpdatedMemberId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreatedMemberId");

                    b.HasIndex("DeletedMemberId");

                    b.HasIndex("MemberId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UpdatedMemberId");

                    b.ToTable("MemberRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(3869),
                            CreatedMemberId = 1,
                            MemberId = 1,
                            RoleId = 4,
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(4362),
                            CreatedMemberId = 1,
                            MemberId = 2,
                            RoleId = 5,
                            Status = 1
                        });
                });

            modelBuilder.Entity("FilmTavsiye.Models.DbModels.Movie", b =>
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

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UpdatedMemberId")
                        .HasColumnType("integer");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreatedMemberId");

                    b.HasIndex("DeletedMemberId");

                    b.HasIndex("UpdatedMemberId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("FilmTavsiye.Models.DbModels.Notification", b =>
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

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int?>("TypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UpdatedMemberId")
                        .HasColumnType("integer");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatedMemberId");

                    b.HasIndex("DeletedMemberId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UpdatedMemberId");

                    b.ToTable("Notifications");
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

            modelBuilder.Entity("FilmTavsiye.Models.DbModels.ConstantValue", b =>
                {
                    b.HasOne("FilmTavsiye.Models.DbModels.Constant", "Constant")
                        .WithMany()
                        .HasForeignKey("ConstantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

                    b.Navigation("Constant");

                    b.Navigation("CreatedMember");

                    b.Navigation("DeletedMember");

                    b.Navigation("UpdatedMember");
                });

            modelBuilder.Entity("FilmTavsiye.Models.DbModels.MemberRole", b =>
                {
                    b.HasOne("FilmTavsiye.Models.DbModels.Member", "CreatedMember")
                        .WithMany()
                        .HasForeignKey("CreatedMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilmTavsiye.Models.DbModels.Member", "DeletedMember")
                        .WithMany()
                        .HasForeignKey("DeletedMemberId");

                    b.HasOne("FilmTavsiye.Models.DbModels.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilmTavsiye.Models.DbModels.ConstantValue", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilmTavsiye.Models.DbModels.Member", "UpdatedMember")
                        .WithMany()
                        .HasForeignKey("UpdatedMemberId");

                    b.Navigation("CreatedMember");

                    b.Navigation("DeletedMember");

                    b.Navigation("Member");

                    b.Navigation("Role");

                    b.Navigation("UpdatedMember");
                });

            modelBuilder.Entity("FilmTavsiye.Models.DbModels.Movie", b =>
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

            modelBuilder.Entity("FilmTavsiye.Models.DbModels.Notification", b =>
                {
                    b.HasOne("FilmTavsiye.Models.DbModels.Member", "CreatedMember")
                        .WithMany()
                        .HasForeignKey("CreatedMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilmTavsiye.Models.DbModels.Member", "DeletedMember")
                        .WithMany()
                        .HasForeignKey("DeletedMemberId");

                    b.HasOne("FilmTavsiye.Models.DbModels.ConstantValue", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.HasOne("FilmTavsiye.Models.DbModels.Member", "UpdatedMember")
                        .WithMany()
                        .HasForeignKey("UpdatedMemberId");

                    b.Navigation("CreatedMember");

                    b.Navigation("DeletedMember");

                    b.Navigation("Type");

                    b.Navigation("UpdatedMember");
                });
#pragma warning restore 612, 618
        }
    }
}
