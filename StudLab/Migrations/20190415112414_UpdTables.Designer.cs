﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StudLab.Data;

namespace StudLab.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190415112414_UpdTables")]
    partial class UpdTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("StudLab.Model.TableTransportTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("NumColumn");

                    b.Property<int>("NumRow");

                    b.Property<string>("Table");

                    b.Property<int?>("TransportId");

                    b.HasKey("Id");

                    b.HasIndex("TransportId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("StudLab.Model.TransportTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailUser");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("Id");

                    b.ToTable("Transports");
                });

            modelBuilder.Entity("StudLab.Model.TableTransportTask", b =>
                {
                    b.HasOne("StudLab.Model.TransportTask", "Transport")
                        .WithMany("TableEntities")
                        .HasForeignKey("TransportId");
                });
#pragma warning restore 612, 618
        }
    }
}
