﻿// <auto-generated />
using System;
using CodeAlongDBquick;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeAlongDBquick.Migrations
{
    [DbContext(typeof(FruitContext))]
    [Migration("20180910124158_Fruitcategories")]
    partial class Fruitcategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeAlongDBquick.Fruit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BosseId");

                    b.Property<string>("Colour");

                    b.Property<string>("Name");

                    b.Property<decimal?>("Price");

                    b.HasKey("Id");

                    b.HasIndex("BosseId");

                    b.ToTable("Fruits");
                });

            modelBuilder.Entity("CodeAlongDBquick.FruitCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("FruitCategories");
                });

            modelBuilder.Entity("CodeAlongDBquick.Fruit", b =>
                {
                    b.HasOne("CodeAlongDBquick.FruitCategories", "Bosse")
                        .WithMany("FruitList")
                        .HasForeignKey("BosseId");
                });
#pragma warning restore 612, 618
        }
    }
}
