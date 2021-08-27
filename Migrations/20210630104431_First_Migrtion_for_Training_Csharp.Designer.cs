﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base;

namespace Training_Csharp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210630104431_First_Migrtion_for_Training_Csharp")]
    partial class First_Migrtion_for_Training_Csharp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base.Modul_Struct_Base", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateCreate1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateCreate2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateCreate3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateCreate4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateCreate5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateCreate6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateExamples1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateExamples2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateExamples3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateExamples4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateExamples5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateExamples6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameCreate1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameCreate2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameCreate3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameCreate4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameCreate5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameExamples1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameExamples2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameExamples3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameExamples4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameExamples5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameInfo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameTasks3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationCreate1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationCreate2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationCreate3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationCreate4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationCreate5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationExamples1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationExamples2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationExamples3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationExamples4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationExamples5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationExamples6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationExamples7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationInfo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationTasks1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationTasks2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationTasks3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationTasks4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationTasks5")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Modul_Struct_Bases");
                });
#pragma warning restore 612, 618
        }
    }
}
