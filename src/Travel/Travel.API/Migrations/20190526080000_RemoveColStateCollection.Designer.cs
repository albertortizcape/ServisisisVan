﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Infrastructure;

namespace Travel.API.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20190526080000_RemoveColStateCollection")]
    partial class RemoveColStateCollection
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.collection_sequence", "'collection_sequence', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.refuel_sequence", "'refuel_sequence', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.traveler_sequence", "'traveler_sequence', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.trip_sequence", "'trip_sequence', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Travel.Domain.AggregatesModel.CollectionAggregate.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "collection_sequence")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 5, 26, 9, 59, 59, 821, DateTimeKind.Local).AddTicks(6498));

                    b.HasKey("Id");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("Travel.Domain.AggregatesModel.CollectionAggregate.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<int?>("CollectionId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("IdTraveler");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.ToTable("Entry");
                });

            modelBuilder.Entity("Travel.Domain.AggregatesModel.RefuelAggregate.Refuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "refuel_sequence")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 5, 26, 9, 59, 59, 827, DateTimeKind.Local).AddTicks(4835));

                    b.HasKey("Id");

                    b.ToTable("Refuels");
                });

            modelBuilder.Entity("Travel.Domain.AggregatesModel.TravelerAggregate.Traveler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "traveler_sequence")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<bool>("IsDriver");

                    b.Property<DateTime?>("LeavingDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Travelers");
                });

            modelBuilder.Entity("Travel.Domain.AggregatesModel.TripAggregate.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "trip_sequence")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Commentary");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 5, 26, 9, 59, 59, 809, DateTimeKind.Local).AddTicks(9199));

                    b.Property<int>("IdDriver");

                    b.HasKey("Id");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("Travel.Domain.AggregatesModel.CollectionAggregate.Entry", b =>
                {
                    b.HasOne("Travel.Domain.AggregatesModel.CollectionAggregate.Collection")
                        .WithMany("Entries")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}