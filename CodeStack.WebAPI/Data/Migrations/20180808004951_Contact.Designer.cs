﻿// <auto-generated />
using CodeStack.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeStack.WebAPI.Migrations
{
    [DbContext(typeof(CodeStackContext))]
    [Migration("20180808004951_Contact")]
    partial class Contact
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeStack.WebAPI.Data.Entities.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("VARCHAR(25)");

                    b.Property<string>("FirstName")
                        .HasColumnType("VARCHAR(25)");

                    b.Property<string>("LastName")
                        .HasColumnType("VARCHAR(25)");

                    b.Property<string>("Message")
                        .HasColumnType("VARCHAR(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("VARCHAR(25)");

                    b.HasKey("ContactID");

                    b.ToTable("Contact","Data");
                });
#pragma warning restore 612, 618
        }
    }
}
