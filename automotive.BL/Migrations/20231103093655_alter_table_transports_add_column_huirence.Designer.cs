﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using automotive.BL.Contexts;

#nullable disable

namespace automotive.BL.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20231103093655_alter_table_transports_add_column_huirence")]
    partial class alter_table_transports_add_column_huirence
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("automotive.BL.Models.Body.Body", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Material")
                        .HasColumnType("TEXT");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Body");
                });

            modelBuilder.Entity("automotive.BL.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BodyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChassisId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Clearance")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EngineId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Huirence")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mileage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Model")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Position")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BodyId");

                    b.HasIndex("ChassisId");

                    b.HasIndex("EngineId");

                    b.ToTable("Transports");
                });

            modelBuilder.Entity("automotive.BL.Models.Chassis.Chassis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Material")
                        .HasColumnType("TEXT");

                    b.Property<int>("WheelCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WheelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WheelId");

                    b.ToTable("Chassis");
                });

            modelBuilder.Entity("automotive.BL.Models.Chassis.Wheel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Diameter")
                        .HasColumnType("REAL");

                    b.Property<string>("Material")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Wheel");
                });

            modelBuilder.Entity("automotive.BL.Models.Engine.Engine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Capacity")
                        .HasColumnType("REAL");

                    b.Property<int>("CilindersCount")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Consumption")
                        .HasColumnType("REAL");

                    b.Property<string>("Fuel")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .HasColumnType("TEXT");

                    b.Property<double>("Power")
                        .HasColumnType("REAL");

                    b.Property<int>("StateId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Engine");
                });

            modelBuilder.Entity("automotive.BL.Models.Engine.EngineState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AntiFreezeLevel")
                        .HasColumnType("REAL");

                    b.Property<double>("BrakeFluidLevel")
                        .HasColumnType("REAL");

                    b.Property<double>("FuelLevel")
                        .HasColumnType("REAL");

                    b.Property<bool>("IsStarted")
                        .HasColumnType("INTEGER");

                    b.Property<double>("OilLevel")
                        .HasColumnType("REAL");

                    b.Property<double>("PowerLevel")
                        .HasColumnType("REAL");

                    b.Property<double>("TransmissionOilLevel")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("EngineState");
                });

            modelBuilder.Entity("automotive.BL.Models.Car", b =>
                {
                    b.HasOne("automotive.BL.Models.Body.Body", "Body")
                        .WithMany()
                        .HasForeignKey("BodyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("automotive.BL.Models.Chassis.Chassis", "Chassis")
                        .WithMany()
                        .HasForeignKey("ChassisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("automotive.BL.Models.Engine.Engine", "Engine")
                        .WithMany()
                        .HasForeignKey("EngineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Body");

                    b.Navigation("Chassis");

                    b.Navigation("Engine");
                });

            modelBuilder.Entity("automotive.BL.Models.Chassis.Chassis", b =>
                {
                    b.HasOne("automotive.BL.Models.Chassis.Wheel", "Wheel")
                        .WithMany()
                        .HasForeignKey("WheelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wheel");
                });

            modelBuilder.Entity("automotive.BL.Models.Engine.Engine", b =>
                {
                    b.HasOne("automotive.BL.Models.Engine.EngineState", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });
#pragma warning restore 612, 618
        }
    }
}
