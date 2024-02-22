﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlatformPlatform.AccountManagement.Infrastructure;

#nullable disable

namespace PlatformPlatform.AccountManagement.Infrastructure.Migrations
{
    [DbContext(typeof(AccountManagementDbContext))]
    [Migration("20240221234207_AddAccountRegistrations")]
    partial class AddAccountRegistrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("PlatformPlatform.AccountManagement.Domain.AccountRegistrations.AccountRegistration", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(26)");

                    b.Property<DateTimeOffset?>("CompletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTimeOffset?>("ModifiedAt")
                        .IsConcurrencyToken()
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("OneTimePassword")
                        .HasColumnType("varchar(6)");

                    b.Property<DateTimeOffset>("ValidUntil")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("AccountRegistrations");
                });
#pragma warning restore 612, 618
        }
    }
}
