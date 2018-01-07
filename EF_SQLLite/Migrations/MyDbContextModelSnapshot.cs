﻿// <auto-generated />
using EF_SQLLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EF_SQLLite.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("App.Entities.Group", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Ordre");

                    b.Property<string>("Reference");

                    b.Property<string>("nombre");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("App.Entities.Trainee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateModification");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<long?>("GroupId");

                    b.Property<string>("LastName");

                    b.Property<int>("Ordre");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Reference");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("App.Entities.Trainee", b =>
                {
                    b.HasOne("App.Entities.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });
#pragma warning restore 612, 618
        }
    }
}
