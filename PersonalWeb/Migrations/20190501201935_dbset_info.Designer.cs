﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalWeb.Data;

namespace PersonalWeb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190501201935_dbset_info")]
    partial class dbset_info
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("PersonalWeb.Models.Entities.Edu", b =>
                {
                    b.Property<int>("EduId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Degree");

                    b.Property<int>("FromDay");

                    b.Property<int>("FromMonth");

                    b.Property<int>("FromYear");

                    b.Property<string>("Major");

                    b.Property<string>("ReleventCourses");

                    b.Property<string>("SchoolName");

                    b.Property<int?>("ToDay");

                    b.Property<int?>("ToMonth");

                    b.Property<int?>("ToYear");

                    b.Property<int>("UserId");

                    b.HasKey("EduId");

                    b.ToTable("edus");
                });

            modelBuilder.Entity("PersonalWeb.Models.Entities.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("FromDay");

                    b.Property<int>("FromMonth");

                    b.Property<int>("FromYear");

                    b.Property<string>("Location");

                    b.Property<string>("Position");

                    b.Property<string>("ProjectName");

                    b.Property<int?>("ToDay");

                    b.Property<int?>("ToMonth");

                    b.Property<int?>("ToYear");

                    b.Property<int>("UserId");

                    b.HasKey("ProjectId");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("PersonalWeb.Models.Entities.UserInfo", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("Age");

                    b.Property<int>("DayOfBirth");

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("Gender");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<int>("MonthOfBirth");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("UserFirstName")
                        .IsRequired();

                    b.Property<string>("UserLastName")
                        .IsRequired();

                    b.Property<int>("YearOfBirth");

                    b.HasKey("UserId");

                    b.ToTable("userInfos");
                });

            modelBuilder.Entity("PersonalWeb.Models.Entities.Work", b =>
                {
                    b.Property<int>("WorkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName");

                    b.Property<int>("FromDay");

                    b.Property<int>("FromMonth");

                    b.Property<int>("FromYear");

                    b.Property<string>("Location");

                    b.Property<string>("Position");

                    b.Property<string>("Responsibility");

                    b.Property<int?>("ToDay");

                    b.Property<int?>("ToMonth");

                    b.Property<int?>("ToYear");

                    b.Property<int>("UserId");

                    b.HasKey("WorkId");

                    b.ToTable("works");
                });
#pragma warning restore 612, 618
        }
    }
}
