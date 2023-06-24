﻿// <auto-generated />
using System;
using FastSocietyWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FastSocietyWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220605222440_111")]
    partial class _111
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FastSocietyWeb.Models.AllocateHouse", b =>
                {
                    b.Property<string>("House_Number")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BirthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("House_Number");

                    b.ToTable("allocateHouses");
                });

            modelBuilder.Entity("FastSocietyWeb.Models.Annoucement", b =>
                {
                    b.Property<string>("Annouce")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Annouce");

                    b.ToTable("annoucements");
                });

            modelBuilder.Entity("FastSocietyWeb.Models.Complaint", b =>
                {
                    b.Property<int>("Complaint_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Complaint_ID"), 1L, 1);

                    b.Property<string>("Complaint_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Complaint_ID");

                    b.ToTable("complaints");
                });

            modelBuilder.Entity("FastSocietyWeb.Models.Employee", b =>
                {
                    b.Property<int>("Emp_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Emp_ID"), 1L, 1);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emp_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emp_Salary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emp_ID");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("FastSocietyWeb.Models.House", b =>
                {
                    b.Property<string>("houseNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Block")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("houseNo");

                    b.ToTable("houses");
                });

            modelBuilder.Entity("FastSocietyWeb.Models.Member", b =>
                {
                    b.Property<int>("Member_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Member_ID"), 1L, 1);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Member_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Member_ID");

                    b.ToTable("customers");
                });
#pragma warning restore 612, 618
        }
    }
}
