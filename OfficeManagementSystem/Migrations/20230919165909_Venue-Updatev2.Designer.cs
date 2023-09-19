﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OfficeManagementSystem.Data;

namespace OfficeManagementSystem.Migrations
{
    [DbContext(typeof(OMScontext))]
    [Migration("20230919165909_Venue-Updatev2")]
    partial class VenueUpdatev2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OfficeManagementSystem.Models.Attendees", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventsID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("EventsID");

                    b.ToTable("Attendees");
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.BudgetItems", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Decription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventsID")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EventsID");

                    b.ToTable("BudgetItems");
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.Contacts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.EventCategories", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("EventCategories");
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.Events", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EventCategoriesID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VenueID")
                        .HasColumnType("int");

                    b.Property<int?>("VenuesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EventCategoriesID");

                    b.HasIndex("VenuesID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.Messages", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceiverID")
                        .HasColumnType("int");

                    b.Property<int>("SenderID")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsersID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UsersID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.Resources", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventsID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EventsID");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.Tasks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventsID")
                        .HasColumnType("int");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EventsID");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Password")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.Venues", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("CompanyOwned")
                        .HasColumnType("bit");

                    b.Property<byte[]>("LayoutDiagram")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.Attendees", b =>
                {
                    b.HasOne("OfficeManagementSystem.Models.Events", "Events")
                        .WithMany("Attendees")
                        .HasForeignKey("EventsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.BudgetItems", b =>
                {
                    b.HasOne("OfficeManagementSystem.Models.Events", "Events")
                        .WithMany("BudgetItems")
                        .HasForeignKey("EventsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.Events", b =>
                {
                    b.HasOne("OfficeManagementSystem.Models.EventCategories", "EventCategories")
                        .WithMany()
                        .HasForeignKey("EventCategoriesID");

                    b.HasOne("OfficeManagementSystem.Models.Venues", "Venues")
                        .WithMany("Events")
                        .HasForeignKey("VenuesID");
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.Messages", b =>
                {
                    b.HasOne("OfficeManagementSystem.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersID");
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.Resources", b =>
                {
                    b.HasOne("OfficeManagementSystem.Models.Events", "Events")
                        .WithMany("Resources")
                        .HasForeignKey("EventsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OfficeManagementSystem.Models.Tasks", b =>
                {
                    b.HasOne("OfficeManagementSystem.Models.Events", "Events")
                        .WithMany("Tasks")
                        .HasForeignKey("EventsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
