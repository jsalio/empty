﻿// <auto-generated />
using System;
using Boundaries.Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Boundaries.Store.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230312000721_AddAttemptTables")]
    partial class AddAttemptTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Pdf")
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Core.Models.Attempts.Attempt", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("BatchId")
                        .HasColumnType("bigint");

                    b.Property<int>("CaseCaseStatus")
                        .HasColumnType("int");

                    b.Property<long>("DocumentHandler")
                        .HasColumnType("bigint");

                    b.Property<long>("DocumentType")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("LastUpDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("RegistryDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("DocumentHandler");

                    b.ToTable("Attempt");
                });

            modelBuilder.Entity("Core.Models.Attempts.AttemptDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<long>("AttemptId")
                        .HasColumnType("bigint");

                    b.Property<string>("ErrorDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("RegistryDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("AttemptId");

                    b.ToTable("AttemptDetail");
                });

            modelBuilder.Entity("Core.Models.Rule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("Core.Models.ServiceSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("EnableSecondQueue")
                        .HasColumnType("bit");

                    b.Property<int>("Interval")
                        .HasColumnType("int");

                    b.Property<string>("TimeEnd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeInit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TimeUnit")
                        .HasColumnType("int");

                    b.Property<int>("TimerWorkMode")
                        .HasColumnType("int");

                    b.Property<int>("WorkMode")
                        .HasColumnType("int");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ServiceSettings");
                });

            modelBuilder.Entity("Core.Models.Workflow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("ConvertToPdf")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Handle")
                        .HasColumnType("int");

                    b.Property<bool>("IsActiveQaIndex")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActiveQaScan")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMultipleIndexingActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workflows");
                });

            modelBuilder.Entity("Core.Models.Attempts.AttemptDetail", b =>
                {
                    b.HasOne("Core.Models.Attempts.Attempt", "Attempt")
                        .WithMany("AttemptDetails")
                        .HasForeignKey("AttemptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attempt");
                });

            modelBuilder.Entity("Core.Models.Attempts.Attempt", b =>
                {
                    b.Navigation("AttemptDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
