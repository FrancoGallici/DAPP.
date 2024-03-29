﻿// <auto-generated />
using DB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DB.Migrations
{
    [DbContext(typeof(DAPPContext))]
    [Migration("20190925145435_initialdb2")]
    partial class initialdb2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DB.Data.Entities.Spells", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Casting_Time")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<string>("Components")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<string>("Duration")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<int>("Level")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Range")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<string>("School")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Spells");
                });
#pragma warning restore 612, 618
        }
    }
}
