﻿// <auto-generated />
using ConversionsDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConversionsDb.Migrations
{
    [DbContext(typeof(ConversionsContext))]
    partial class ConversionsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConversionsDb.Models.Units.BaseUnitMap", b =>
                {
                    b.Property<int>("UnitTypeId");

                    b.Property<int>("BaseUnitId");

                    b.HasKey("UnitTypeId", "BaseUnitId");

                    b.HasAlternateKey("BaseUnitId", "UnitTypeId");

                    b.ToTable("BaseUnitMap","Units");

                    b.HasData(
                        new { UnitTypeId = 2, BaseUnitId = 13 },
                        new { UnitTypeId = 1, BaseUnitId = 2 }
                    );
                });

            modelBuilder.Entity("ConversionsDb.Models.Units.Conversion", b =>
                {
                    b.Property<int>("FromUnitId");

                    b.Property<int>("ToUnitId");

                    b.Property<double>("Multiplier");

                    b.HasKey("FromUnitId", "ToUnitId");

                    b.HasIndex("ToUnitId");

                    b.ToTable("Conversion","Units");

                    b.HasData(
                        new { FromUnitId = 13, ToUnitId = 19, Multiplier = 100.0 },
                        new { FromUnitId = 13, ToUnitId = 14, Multiplier = 10000000.0 },
                        new { FromUnitId = 15, ToUnitId = 13, Multiplier = 2.58999 },
                        new { FromUnitId = 15, ToUnitId = 20, Multiplier = 640.0 },
                        new { FromUnitId = 15, ToUnitId = 16, Multiplier = 3097600.0 },
                        new { FromUnitId = 15, ToUnitId = 17, Multiplier = 27878400.0 },
                        new { FromUnitId = 15, ToUnitId = 18, Multiplier = 4014489600.0 },
                        new { FromUnitId = 1, ToUnitId = 2, Multiplier = 1000.0 },
                        new { FromUnitId = 2, ToUnitId = 3, Multiplier = 10.0 },
                        new { FromUnitId = 2, ToUnitId = 4, Multiplier = 100.0 },
                        new { FromUnitId = 2, ToUnitId = 5, Multiplier = 1000.0 },
                        new { FromUnitId = 2, ToUnitId = 6, Multiplier = 1000000.0 },
                        new { FromUnitId = 2, ToUnitId = 7, Multiplier = 1000000000.0 },
                        new { FromUnitId = 10, ToUnitId = 2, Multiplier = 0.3048 },
                        new { FromUnitId = 8, ToUnitId = 10, Multiplier = 5280.0 },
                        new { FromUnitId = 9, ToUnitId = 10, Multiplier = 3.0 },
                        new { FromUnitId = 10, ToUnitId = 11, Multiplier = 12.0 },
                        new { FromUnitId = 12, ToUnitId = 10, Multiplier = 6076.12 }
                    );
                });

            modelBuilder.Entity("ConversionsDb.Models.Units.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.ToTable("Unit","Units");

                    b.HasData(
                        new { Id = 13, DisplayName = "Square Kilometre", Symbol = "km²" },
                        new { Id = 14, DisplayName = "Square Metre", Symbol = "m²" },
                        new { Id = 15, DisplayName = "Square Mile", Symbol = "mi²" },
                        new { Id = 16, DisplayName = "Square Yard", Symbol = "yd²" },
                        new { Id = 17, DisplayName = "Square Foot", Symbol = "ft²" },
                        new { Id = 18, DisplayName = "Square Inch", Symbol = "in²" },
                        new { Id = 19, DisplayName = "Hectare", Symbol = "ha" },
                        new { Id = 20, DisplayName = "Acre", Symbol = "ac" },
                        new { Id = 1, DisplayName = "Kilometre", Symbol = "km" },
                        new { Id = 2, DisplayName = "Metre", Symbol = "m" },
                        new { Id = 3, DisplayName = "Decimetre", Symbol = "dm" },
                        new { Id = 4, DisplayName = "Centimetre", Symbol = "cm" },
                        new { Id = 5, DisplayName = "Millimetre", Symbol = "mm" },
                        new { Id = 6, DisplayName = "Micrometre", Symbol = "μm" },
                        new { Id = 7, DisplayName = "Nanometre", Symbol = "nm" },
                        new { Id = 8, DisplayName = "Mile", Symbol = "mi" },
                        new { Id = 9, DisplayName = "Yard", Symbol = "yd" },
                        new { Id = 10, DisplayName = "Foot", Symbol = "ft" },
                        new { Id = 11, DisplayName = "Inch", Symbol = "in" },
                        new { Id = 12, DisplayName = "Nautical Mile", Symbol = "nmi" }
                    );
                });

            modelBuilder.Entity("ConversionsDb.Models.Units.UnitType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("UnitType","Units");

                    b.HasData(
                        new { Id = 2, DisplayName = "Area" },
                        new { Id = 1, DisplayName = "Distance" }
                    );
                });

            modelBuilder.Entity("ConversionsDb.Models.Units.UnitTypeMap", b =>
                {
                    b.Property<int>("UnitTypeId");

                    b.Property<int>("UnitId");

                    b.HasKey("UnitTypeId", "UnitId");

                    b.HasAlternateKey("UnitId", "UnitTypeId");

                    b.ToTable("UnitTypeMap","Units");

                    b.HasData(
                        new { UnitTypeId = 1, UnitId = 1 },
                        new { UnitTypeId = 1, UnitId = 2 },
                        new { UnitTypeId = 1, UnitId = 3 },
                        new { UnitTypeId = 1, UnitId = 4 },
                        new { UnitTypeId = 1, UnitId = 5 },
                        new { UnitTypeId = 1, UnitId = 6 },
                        new { UnitTypeId = 1, UnitId = 7 },
                        new { UnitTypeId = 1, UnitId = 8 },
                        new { UnitTypeId = 1, UnitId = 9 },
                        new { UnitTypeId = 1, UnitId = 10 },
                        new { UnitTypeId = 1, UnitId = 11 },
                        new { UnitTypeId = 1, UnitId = 12 },
                        new { UnitTypeId = 2, UnitId = 13 },
                        new { UnitTypeId = 2, UnitId = 14 },
                        new { UnitTypeId = 2, UnitId = 15 },
                        new { UnitTypeId = 2, UnitId = 16 },
                        new { UnitTypeId = 2, UnitId = 17 },
                        new { UnitTypeId = 2, UnitId = 18 },
                        new { UnitTypeId = 2, UnitId = 19 },
                        new { UnitTypeId = 2, UnitId = 20 }
                    );
                });

            modelBuilder.Entity("ConversionsDb.Models.Units.BaseUnitMap", b =>
                {
                    b.HasOne("ConversionsDb.Models.Units.Unit", "BaseUnit")
                        .WithMany()
                        .HasForeignKey("BaseUnitId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConversionsDb.Models.Units.UnitType", "UnitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConversionsDb.Models.Units.Conversion", b =>
                {
                    b.HasOne("ConversionsDb.Models.Units.Unit", "FromUnit")
                        .WithMany()
                        .HasForeignKey("FromUnitId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConversionsDb.Models.Units.Unit", "ToUnit")
                        .WithMany()
                        .HasForeignKey("ToUnitId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConversionsDb.Models.Units.UnitTypeMap", b =>
                {
                    b.HasOne("ConversionsDb.Models.Units.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConversionsDb.Models.Units.UnitType", "UnitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
