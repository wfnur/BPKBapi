﻿// <auto-generated />
using System;
using BPKBapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BPKBapi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BPKBapi.Models.BPKB", b =>
                {
                    b.Property<string>("AgreementNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BpkbDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BpkbDateIn")
                        .HasColumnType("datetime2");

                    b.Property<string>("BpkbNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FakturDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FakturNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("LocationID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PoliceNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AgreementNumber");

                    b.ToTable("tr_bpkb");
                });

            modelBuilder.Entity("BPKBapi.Models.StorageLocation", b =>
                {
                    b.Property<string>("LocationID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationID");

                    b.ToTable("ms_storage_locations");
                });

            modelBuilder.Entity("BPKBapi.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<bool>("Isactive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("ms_user");
                });
#pragma warning restore 612, 618
        }
    }
}
