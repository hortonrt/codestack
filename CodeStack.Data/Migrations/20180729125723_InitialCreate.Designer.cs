﻿// <auto-generated />
using CodeStack.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeStack.Data.Migrations {
    [DbContext(typeof(CodeStackContext))]
    [Migration("20180729125723_InitialCreate")]
    partial class InitialCreate {
        protected override void BuildTargetModel(ModelBuilder modelBuilder) {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("codestack.Models.Navigation.NavRoute", b => {
                b.Property<int>("NavRouteID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Details");

                b.Property<string>("Name");

                b.Property<string>("Routerlink");

                b.HasKey("NavRouteID");

                b.ToTable("NavRoute");
            });
#pragma warning restore 612, 618
        }
    }
}