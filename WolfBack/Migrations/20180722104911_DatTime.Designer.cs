﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace WolfBack.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180722104911_DatTime")]
    partial class DatTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.GameType", b =>
                {
                    b.Property<Guid>("GameTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GameName");

                    b.Property<int>("State");

                    b.HasKey("GameTypeId");

                    b.ToTable("GameTypes");
                });

            modelBuilder.Entity("Models.Player", b =>
                {
                    b.Property<Guid>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Status");

                    b.Property<string>("Username");

                    b.Property<string>("VKId");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Models.Score", b =>
                {
                    b.Property<Guid>("ScoreId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("GameTypeId");

                    b.Property<Guid>("PlayerId");

                    b.Property<int>("ScoreCount");

                    b.Property<DateTime>("Time");

                    b.HasKey("ScoreId");

                    b.HasIndex("GameTypeId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("Models.Score", b =>
                {
                    b.HasOne("Models.GameType", "GameType")
                        .WithMany("Scores")
                        .HasForeignKey("GameTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Models.Player", "PlayerName")
                        .WithMany("Scores")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
