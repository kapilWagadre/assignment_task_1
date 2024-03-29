﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using assignment_task_1.Models;

#nullable disable

namespace assignment_task_1.Migrations
{
    [DbContext(typeof(DataBaseConnect))]
    [Migration("20240102124627_taskass")]
    partial class taskass
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("assignment_task_1.Models.Earbudsview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Product_Image")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Product_Price")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("product_key")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Earbudses");
                });

            modelBuilder.Entity("assignment_task_1.Models.Fansview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Product_Image")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Product_Price")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("product_key")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Fanses");
                });

            modelBuilder.Entity("assignment_task_1.Models.LEDview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Product_Image")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Product_Price")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("product_key")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("LEDtv");
                });

            modelBuilder.Entity("assignment_task_1.Models.Laptopview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Product_Image")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Product_Price")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("product_key")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Laptops");
                });

            modelBuilder.Entity("assignment_task_1.Models.Phoneview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Product_Image")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Product_Price")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("product_key")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("assignment_task_1.Models.Sing_in", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("contact")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Singin");
                });

            modelBuilder.Entity("assignment_task_1.Models.Watchview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Product_Image")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Product_Price")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("product_key")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Watchs");
                });
#pragma warning restore 612, 618
        }
    }
}
