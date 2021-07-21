﻿// <auto-generated />
using System;
using Ernest.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ernest.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Ernest.Api.Models.Db.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventTag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("EventTags");
                });

            modelBuilder.Entity("EventEventTag", b =>
                {
                    b.Property<int>("EventTagsID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventsID")
                        .HasColumnType("INTEGER");

                    b.HasKey("EventTagsID", "EventsID");

                    b.HasIndex("EventsID");

                    b.ToTable("EventEventTag");
                });

            modelBuilder.Entity("EventEventTag", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.EventTag", null)
                        .WithMany()
                        .HasForeignKey("EventTagsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ernest.Api.Models.Db.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
