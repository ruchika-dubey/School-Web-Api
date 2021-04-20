﻿// <auto-generated />
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210420174120_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.MarksModel", b =>
                {
                    b.Property<string>("MarksID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Marks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarksID");

                    b.ToTable("MarksModel");
                });

            modelBuilder.Entity("Models.StudentModel", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StudentGrade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("StudentModel");
                });

            modelBuilder.Entity("Models.SubjectModel", b =>
                {
                    b.Property<string>("SubjectID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectID");

                    b.ToTable("SubjectModel");
                });
#pragma warning restore 612, 618
        }
    }
}