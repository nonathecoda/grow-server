﻿// <auto-generated />
using System;
using Grow.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Grow.Data.Migrations
{
    [DbContext(typeof(GrowDbContext))]
    partial class GrowDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Grow.Data.Entities.Account", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsEnabled");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Grow.Data.Entities.Contest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Language");

                    b.Property<string>("Name");

                    b.Property<string>("RegistrationUrl");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Year");

                    b.HasKey("Id");

                    b.HasIndex("Year");

                    b.ToTable("Contests");
                });

            modelBuilder.Entity("Grow.Data.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<DateTime>("End");

                    b.Property<string>("FacebookLink");

                    b.Property<bool>("HasTimesSet");

                    b.Property<int?>("HeldById");

                    b.Property<int?>("ImageId");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsMandatory");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Start");

                    b.Property<int>("Type");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("Visibility");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("HeldById");

                    b.HasIndex("ImageId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Grow.Data.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AltText");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Grow.Data.Entities.Judge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<int?>("ImageId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("JobTitle");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("ImageId");

                    b.ToTable("Judges");
                });

            modelBuilder.Entity("Grow.Data.Entities.Mentor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("Expertise");

                    b.Property<int?>("ImageId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("JobTitle");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("ImageId");

                    b.ToTable("Mentors");
                });

            modelBuilder.Entity("Grow.Data.Entities.Organizer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<int?>("ImageId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("JobTitle");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("ImageId");

                    b.ToTable("Organizers");
                });

            modelBuilder.Entity("Grow.Data.Entities.Partner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<int?>("ImageId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("ImageId");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("Grow.Data.Entities.Prize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<int?>("GivenById");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("Reward");

                    b.Property<int>("RewardValue");

                    b.Property<int>("Type");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int?>("WinnerId");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("GivenById");

                    b.HasIndex("WinnerId");

                    b.ToTable("Prizes");
                });

            modelBuilder.Entity("Grow.Data.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveSince");

                    b.Property<int>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("FacebookUrl");

                    b.Property<bool>("HasDroppedOut");

                    b.Property<string>("InstagramUrl");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("LogoImageId");

                    b.Property<string>("MembersAsString");

                    b.Property<string>("Name");

                    b.Property<string>("TagLine");

                    b.Property<int?>("TeamPhotoId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("LogoImageId");

                    b.HasIndex("TeamPhotoId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Grow.Data.Entities.Event", b =>
                {
                    b.HasOne("Grow.Data.Entities.Contest", "Contest")
                        .WithMany("Events")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Grow.Data.Entities.Partner", "HeldBy")
                        .WithMany()
                        .HasForeignKey("HeldById");

                    b.HasOne("Grow.Data.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Grow.Data.Entities.Judge", b =>
                {
                    b.HasOne("Grow.Data.Entities.Contest", "Contest")
                        .WithMany("Judges")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Grow.Data.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Grow.Data.Entities.Mentor", b =>
                {
                    b.HasOne("Grow.Data.Entities.Contest", "Contest")
                        .WithMany("Mentors")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Grow.Data.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Grow.Data.Entities.Organizer", b =>
                {
                    b.HasOne("Grow.Data.Entities.Contest", "Contest")
                        .WithMany("Organizers")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Grow.Data.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Grow.Data.Entities.Partner", b =>
                {
                    b.HasOne("Grow.Data.Entities.Contest", "Contest")
                        .WithMany("Partners")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Grow.Data.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Grow.Data.Entities.Prize", b =>
                {
                    b.HasOne("Grow.Data.Entities.Contest", "Contest")
                        .WithMany("Prizes")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Grow.Data.Entities.Partner", "GivenBy")
                        .WithMany()
                        .HasForeignKey("GivenById");

                    b.HasOne("Grow.Data.Entities.Team", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerId");
                });

            modelBuilder.Entity("Grow.Data.Entities.Team", b =>
                {
                    b.HasOne("Grow.Data.Entities.Contest", "Contest")
                        .WithMany("Teams")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Grow.Data.Entities.Image", "LogoImage")
                        .WithMany()
                        .HasForeignKey("LogoImageId");

                    b.HasOne("Grow.Data.Entities.Image", "TeamPhoto")
                        .WithMany()
                        .HasForeignKey("TeamPhotoId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Grow.Data.Entities.Account")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Grow.Data.Entities.Account")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Grow.Data.Entities.Account")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Grow.Data.Entities.Account")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
