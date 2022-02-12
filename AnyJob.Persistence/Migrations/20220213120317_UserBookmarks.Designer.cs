﻿// <auto-generated />
using System;
using AnyJob.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnyJob.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220213120317_UserBookmarks")]
    partial class UserBookmarks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AnyJob.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("AnyJob.Domain.EmploymentType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmploymentTypes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Full Time"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Part Time"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Contractor"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Intern"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Seasonal / Temp"
                        });
                });

            modelBuilder.Entity("AnyJob.Domain.JobPosting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("EmploymentTypeId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EmploymentTypeId");

                    b.HasIndex("LocationId");

                    b.ToTable("JobPostings", (string)null);
                });

            modelBuilder.Entity("AnyJob.Domain.JobPostingBookmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("JobPostingId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobPostingId");

                    b.HasIndex("UserId");

                    b.ToTable("JobPostingBookmarks", (string)null);
                });

            modelBuilder.Entity("AnyJob.Domain.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations", (string)null);
                });

            modelBuilder.Entity("AnyJob.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("AnonymousId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("AnyJob.Domain.JobPosting", b =>
                {
                    b.HasOne("AnyJob.Domain.Category", "Category")
                        .WithMany("JobPostings")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AnyJob.Domain.EmploymentType", "EmploymentType")
                        .WithMany("JobPostings")
                        .HasForeignKey("EmploymentTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AnyJob.Domain.Location", "Location")
                        .WithMany("JobPostings")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("EmploymentType");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("AnyJob.Domain.JobPostingBookmark", b =>
                {
                    b.HasOne("AnyJob.Domain.JobPosting", "JobPosting")
                        .WithMany("Bookmarks")
                        .HasForeignKey("JobPostingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnyJob.Domain.User", "User")
                        .WithMany("Bookmarks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobPosting");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AnyJob.Domain.Category", b =>
                {
                    b.Navigation("JobPostings");
                });

            modelBuilder.Entity("AnyJob.Domain.EmploymentType", b =>
                {
                    b.Navigation("JobPostings");
                });

            modelBuilder.Entity("AnyJob.Domain.JobPosting", b =>
                {
                    b.Navigation("Bookmarks");
                });

            modelBuilder.Entity("AnyJob.Domain.Location", b =>
                {
                    b.Navigation("JobPostings");
                });

            modelBuilder.Entity("AnyJob.Domain.User", b =>
                {
                    b.Navigation("Bookmarks");
                });
#pragma warning restore 612, 618
        }
    }
}
