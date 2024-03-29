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
    [Migration("20210724140719_EventFieldTemplatesRemoveDates")]
    partial class EventFieldTemplatesRemoveDates
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

                    b.Property<int?>("EventTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("EventTypeID");

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

                    b.Property<int?>("EventTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastEditedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("EventBooleanFields");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventBooleanFieldTemplate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EventTypeFieldTemplatesID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EventTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("EventTypeFieldTemplatesID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("EventBooleanFieldTemplates");
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

                    b.Property<int?>("EventTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastEditedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("EventDecimalFields");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventDecimalFieldTemplate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EventTypeFieldTemplatesID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EventTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("EventTypeFieldTemplatesID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("EventDecimalFieldTemplates");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventIntegerField", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EventTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Integer")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastEditedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("EventIntegerFields");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventIntegerFieldTemplate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EventTypeFieldTemplatesID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EventTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("EventTypeFieldTemplatesID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("EventIntegerFieldTemplates");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventStringField", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EventTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastEditedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("String")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("EventStringFields");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventStringFieldTemplate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EventTypeFieldTemplatesID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EventTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("EventTypeFieldTemplatesID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("EventStringFieldTemplates");
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

            modelBuilder.Entity("Ernest.Api.Models.Db.EventType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("EventTypes");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventTypeFieldTemplates", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EventTypeID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("EventTypeFieldTemplates");
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

            modelBuilder.Entity("Ernest.Api.Models.Db.Event", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeID");

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventBooleanField", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeID");

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventBooleanFieldTemplate", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.EventTypeFieldTemplates", null)
                        .WithMany("BooleanFields")
                        .HasForeignKey("EventTypeFieldTemplatesID");

                    b.HasOne("Ernest.Api.Models.Db.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeID");

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventDecimalField", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeID");

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventDecimalFieldTemplate", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.EventTypeFieldTemplates", null)
                        .WithMany("DecimalFields")
                        .HasForeignKey("EventTypeFieldTemplatesID");

                    b.HasOne("Ernest.Api.Models.Db.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeID");

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventIntegerField", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeID");

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventIntegerFieldTemplate", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.EventTypeFieldTemplates", null)
                        .WithMany("IntegerFields")
                        .HasForeignKey("EventTypeFieldTemplatesID");

                    b.HasOne("Ernest.Api.Models.Db.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeID");

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventStringField", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeID");

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventStringFieldTemplate", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.EventTypeFieldTemplates", null)
                        .WithMany("StringFields")
                        .HasForeignKey("EventTypeFieldTemplatesID");

                    b.HasOne("Ernest.Api.Models.Db.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeID");

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventTypeFieldTemplates", b =>
                {
                    b.HasOne("Ernest.Api.Models.Db.EventType", "EventType")
                        .WithMany("EventTypeFields")
                        .HasForeignKey("EventTypeID");

                    b.Navigation("EventType");
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

            modelBuilder.Entity("Ernest.Api.Models.Db.EventType", b =>
                {
                    b.Navigation("EventTypeFields");
                });

            modelBuilder.Entity("Ernest.Api.Models.Db.EventTypeFieldTemplates", b =>
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
