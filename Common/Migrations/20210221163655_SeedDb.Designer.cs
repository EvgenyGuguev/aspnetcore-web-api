﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Common.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20210221163655_SeedDb")]
    partial class SeedDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Entities.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("CompanyId");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Address = "583 Wall Dr. Gwynn Oak, MD 21207",
                            Country = "USA",
                            Name = "IT_Solutions Ltd"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Address = "312 Forest Avenue, BF 923",
                            Country = "USA",
                            Name = "Admin_Solutions Ltd"
                        });
                });

            modelBuilder.Entity("Entities.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("EmployeeId");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("abaefe76-32c7-4c22-b9a2-2a1895208993"),
                            Age = 43,
                            CompanyId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Name = "Emanuel Crona",
                            Position = "Software developer"
                        },
                        new
                        {
                            Id = new Guid("a1db62c5-663b-45c6-a734-9a7659cf26a2"),
                            Age = 18,
                            CompanyId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Name = "Nathanial Haag",
                            Position = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("773e8aff-7831-43da-b90b-c7910934ae7b"),
                            Age = 34,
                            CompanyId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Name = "Tyson Hand",
                            Position = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("6f4e74aa-1c88-430b-95dc-3f32d43773d0"),
                            Age = 35,
                            CompanyId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Name = "Jon Reynolds",
                            Position = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("79832fc0-a1cb-494b-96ac-1aed6785d346"),
                            Age = 28,
                            CompanyId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Name = "Sim Smith",
                            Position = "Software developer"
                        },
                        new
                        {
                            Id = new Guid("63c1e54c-580a-4324-8dd4-e07bb912bd98"),
                            Age = 59,
                            CompanyId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Name = "Freeda Stracke",
                            Position = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("18e22b09-04ca-4164-a908-674dca01f648"),
                            Age = 46,
                            CompanyId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Name = "Robin Ryan",
                            Position = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("0b063015-ba57-43a8-956a-56ac7e4b7571"),
                            Age = 43,
                            CompanyId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Name = "Presley Pfeffer",
                            Position = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("5f9c6113-3ab8-496f-86ba-06341d03c128"),
                            Age = 54,
                            CompanyId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Name = "Stephan Kutch",
                            Position = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("2d7d7409-4caa-4eb5-ad11-8e71b7b543d3"),
                            Age = 39,
                            CompanyId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Name = "Jacynthe Cassin",
                            Position = "Administrator"
                        });
                });

            modelBuilder.Entity("Entities.Models.Employee", b =>
                {
                    b.HasOne("Entities.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Entities.Models.Company", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}