﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using basketballStatsApi.Models;

#nullable disable

namespace basketballStatsApi.Migrations
{
    [DbContext(typeof(PlayerContext))]
    [Migration("20240307195025_AddGameSet")]
    partial class AddGameSet
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("basketballStatsApi.Models.GameSet", b =>
                {
                    b.Property<int>("GameSetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameSetID"));

                    b.Property<string>("Assists")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerID")
                        .HasColumnType("int");

                    b.Property<string>("Points")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rebounds")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameSetID");

                    b.HasIndex("PlayerID");

                    b.ToTable("GameSets");
                });

            modelBuilder.Entity("basketballStatsApi.Models.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("basketballStatsApi.Models.GameSet", b =>
                {
                    b.HasOne("basketballStatsApi.Models.Player", null)
                        .WithMany("GameLog")
                        .HasForeignKey("PlayerID");
                });

            modelBuilder.Entity("basketballStatsApi.Models.Player", b =>
                {
                    b.Navigation("GameLog");
                });
#pragma warning restore 612, 618
        }
    }
}
