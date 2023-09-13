﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SubliminalServer;

#nullable disable

namespace SubliminalServer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.7.23375.4");

            modelBuilder.Entity("BlockedAccounts", b =>
                {
                    b.Property<int>("Blocked")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlockedBy")
                        .HasColumnType("INTEGER");

                    b.HasKey("Blocked", "BlockedBy");

                    b.HasIndex("BlockedBy");

                    b.ToTable("BlockedAccounts");
                });

            modelBuilder.Entity("FollowingAccounts", b =>
                {
                    b.Property<int>("Followed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FollowedBy")
                        .HasColumnType("INTEGER");

                    b.HasKey("Followed", "FollowedBy");

                    b.HasIndex("FollowedBy");

                    b.ToTable("FollowingAccounts");
                });

            modelBuilder.Entity("LikedPoems", b =>
                {
                    b.Property<int>("LikedPoem")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LikerAccount")
                        .HasColumnType("INTEGER");

                    b.HasKey("LikedPoem", "LikerAccount");

                    b.HasIndex("LikerAccount");

                    b.ToTable("LikedPoems");
                });

            modelBuilder.Entity("PinnedPoems", b =>
                {
                    b.Property<int>("PinnedPoem")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PinnerAccount")
                        .HasColumnType("INTEGER");

                    b.HasKey("PinnedPoem", "PinnerAccount");

                    b.HasIndex("PinnerAccount");

                    b.ToTable("PinnedPoems");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Account.AccountAddress", b =>
                {
                    b.Property<int>("AddressKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountKey")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AddressKey");

                    b.ToTable("AccountAddresses");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Account.AccountBadge", b =>
                {
                    b.Property<int>("BadgeKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Badge")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAwarded")
                        .HasColumnType("TEXT");

                    b.HasKey("BadgeKey");

                    b.HasIndex("AccountKey");

                    b.ToTable("AccountBadges");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Account.AccountData", b =>
                {
                    b.Property<int>("AccountKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Biography")
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("PenName")
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.HasKey("AccountKey");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Purgatory.PurgatoryAnnotation", b =>
                {
                    b.Property<int>("AnnotationKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Approves")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("End")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PoemKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Start")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Vetoes")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnnotationKey");

                    b.HasIndex("AccountKey");

                    b.HasIndex("PoemKey");

                    b.ToTable("PurgatoryAnnotations");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Purgatory.PurgatoryDraft", b =>
                {
                    b.Property<int>("DraftKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AmendsKey")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AuthorKey")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ContentWarning")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EditsKey")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PageBackgroundUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("PageStyle")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PoemContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PoemName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("Summary")
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.HasKey("DraftKey");

                    b.HasIndex("AmendsKey");

                    b.HasIndex("AuthorKey");

                    b.HasIndex("EditsKey");

                    b.ToTable("PurgatoryDrafts");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Purgatory.PurgatoryEntry", b =>
                {
                    b.Property<int>("EntryKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AmendsKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Approves")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AuthorKey")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ContentWarning")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EditsKey")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PageBackgroundUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("PageStyle")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Pick")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PoemContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PoemName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("Summary")
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<int>("Vetoes")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntryKey");

                    b.HasIndex("AmendsKey");

                    b.HasIndex("AuthorKey");

                    b.HasIndex("EditsKey");

                    b.ToTable("PurgatoryEntries");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Purgatory.PurgatoryTag", b =>
                {
                    b.Property<int>("TagKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EntryKey")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PurgatoryDraftDraftKey")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TagKey");

                    b.HasIndex("EntryKey");

                    b.HasIndex("PurgatoryDraftDraftKey");

                    b.ToTable("PurgatoryTags");
                });

            modelBuilder.Entity("BlockedAccounts", b =>
                {
                    b.HasOne("SubliminalServer.DataModel.Account.AccountData", null)
                        .WithMany()
                        .HasForeignKey("Blocked")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubliminalServer.DataModel.Account.AccountData", null)
                        .WithMany()
                        .HasForeignKey("BlockedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FollowingAccounts", b =>
                {
                    b.HasOne("SubliminalServer.DataModel.Account.AccountData", null)
                        .WithMany()
                        .HasForeignKey("Followed")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubliminalServer.DataModel.Account.AccountData", null)
                        .WithMany()
                        .HasForeignKey("FollowedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LikedPoems", b =>
                {
                    b.HasOne("SubliminalServer.DataModel.Purgatory.PurgatoryEntry", null)
                        .WithMany()
                        .HasForeignKey("LikedPoem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubliminalServer.DataModel.Account.AccountData", null)
                        .WithMany()
                        .HasForeignKey("LikerAccount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PinnedPoems", b =>
                {
                    b.HasOne("SubliminalServer.DataModel.Purgatory.PurgatoryEntry", null)
                        .WithMany()
                        .HasForeignKey("PinnedPoem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubliminalServer.DataModel.Account.AccountData", null)
                        .WithMany()
                        .HasForeignKey("PinnerAccount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Account.AccountAddress", b =>
                {
                    b.HasOne("SubliminalServer.DataModel.Account.AccountData", "Account")
                        .WithMany("KnownIPs")
                        .HasForeignKey("AddressKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Account.AccountBadge", b =>
                {
                    b.HasOne("SubliminalServer.DataModel.Account.AccountData", "Account")
                        .WithMany("Badges")
                        .HasForeignKey("AccountKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Purgatory.PurgatoryAnnotation", b =>
                {
                    b.HasOne("SubliminalServer.DataModel.Account.AccountData", "Account")
                        .WithMany()
                        .HasForeignKey("AccountKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubliminalServer.DataModel.Purgatory.PurgatoryEntry", "Poem")
                        .WithMany()
                        .HasForeignKey("PoemKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Poem");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Purgatory.PurgatoryDraft", b =>
                {
                    b.HasOne("SubliminalServer.DataModel.Purgatory.PurgatoryEntry", "Amends")
                        .WithMany()
                        .HasForeignKey("AmendsKey");

                    b.HasOne("SubliminalServer.DataModel.Account.AccountData", "Author")
                        .WithMany("Drafts")
                        .HasForeignKey("AuthorKey");

                    b.HasOne("SubliminalServer.DataModel.Purgatory.PurgatoryEntry", "Edits")
                        .WithMany()
                        .HasForeignKey("EditsKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amends");

                    b.Navigation("Author");

                    b.Navigation("Edits");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Purgatory.PurgatoryEntry", b =>
                {
                    b.HasOne("SubliminalServer.DataModel.Purgatory.PurgatoryEntry", "Amends")
                        .WithMany()
                        .HasForeignKey("AmendsKey");

                    b.HasOne("SubliminalServer.DataModel.Account.AccountData", "Author")
                        .WithMany("Poems")
                        .HasForeignKey("AuthorKey");

                    b.HasOne("SubliminalServer.DataModel.Purgatory.PurgatoryEntry", "Edits")
                        .WithMany()
                        .HasForeignKey("EditsKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amends");

                    b.Navigation("Author");

                    b.Navigation("Edits");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Purgatory.PurgatoryTag", b =>
                {
                    b.HasOne("SubliminalServer.DataModel.Purgatory.PurgatoryEntry", "PurgatoryEntry")
                        .WithMany("Tags")
                        .HasForeignKey("EntryKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SubliminalServer.DataModel.Purgatory.PurgatoryDraft", null)
                        .WithMany("Tags")
                        .HasForeignKey("PurgatoryDraftDraftKey");

                    b.Navigation("PurgatoryEntry");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Account.AccountData", b =>
                {
                    b.Navigation("Badges");

                    b.Navigation("Drafts");

                    b.Navigation("KnownIPs");

                    b.Navigation("Poems");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Purgatory.PurgatoryDraft", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("SubliminalServer.DataModel.Purgatory.PurgatoryEntry", b =>
                {
                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
