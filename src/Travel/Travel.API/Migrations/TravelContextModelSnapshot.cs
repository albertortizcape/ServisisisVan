﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Infrastructure;

namespace Travel.API.Migrations
{
    [DbContext(typeof(TravelContext))]
    partial class TravelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.charge_sequence", "'charge_sequence', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.refuel_sequence", "'refuel_sequence', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.traveler_sequence", "'traveler_sequence', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.trip_sequence", "'trip_sequence', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Travel.Domain.AggregatesModel.ChargeAggregate.Charge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "charge_sequence")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 2, 6, 20, 10, 6, 596, DateTimeKind.Local).AddTicks(1243));

                    b.Property<int>("IdTraveler");

                    b.HasKey("Id");

                    b.ToTable("Charges");
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
                        .HasDefaultValue(new DateTime(2019, 2, 6, 20, 10, 6, 602, DateTimeKind.Local).AddTicks(1829));

                    b.HasKey("Id");

                    b.ToTable("Refuels");
                });

            modelBuilder.Entity("Travel.Domain.AggregatesModel.TravelAggregate.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "trip_sequence")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Commentary");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 2, 6, 20, 10, 6, 578, DateTimeKind.Local).AddTicks(6095));

                    b.Property<int>("IdDriver");

                    b.HasKey("Id");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("Travel.Domain.AggregatesModel.TravelerAggregate.Traveler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "traveler_sequence")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<bool>("IsDriver");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Travelers");
                });
#pragma warning restore 612, 618
        }
    }
}