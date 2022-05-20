﻿// <auto-generated />
using System;
using Domain.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(DigitalSpaceDbContext))]
    partial class DigitalSpaceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Document")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolID")
                        .HasColumnType("int");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("PersonID");

                    b.HasIndex("RolID");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            PersonID = 1,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "303379521",
                            Name = "Keith Watsica",
                            RolID = 2,
                            Telephone = "1-637-888-3606"
                        },
                        new
                        {
                            PersonID = 2,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "528960794",
                            Name = "Spencer Will",
                            RolID = 1,
                            Telephone = "1-676-316-8667"
                        },
                        new
                        {
                            PersonID = 3,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "720016250",
                            Name = "Annie Connelly",
                            RolID = 2,
                            Telephone = "1-760-234-2738 x098"
                        },
                        new
                        {
                            PersonID = 4,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "774549390",
                            Name = "Bradford Russel",
                            RolID = 3,
                            Telephone = "1-824-279-3344 x3846"
                        },
                        new
                        {
                            PersonID = 5,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "857636783",
                            Name = "Perry Cassin",
                            RolID = 1,
                            Telephone = "578-433-9242"
                        },
                        new
                        {
                            PersonID = 6,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "514187084",
                            Name = "Edith Littel",
                            RolID = 2,
                            Telephone = "(284) 264-4756 x242"
                        },
                        new
                        {
                            PersonID = 7,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "467016540",
                            Name = "Ronnie Barrows",
                            RolID = 2,
                            Telephone = "1-242-502-6670 x6954"
                        },
                        new
                        {
                            PersonID = 8,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "598954724",
                            Name = "Jackie Sporer",
                            RolID = 3,
                            Telephone = "(357) 957-1607 x17071"
                        },
                        new
                        {
                            PersonID = 9,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "161805592",
                            Name = "Noah Stanton",
                            RolID = 3,
                            Telephone = "467.506.4093 x8986"
                        },
                        new
                        {
                            PersonID = 10,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "126692134",
                            Name = "Edmond Mohr",
                            RolID = 3,
                            Telephone = "(580) 761-6883 x5221"
                        },
                        new
                        {
                            PersonID = 11,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "271485975",
                            Name = "John Reichel",
                            RolID = 2,
                            Telephone = "676-833-2377"
                        },
                        new
                        {
                            PersonID = 12,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "268520322",
                            Name = "Sadie Conroy",
                            RolID = 2,
                            Telephone = "(923) 792-2488 x636"
                        },
                        new
                        {
                            PersonID = 13,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "200967478",
                            Name = "Clifford Gerhold",
                            RolID = 2,
                            Telephone = "1-279-478-1425 x828"
                        },
                        new
                        {
                            PersonID = 14,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "786509210",
                            Name = "Nicole Fay",
                            RolID = 2,
                            Telephone = "1-761-987-9137 x882"
                        },
                        new
                        {
                            PersonID = 15,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894),
                            CreatedBy = "Juan Leon",
                            Document = "724509940",
                            Name = "Theodore MacGyver",
                            RolID = 2,
                            Telephone = "1-670-696-5153 x351"
                        });
                });

            modelBuilder.Entity("Domain.Models.Rol", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RolID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("RolID");

                    b.ToTable("Rol");

                    b.HasData(
                        new
                        {
                            RolID = 1,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 109, DateTimeKind.Local).AddTicks(5697),
                            CreatedBy = "Juan Leon",
                            Name = "Administrador"
                        },
                        new
                        {
                            RolID = 2,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 110, DateTimeKind.Local).AddTicks(2821),
                            CreatedBy = "Juan Leon",
                            Name = "Cliente"
                        },
                        new
                        {
                            RolID = 3,
                            CreatedAt = new DateTime(2022, 5, 19, 22, 15, 47, 110, DateTimeKind.Local).AddTicks(2834),
                            CreatedBy = "Juan Leon",
                            Name = "Vendedor"
                        });
                });

            modelBuilder.Entity("Domain.Models.Person", b =>
                {
                    b.HasOne("Domain.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });
#pragma warning restore 612, 618
        }
    }
}
