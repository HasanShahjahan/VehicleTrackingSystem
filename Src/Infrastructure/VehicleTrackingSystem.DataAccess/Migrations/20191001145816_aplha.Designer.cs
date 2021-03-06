﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleTrackingSystem.DataAccess.DbContext;

namespace VehicleTrackingSystem.DataAccess.Migrations
{
    [DbContext(typeof(VehicleTrackingCommandsContext))]
    [Migration("20191001145816_aplha")]
    partial class aplha
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VehicleTrackingSystem.Entities.Device", b =>
                {
                    b.Property<int>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("ImeiNumber")
                        .HasMaxLength(16);

                    b.Property<string>("Name");

                    b.Property<bool>("Status");

                    b.HasKey("DeviceId");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Entities.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Altitude");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<double>("HorizontalAccuracy");

                    b.Property<double>("Latitude")
                        .HasMaxLength(500);

                    b.Property<double>("Longitude")
                        .HasMaxLength(500);

                    b.Property<double>("Speed");

                    b.Property<int>("VehicleId");

                    b.Property<double>("VerticalAccuracy");

                    b.HasKey("LocationId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.Property<int>("UserTypeId");

                    b.HasKey("UserId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "blackbee08@gmail.com",
                            MobileNumber = "0809201582",
                            Name = "Md Shahjahan Miah",
                            Password = "6jlpGIp6udJ6oiRYkphMlOf0WQW9l8gVPjFXjVhGKi/+nIiX",
                            UserName = "Miah",
                            UserTypeId = 1
                        },
                        new
                        {
                            UserId = 2,
                            Email = "shahjahan@2c2p.com",
                            MobileNumber = "0809201583",
                            Name = "Hasan Shahjahan",
                            Password = "6jlpGIp6udJ6oiRYkphMlOf0WQW9l8gVPjFXjVhGKi/+nIiX",
                            UserName = "Hasan",
                            UserTypeId = 2
                        });
                });

            modelBuilder.Entity("VehicleTrackingSystem.Entities.UserType", b =>
                {
                    b.Property<int>("UserTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.HasKey("UserTypeId");

                    b.ToTable("UserType");

                    b.HasData(
                        new
                        {
                            UserTypeId = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            UserTypeId = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("VehicleTrackingSystem.Entities.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyType")
                        .HasMaxLength(10);

                    b.Property<int>("DeviceId");

                    b.Property<string>("Maker")
                        .HasMaxLength(100);

                    b.Property<string>("Model")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int>("UserId");

                    b.Property<string>("Year")
                        .HasMaxLength(4);

                    b.HasKey("VehicleId");

                    b.HasIndex("DeviceId");

                    b.HasIndex("UserId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("VehicleTrackingSystem.Entities.Location", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Entities.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VehicleTrackingSystem.Entities.User", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Entities.UserType", "UserType")
                        .WithMany()
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VehicleTrackingSystem.Entities.Vehicle", b =>
                {
                    b.HasOne("VehicleTrackingSystem.Entities.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("VehicleTrackingSystem.Entities.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
