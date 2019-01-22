﻿// <auto-generated />
using System;
using EfSamurai;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfSamurai.Migrations
{
    [DbContext(typeof(SamuraiContext))]
    [Migration("20180911081343_haha")]
    partial class haha
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfSamurai.Quote", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ownerid");

                    b.Property<int>("sort");

                    b.Property<string>("text");

                    b.HasKey("id");

                    b.HasIndex("ownerid");

                    b.ToTable("Quote");
                });

            modelBuilder.Entity("EfSamurai.Samurai", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("haircut");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("EfSamurai.Quote", b =>
                {
                    b.HasOne("EfSamurai.Samurai", "owner")
                        .WithMany("quoteList")
                        .HasForeignKey("ownerid");
                });
#pragma warning restore 612, 618
        }
    }
}