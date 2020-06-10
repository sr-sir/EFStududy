﻿// <auto-generated />
using EFStudy.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFStudy.Migrations
{
    [DbContext(typeof(MysqlDbContext))]
    [Migration("20200610030459_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EFStudy.Models.address", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("area")
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .HasColumnType("text");

                    b.Property<string>("province")
                        .HasColumnType("text");

                    b.Property<string>("stree")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("addresses");
                });
#pragma warning restore 612, 618
        }
    }
}