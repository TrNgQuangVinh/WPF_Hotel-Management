﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Options;

namespace Assignment1.BusinessObj;

public partial class FuminiHotelManagementContext : DbContext
{
    public static string email;
    public static string pwd;
    public FuminiHotelManagementContext()
    {
        /*var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        IConfigurationRoot configurationRoot = builder.Build();
        string defaultEmail = configurationRoot.GetSection("DefaultAccount:Email").Value.ToString();
        string defaultPswd = configurationRoot.GetSection("DefaultAccount:Password").Value.ToString();
        email = defaultEmail;
        pwd = defaultPswd;*/
    }

    public FuminiHotelManagementContext(DbContextOptions<FuminiHotelManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookingDetail> BookingDetails { get; set; }

    public virtual DbSet<BookingReservation> BookingReservations { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<RoomInformation> RoomInformations { get; set; }

    public virtual DbSet<RoomType> RoomTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        IConfigurationRoot configurationRoot = builder.Build();
        optionsBuilder.UseSqlServer(configurationRoot.GetConnectionString("FUMiniHotelManagement"));
        string defaultEmail = configurationRoot.GetSection("DefaultAccount:Email").Value.ToString();
        string defaultPswd = configurationRoot.GetSection("DefaultAccount:Password").Value.ToString();
        optionsBuilder.EnableSensitiveDataLogging(true);
        email = defaultEmail;
        pwd = defaultPswd;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookingDetail>(entity =>
        {
            entity.HasKey(e => new { e.BookingReservationId, e.RoomId });

            entity.ToTable("BookingDetail");

            entity.Property(e => e.BookingReservationId).HasColumnName("BookingReservationID");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.ActualPrice).HasColumnType("money");

            entity.HasOne(d => d.BookingReservation).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.BookingReservationId)
                .HasConstraintName("FK_BookingDetail_BookingReservation");

            entity.HasOne(d => d.Room).WithMany(p => p.BookingDetails)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK_BookingDetail_RoomInformation");
        });

        modelBuilder.Entity<BookingReservation>(entity =>
        {
            entity.ToTable("BookingReservation");

            entity.Property(e => e.BookingReservationId)
                .ValueGeneratedNever()
                .HasColumnName("BookingReservationID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.TotalPrice).HasColumnType("money");

            entity.HasOne(d => d.Customer).WithMany(p => p.BookingReservations)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_BookingReservation_Customer");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.HasIndex(e => e.EmailAddress, "UQ__Customer__49A147402B3AE43E").IsUnique();

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerFullName).HasMaxLength(50);
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(12);
        });

        modelBuilder.Entity<RoomInformation>(entity =>
        {
            entity.HasKey(e => e.RoomId);

            entity.ToTable("RoomInformation");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.RoomDetailDescription).HasMaxLength(220);
            entity.Property(e => e.RoomNumber).HasMaxLength(50);
            entity.Property(e => e.RoomPricePerDay).HasColumnType("money");
            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");

            entity.HasOne(d => d.RoomType).WithMany(p => p.RoomInformations)
                .HasForeignKey(d => d.RoomTypeId)
                .HasConstraintName("FK_RoomInformation_RoomType");
        });

        modelBuilder.Entity<RoomType>(entity =>
        {
            entity.ToTable("RoomType");

            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");
            entity.Property(e => e.RoomTypeName).HasMaxLength(50);
            entity.Property(e => e.TypeDescription).HasMaxLength(250);
            entity.Property(e => e.TypeNote).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
