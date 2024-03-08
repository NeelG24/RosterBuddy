﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using basketballStatsApi.Models;

#nullable disable

namespace basketballStatsApi.Migrations
{
    [DbContext(typeof(PlayerContext))]
    partial class PlayerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Blk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dreb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FGA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreeThrow")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreeThrowAttempt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MinutesPlayed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oreb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalFouls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerID")
                        .HasColumnType("int");

                    b.Property<string>("Points")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rebounds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThreePoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThreePointAttempt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tov")
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
