﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Thaliak.Database;

#nullable disable

namespace Thaliak.Database.Migrations
{
    [DbContext(typeof(ThaliakContext))]
    [Migration("20220428060826_AddExpansionRepositoryMapping")]
    partial class AddExpansionRepositoryMapping
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Thaliak.Database.Models.DiscordHookEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DiscordHooks");
                });

            modelBuilder.Entity("Thaliak.Database.Models.XivAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Thaliak.Database.Models.XivExpansionRepositoryMapping", b =>
                {
                    b.Property<int>("GameRepositoryId")
                        .HasColumnType("integer");

                    b.Property<int>("ExpansionId")
                        .HasColumnType("integer");

                    b.Property<int>("ExpansionRepositoryId")
                        .HasColumnType("integer");

                    b.HasKey("GameRepositoryId", "ExpansionId", "ExpansionRepositoryId");

                    b.HasIndex("ExpansionRepositoryId");

                    b.ToTable("ExpansionRepositoryMappings");

                    b.HasData(
                        new
                        {
                            GameRepositoryId = 2,
                            ExpansionId = 0,
                            ExpansionRepositoryId = 2
                        },
                        new
                        {
                            GameRepositoryId = 2,
                            ExpansionId = 1,
                            ExpansionRepositoryId = 3
                        },
                        new
                        {
                            GameRepositoryId = 2,
                            ExpansionId = 2,
                            ExpansionRepositoryId = 4
                        },
                        new
                        {
                            GameRepositoryId = 2,
                            ExpansionId = 3,
                            ExpansionRepositoryId = 5
                        },
                        new
                        {
                            GameRepositoryId = 2,
                            ExpansionId = 4,
                            ExpansionRepositoryId = 6
                        });
                });

            modelBuilder.Entity("Thaliak.Database.Models.XivFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("MD5")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SHA1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SHA256")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<int>("VersionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("VersionId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Thaliak.Database.Models.XivPatch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("FirstSeen")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("HashBlockSize")
                        .HasColumnType("bigint");

                    b.Property<string>("HashType")
                        .HasColumnType("text");

                    b.Property<string>("Hashes")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastSeen")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RemoteOriginPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RepositoryId")
                        .HasColumnType("integer");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<int>("VersionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RepositoryId");

                    b.HasIndex("VersionId");

                    b.ToTable("Patches");
                });

            modelBuilder.Entity("Thaliak.Database.Models.XivRepository", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Slug");

                    b.ToTable("Repositories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "FFXIV Global/JP - Boot - Win32",
                            Name = "ffxivneo/win32/release/boot",
                            Slug = "2b5cbc63"
                        },
                        new
                        {
                            Id = 2,
                            Description = "FFXIV Global/JP - Retail - Base Game - Win32",
                            Name = "ffxivneo/win32/release/game",
                            Slug = "4e9a232b"
                        },
                        new
                        {
                            Id = 3,
                            Description = "FFXIV Global/JP - Retail - ex1 (Heavensward) - Win32",
                            Name = "ffxivneo/win32/release/ex1",
                            Slug = "6b936f08"
                        },
                        new
                        {
                            Id = 4,
                            Description = "FFXIV Global/JP - Retail - ex2 (Stormblood) - Win32",
                            Name = "ffxivneo/win32/release/ex2",
                            Slug = "f29a3eb2"
                        },
                        new
                        {
                            Id = 5,
                            Description = "FFXIV Global/JP - Retail - ex3 (Shadowbringers) - Win32",
                            Name = "ffxivneo/win32/release/ex3",
                            Slug = "859d0e24"
                        },
                        new
                        {
                            Id = 6,
                            Description = "FFXIV Global/JP - Retail - ex4 (Endwalker) - Win32",
                            Name = "ffxivneo/win32/release/ex4",
                            Slug = "1bf99b87"
                        });
                });

            modelBuilder.Entity("Thaliak.Database.Models.XivVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("RepositoryId")
                        .HasColumnType("integer");

                    b.Property<decimal>("VersionId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("VersionString")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RepositoryId");

                    b.HasIndex("VersionId");

                    b.HasIndex("VersionString");

                    b.ToTable("Versions");
                });

            modelBuilder.Entity("XivAccountXivRepository", b =>
                {
                    b.Property<int>("ApplicableAccountsId")
                        .HasColumnType("integer");

                    b.Property<int>("ApplicableRepositoriesId")
                        .HasColumnType("integer");

                    b.HasKey("ApplicableAccountsId", "ApplicableRepositoriesId");

                    b.HasIndex("ApplicableRepositoriesId");

                    b.ToTable("AccountRepositories", (string)null);
                });

            modelBuilder.Entity("Thaliak.Database.Models.XivExpansionRepositoryMapping", b =>
                {
                    b.HasOne("Thaliak.Database.Models.XivRepository", "ExpansionRepository")
                        .WithMany()
                        .HasForeignKey("ExpansionRepositoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Thaliak.Database.Models.XivRepository", "GameRepository")
                        .WithMany()
                        .HasForeignKey("GameRepositoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpansionRepository");

                    b.Navigation("GameRepository");
                });

            modelBuilder.Entity("Thaliak.Database.Models.XivFile", b =>
                {
                    b.HasOne("Thaliak.Database.Models.XivVersion", "Version")
                        .WithMany("Files")
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Version");
                });

            modelBuilder.Entity("Thaliak.Database.Models.XivPatch", b =>
                {
                    b.HasOne("Thaliak.Database.Models.XivRepository", "Repository")
                        .WithMany("Patches")
                        .HasForeignKey("RepositoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Thaliak.Database.Models.XivVersion", "Version")
                        .WithMany("Patches")
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Repository");

                    b.Navigation("Version");
                });

            modelBuilder.Entity("Thaliak.Database.Models.XivVersion", b =>
                {
                    b.HasOne("Thaliak.Database.Models.XivRepository", "Repository")
                        .WithMany("Versions")
                        .HasForeignKey("RepositoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Repository");
                });

            modelBuilder.Entity("XivAccountXivRepository", b =>
                {
                    b.HasOne("Thaliak.Database.Models.XivAccount", null)
                        .WithMany()
                        .HasForeignKey("ApplicableAccountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Thaliak.Database.Models.XivRepository", null)
                        .WithMany()
                        .HasForeignKey("ApplicableRepositoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Thaliak.Database.Models.XivRepository", b =>
                {
                    b.Navigation("Patches");

                    b.Navigation("Versions");
                });

            modelBuilder.Entity("Thaliak.Database.Models.XivVersion", b =>
                {
                    b.Navigation("Files");

                    b.Navigation("Patches");
                });
#pragma warning restore 612, 618
        }
    }
}
