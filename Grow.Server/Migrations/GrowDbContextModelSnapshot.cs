﻿// <auto-generated />
using System;
using Grow.Server.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Grow.Server.Migrations
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

            modelBuilder.Entity("Grow.Server.Model.Entities.Account", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

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

            modelBuilder.Entity("Grow.Server.Model.Entities.Contest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("FinalEventId");

                    b.Property<int?>("KickoffEventId");

                    b.Property<string>("Language");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Year");

                    b.HasKey("Id");

                    b.HasIndex("FinalEventId");

                    b.HasIndex("KickoffEventId");

                    b.HasIndex("Year");

                    b.ToTable("Contests");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int?>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<DateTime>("End");

                    b.Property<string>("FacebookLink");

                    b.Property<bool>("HasTimesSet");

                    b.Property<int?>("HeldById");

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

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AltText");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Judge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<int?>("ImageId");

                    b.Property<string>("JobTitle");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("ImageId");

                    b.ToTable("Judges");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Mentor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("Expertise");

                    b.Property<int?>("ImageId");

                    b.Property<string>("JobTitle");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("ImageId");

                    b.ToTable("Mentors");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Organizer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<int?>("ImageId");

                    b.Property<string>("JobTitle");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("ImageId");

                    b.ToTable("Organizers");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Partner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<int?>("ImageId");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("ImageId");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Prize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<int?>("GivenById");

                    b.Property<bool>("IsPublic");

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

            modelBuilder.Entity("Grow.Server.Model.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveSince");

                    b.Property<int?>("ContestId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("FacebookUrl");

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

            modelBuilder.Entity("Grow.Server.Model.Entities.Contest", b =>
                {
                    b.HasOne("Grow.Server.Model.Entities.Event", "FinalEvent")
                        .WithMany()
                        .HasForeignKey("FinalEventId");

                    b.HasOne("Grow.Server.Model.Entities.Event", "KickoffEvent")
                        .WithMany()
                        .HasForeignKey("KickoffEventId");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Event", b =>
                {
                    b.HasOne("Grow.Server.Model.Entities.Contest", "Contest")
                        .WithMany("Events")
                        .HasForeignKey("ContestId");

                    b.HasOne("Grow.Server.Model.Entities.Partner", "HeldBy")
                        .WithMany()
                        .HasForeignKey("HeldById");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Judge", b =>
                {
                    b.HasOne("Grow.Server.Model.Entities.Contest", "Contest")
                        .WithMany("Judges")
                        .HasForeignKey("ContestId");

                    b.HasOne("Grow.Server.Model.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Mentor", b =>
                {
                    b.HasOne("Grow.Server.Model.Entities.Contest", "Contest")
                        .WithMany("Mentors")
                        .HasForeignKey("ContestId");

                    b.HasOne("Grow.Server.Model.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Organizer", b =>
                {
                    b.HasOne("Grow.Server.Model.Entities.Contest", "Contest")
                        .WithMany("Organizers")
                        .HasForeignKey("ContestId");

                    b.HasOne("Grow.Server.Model.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Partner", b =>
                {
                    b.HasOne("Grow.Server.Model.Entities.Contest", "Contest")
                        .WithMany("Partners")
                        .HasForeignKey("ContestId");

                    b.HasOne("Grow.Server.Model.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Prize", b =>
                {
                    b.HasOne("Grow.Server.Model.Entities.Contest", "Contest")
                        .WithMany("Prizes")
                        .HasForeignKey("ContestId");

                    b.HasOne("Grow.Server.Model.Entities.Partner", "GivenBy")
                        .WithMany()
                        .HasForeignKey("GivenById");

                    b.HasOne("Grow.Server.Model.Entities.Team", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerId");
                });

            modelBuilder.Entity("Grow.Server.Model.Entities.Team", b =>
                {
                    b.HasOne("Grow.Server.Model.Entities.Contest", "Contest")
                        .WithMany("Teams")
                        .HasForeignKey("ContestId");

                    b.HasOne("Grow.Server.Model.Entities.Image", "LogoImage")
                        .WithMany()
                        .HasForeignKey("LogoImageId");

                    b.HasOne("Grow.Server.Model.Entities.Image", "TeamPhoto")
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
                    b.HasOne("Grow.Server.Model.Entities.Account")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Grow.Server.Model.Entities.Account")
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

                    b.HasOne("Grow.Server.Model.Entities.Account")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Grow.Server.Model.Entities.Account")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
