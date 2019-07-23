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
    [Migration("20190526080326_AddColStateCollection")]
    partial class AddColStateCollection
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
                        .HasDefaultValue(new DateTime(2019, 5, 26, 10, 3, 25, 785, DateTimeKind.Local).AddTicks(4355));

                    b.Property<int?>("StateId");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("Travel.Domain.AggregatesModel.CollectionAggregate.CollectionState", b =>
                {
                    b.Property<int>("Id")
                        .HasDefaultValue(1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("CollectionStates");
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
                        .HasDefaultValue(new DateTime(2019, 5, 26, 10, 3, 25, 793, DateTimeKind.Local).AddTicks(9466));

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
                        .HasDefaultValue(new DateTime(2019, 5, 26, 10, 3, 25, 773, DateTimeKind.Local).AddTicks(1217));

                    b.Property<int>("IdDriver");

                    b.HasKey("Id");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("Travel.Domain.AggregatesModel.CollectionAggregate.Collection", b =>
                {
                    b.HasOne("Travel.Domain.AggregatesModel.CollectionAggregate.CollectionState", "State")
                        .WithMany()
                        .HasForeignKey("StateId");
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
