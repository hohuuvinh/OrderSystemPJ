﻿// <auto-generated />
using System;
using Hello.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hello.Data.Migrations
{
    [DbContext(typeof(HelloDbContext))]
    partial class HelloDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hello.Data.Entities.tbl_bill", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("create_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("idorder")
                        .HasColumnType("int");

                    b.Property<int>("idpayment")
                        .HasColumnType("int");

                    b.Property<int>("iduser")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_bill");
                });

            modelBuilder.Entity("Hello.Data.Entities.tbl_item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("discount")
                        .HasColumnType("real");

                    b.Property<int>("idorder")
                        .HasColumnType("int");

                    b.Property<int>("idproduct")
                        .HasColumnType("int");

                    b.Property<float?>("price")
                        .HasColumnType("real");

                    b.Property<int>("quanlity")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_item");
                });

            modelBuilder.Entity("Hello.Data.Entities.tbl_order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("discount")
                        .HasColumnType("real");

                    b.Property<float>("fee")
                        .HasColumnType("real");

                    b.Property<float>("total")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("tbl_order");
                });

            modelBuilder.Entity("Hello.Data.Entities.tbl_payment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idorder")
                        .HasColumnType("int");

                    b.Property<float>("receive")
                        .HasColumnType("real");

                    b.Property<float>("refund")
                        .HasColumnType("real");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_payment");
                });

            modelBuilder.Entity("Hello.Data.Entities.tbl_product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("category")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("tbl_product");
                });
#pragma warning restore 612, 618
        }
    }
}
