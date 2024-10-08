﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tunify_Platform.Data;

#nullable disable

namespace Tunify_Platform.Migrations
{
    [DbContext(typeof(TunifyDBContext))]
    [Migration("20240816132959_iniit2")]
    partial class iniit2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tunify_Platform.Album", b =>
                {
                    b.Property<int>("AlbumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumID"));

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ArtistID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AlbumID");

                    b.HasIndex("ArtistID");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            AlbumID = 1,
                            AlbumName = "Album 1",
                            ArtistID = 1,
                            ReleaseDate = new DateTime(2024, 8, 16, 16, 29, 59, 2, DateTimeKind.Local).AddTicks(6933)
                        });
                });

            modelBuilder.Entity("Tunify_Platform.Artist", b =>
                {
                    b.Property<int>("ArtistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistID"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistID");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistID = 1,
                            Bio = "Bio of Artist 1",
                            Name = "Artist 1"
                        });
                });

            modelBuilder.Entity("Tunify_Platform.Playlist", b =>
                {
                    b.Property<int>("PlaylistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaylistID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PlaylistName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("PlaylistID");

                    b.HasIndex("UserID");

                    b.ToTable("Playlists");

                    b.HasData(
                        new
                        {
                            PlaylistID = 1,
                            CreatedDate = new DateTime(2024, 8, 16, 16, 29, 59, 2, DateTimeKind.Local).AddTicks(6947),
                            PlaylistName = "Playlist 1",
                            UserID = 1
                        },
                        new
                        {
                            PlaylistID = 2,
                            CreatedDate = new DateTime(2024, 8, 16, 16, 29, 59, 2, DateTimeKind.Local).AddTicks(6949),
                            PlaylistName = "Playlist 2",
                            UserID = 2
                        });
                });

            modelBuilder.Entity("Tunify_Platform.PlaylistSong", b =>
                {
                    b.Property<int>("PlaylistSongID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaylistSongID"));

                    b.Property<int>("PlaylistID")
                        .HasColumnType("int");

                    b.Property<int>("SongID")
                        .HasColumnType("int");

                    b.HasKey("PlaylistSongID");

                    b.HasIndex("PlaylistID");

                    b.HasIndex("SongID");

                    b.ToTable("PlaylistSongs");

                    b.HasData(
                        new
                        {
                            PlaylistSongID = 1,
                            PlaylistID = 1,
                            SongID = 1
                        },
                        new
                        {
                            PlaylistSongID = 2,
                            PlaylistID = 1,
                            SongID = 2
                        },
                        new
                        {
                            PlaylistSongID = 3,
                            PlaylistID = 2,
                            SongID = 1
                        });
                });

            modelBuilder.Entity("Tunify_Platform.Song", b =>
                {
                    b.Property<int>("SongID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongID"));

                    b.Property<int>("AlbumID")
                        .HasColumnType("int");

                    b.Property<int>("ArtistID")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongID");

                    b.HasIndex("AlbumID");

                    b.HasIndex("ArtistID");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongID = 1,
                            AlbumID = 1,
                            ArtistID = 1,
                            Duration = new TimeSpan(0, 0, 3, 45, 0),
                            Genre = "Pop",
                            Title = "Song 1"
                        },
                        new
                        {
                            SongID = 2,
                            AlbumID = 1,
                            ArtistID = 1,
                            Duration = new TimeSpan(0, 0, 4, 20, 0),
                            Genre = "Rock",
                            Title = "Song 2"
                        });
                });

            modelBuilder.Entity("Tunify_Platform.Subscription", b =>
                {
                    b.Property<int>("SubscriptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionID"));

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SubscriptionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubscriptionID");

                    b.ToTable("Subscriptions");

                    b.HasData(
                        new
                        {
                            SubscriptionID = 1,
                            Price = 9.99m,
                            SubscriptionType = "Basic"
                        },
                        new
                        {
                            SubscriptionID = 2,
                            Price = 19.99m,
                            SubscriptionType = "Premium"
                        });
                });

            modelBuilder.Entity("Tunify_Platform.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubscriptionID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("SubscriptionID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Email = "user1@example.com",
                            JoinDate = new DateTime(2024, 8, 16, 16, 29, 59, 2, DateTimeKind.Local).AddTicks(6710),
                            SubscriptionID = 1,
                            Username = "user1"
                        },
                        new
                        {
                            UserID = 2,
                            Email = "user2@example.com",
                            JoinDate = new DateTime(2024, 8, 16, 16, 29, 59, 2, DateTimeKind.Local).AddTicks(6723),
                            SubscriptionID = 1,
                            Username = "user2"
                        });
                });

            modelBuilder.Entity("Tunify_Platform.Album", b =>
                {
                    b.HasOne("Tunify_Platform.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("Tunify_Platform.Playlist", b =>
                {
                    b.HasOne("Tunify_Platform.User", "User")
                        .WithMany("Playlists")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Tunify_Platform.PlaylistSong", b =>
                {
                    b.HasOne("Tunify_Platform.Playlist", "Playlists")
                        .WithMany("PlaylistSongs")
                        .HasForeignKey("PlaylistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tunify_Platform.Song", "Songs")
                        .WithMany("PlaylistSongs")
                        .HasForeignKey("SongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Playlists");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Tunify_Platform.Song", b =>
                {
                    b.HasOne("Tunify_Platform.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Tunify_Platform.Artist", "Artist")
                        .WithMany("Songs")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("Tunify_Platform.User", b =>
                {
                    b.HasOne("Tunify_Platform.Subscription", "Subscription")
                        .WithMany("Users")
                        .HasForeignKey("SubscriptionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("Tunify_Platform.Album", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Tunify_Platform.Artist", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Tunify_Platform.Playlist", b =>
                {
                    b.Navigation("PlaylistSongs");
                });

            modelBuilder.Entity("Tunify_Platform.Song", b =>
                {
                    b.Navigation("PlaylistSongs");
                });

            modelBuilder.Entity("Tunify_Platform.Subscription", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Tunify_Platform.User", b =>
                {
                    b.Navigation("Playlists");
                });
#pragma warning restore 612, 618
        }
    }
}
