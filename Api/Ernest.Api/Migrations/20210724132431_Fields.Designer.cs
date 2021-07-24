﻿// <auto-generated />
using System;
using Ernest.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ernest.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210724132431_Fields")]
    partial class Fields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Ernest.Api.Models.Db.EventBooleanField", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Boolean")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EventID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastEditedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("EventID");

                    b.ToTable("EventBooleanFields");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventDecimalField", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Decimal")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EventID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastEditedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("EventID");

                    b.ToTable("EventDecimalFields");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventIntegerField", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EventID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Integer")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastEditedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("EventID");

                    b.ToTable("EventIntegerFields");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventStringField", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EventID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastEditedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("String")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("EventID");

                    b.ToTable("EventStringFields");
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

            modelBuilder.Entity("Ernest.Api.Models.Db.EventBooleanField", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.Event", "Event")
                        .WithMany("BooleanFields")
                        .HasForeignKey("EventID");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventDecimalField", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.Event", "Event")
                        .WithMany("DecimalFields")
                        .HasForeignKey("EventID");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventIntegerField", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.Event", "Event")
                        .WithMany("IntegerFields")
                        .HasForeignKey("EventID");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventStringField", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.Event", "Event")
                        .WithMany("StringFields")
                        .HasForeignKey("EventID");

                    b.Navigation("Event");
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

            modelBuilder.Entity("Ernest.Api.Models.Db.Event", b =>
                {
                    b.Navigation("BooleanFields");

                    b.Navigation("DecimalFields");

                    b.Navigation("IntegerFields");

                    b.Navigation("StringFields");
                });
#pragma warning restore 612, 618
        }
    }
}
