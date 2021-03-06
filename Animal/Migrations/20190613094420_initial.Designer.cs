﻿// <auto-generated />
using System;
using Animal.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Animal.Migrations
{
    [DbContext(typeof(AnimalContext))]
    [Migration("20190613094420_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Animal.Models.AnimalOwner", b =>
                {
                    b.Property<int>("AnimalId");

                    b.Property<int>("OwnerId");

                    b.HasKey("AnimalId", "OwnerId");

                    b.HasIndex("OwnerId");

                    b.ToTable("AnimalOwner");
                });

            modelBuilder.Entity("Animal.Models.AnimalRegistration", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("age");

                    b.Property<int>("breedId");

                    b.Property<string>("createdAt");

                    b.Property<int>("damId");

                    b.Property<string>("declaredBy");

                    b.Property<DateTime>("declaredDate");

                    b.Property<string>("dob");

                    b.Property<string>("earTagNo");

                    b.Property<int?>("farmId");

                    b.Property<string>("gender");

                    b.Property<int?>("keeperId");

                    b.Property<string>("lastCalvingDate");

                    b.Property<bool>("milkingStatus");

                    b.Property<string>("noOfCalving");

                    b.Property<int?>("ownerId");

                    b.Property<string>("pregnencyDuration");

                    b.Property<bool>("pregnencyStatus");

                    b.Property<int>("sireId");

                    b.Property<string>("species");

                    b.Property<string>("updatedBy");

                    b.Property<string>("weight");

                    b.HasKey("id");

                    b.HasIndex("breedId");

                    b.ToTable("dbug_animal");
                });

            modelBuilder.Entity("Animal.Models.Breed", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("breedNameShort");

                    b.Property<string>("breedNamelong");

                    b.Property<string>("originFrom");

                    b.Property<string>("registeredBy");

                    b.Property<DateTime>("registeredDate");

                    b.Property<string>("shortDetail");

                    b.Property<string>("updatedBy");

                    b.HasKey("id");

                    b.ToTable("dbug_breedAnimal");
                });

            modelBuilder.Entity("Animal.Models.Diseases", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnimalRegistrationid");

                    b.Property<string>("diseasesNameEng");

                    b.Property<string>("diseasesNameNep");

                    b.Property<string>("shortNote");

                    b.Property<string>("symptom");

                    b.HasKey("id");

                    b.HasIndex("AnimalRegistrationid");

                    b.ToTable("dbug_diseases");
                });

            modelBuilder.Entity("Animal.Models.Farm", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address");

                    b.Property<string>("area");

                    b.Property<string>("dateOfRegistration");

                    b.Property<string>("email");

                    b.Property<string>("farmType");

                    b.Property<string>("land");

                    b.Property<string>("latitude");

                    b.Property<string>("longitude");

                    b.Property<string>("mobile");

                    b.Property<string>("mobile1");

                    b.Property<string>("municipility");

                    b.Property<string>("orgtanizationName");

                    b.Property<string>("regCertification");

                    b.Property<string>("shortDetail");

                    b.Property<string>("url");

                    b.Property<string>("ward");

                    b.HasKey("id");

                    b.ToTable("dbug_farm");
                });

            modelBuilder.Entity("Animal.Models.FeedFooder", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address");

                    b.Property<string>("adl");

                    b.Property<string>("c");

                    b.Property<string>("cp");

                    b.Property<string>("cultivation");

                    b.Property<string>("df");

                    b.Property<string>("district");

                    b.Property<string>("dm");

                    b.Property<string>("fooderNameEng");

                    b.Property<string>("fooderNameNep");

                    b.Property<string>("grassProduct");

                    b.Property<string>("municipility");

                    b.Property<string>("ndf");

                    b.Property<string>("nitrateScore");

                    b.Property<string>("p");

                    b.Property<string>("price");

                    b.Property<string>("remarks");

                    b.Property<string>("seedHarvestingStorage");

                    b.Property<string>("seedingMethod");

                    b.Property<string>("shortNote");

                    b.Property<string>("state");

                    b.Property<string>("tanni");

                    b.Property<string>("tdn");

                    b.HasKey("id");

                    b.ToTable("dbug_FeedFooder");
                });

            modelBuilder.Entity("Animal.Models.GrowthMonitoring", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("animalRegistrationid");

                    b.Property<string>("earTagNo");

                    b.Property<string>("girth");

                    b.Property<string>("length");

                    b.Property<string>("monitoredBy");

                    b.Property<string>("shortNote");

                    b.Property<string>("weight");

                    b.HasKey("id");

                    b.HasIndex("animalRegistrationid");

                    b.ToTable("dbug_growthMonitoring");
                });

            modelBuilder.Entity("Animal.Models.HealthCheckUp", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("animalRegistrationid");

                    b.Property<string>("anlyzeReport");

                    b.Property<string>("charge");

                    b.Property<int?>("diseasesId");

                    b.Property<string>("earTagNo");

                    b.Property<int?>("laboratoryId");

                    b.Property<string>("receiptNo");

                    b.Property<DateTime>("reportExpDate");

                    b.Property<string>("sampleBoxNo");

                    b.Property<DateTime>("sampleTakenDate");

                    b.Property<int?>("serviceProviderId");

                    b.HasKey("id");

                    b.HasIndex("animalRegistrationid");

                    b.ToTable("dbug_healthCheckUp");
                });

            modelBuilder.Entity("Animal.Models.MIlkBaseNutrition", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("animalSpecies");

                    b.Property<string>("c");

                    b.Property<string>("cp");

                    b.Property<string>("dp");

                    b.Property<string>("fatPercentage");

                    b.Property<string>("ndf");

                    b.Property<string>("p");

                    b.Property<string>("snf");

                    b.Property<string>("tdn");

                    b.HasKey("id");

                    b.ToTable("dbug_milkBaseNutrition");
                });

            modelBuilder.Entity("Animal.Models.MilkRecord", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("animalRegistrationid");

                    b.Property<string>("earTagNumber");

                    b.Property<string>("genericProblem");

                    b.Property<string>("labId");

                    b.Property<string>("milkSampleBoxNo");

                    b.Property<string>("milkVolume");

                    b.Property<bool>("milkingStatus");

                    b.Property<string>("receiptNo");

                    b.Property<DateTime>("recordingDate");

                    b.Property<string>("recordingPeriod");

                    b.Property<string>("shortNote");

                    b.Property<string>("testingCharge");

                    b.Property<string>("vacination");

                    b.HasKey("id");

                    b.HasIndex("animalRegistrationid");

                    b.ToTable("dbug_milkRecord");
                });

            modelBuilder.Entity("Animal.Models.OwnerKeeper", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("academicQualification");

                    b.Property<string>("address");

                    b.Property<string>("category");

                    b.Property<string>("dob");

                    b.Property<string>("email");

                    b.Property<int?>("farmid");

                    b.Property<string>("finantanceStatus");

                    b.Property<string>("fullName");

                    b.Property<string>("latitude");

                    b.Property<string>("logitude");

                    b.Property<string>("mobileNumber");

                    b.Property<string>("municipililty");

                    b.Property<string>("occupation");

                    b.Property<string>("otherNumber");

                    b.Property<string>("state");

                    b.Property<string>("url");

                    b.Property<string>("wardNo");

                    b.HasKey("id");

                    b.HasIndex("farmid");

                    b.ToTable("dbug_ownerKeeper");
                });

            modelBuilder.Entity("Animal.Models.PregnancyBaseNutrition", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ageOfAnimal");

                    b.Property<string>("animalSpecies");

                    b.Property<string>("breed");

                    b.Property<string>("c");

                    b.Property<string>("cp");

                    b.Property<string>("dp");

                    b.Property<string>("earlyPreg");

                    b.Property<string>("fatPercentage");

                    b.Property<string>("latePreg");

                    b.Property<string>("midPreg");

                    b.Property<string>("ndf");

                    b.Property<string>("p");

                    b.Property<string>("snf");

                    b.Property<string>("tdn");

                    b.HasKey("id");

                    b.ToTable("dbug_pregnancyBawseNutrition");
                });

            modelBuilder.Entity("Animal.Models.Vaccination", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("manufacturedBy");

                    b.Property<string>("vaccinForm");

                    b.Property<string>("vaccinName");

                    b.Property<int?>("vaccinTypeId");

                    b.Property<int?>("vaccinationSubTypeId");

                    b.Property<int?>("vaccinationTypeid");

                    b.HasKey("id");

                    b.HasIndex("vaccinationSubTypeId");

                    b.HasIndex("vaccinationTypeid");

                    b.ToTable("dbug_vaccination");
                });

            modelBuilder.Entity("Animal.Models.VaccinationAnimal", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("animalId");

                    b.Property<int?>("animalRegistrationid");

                    b.Property<string>("batchNo");

                    b.Property<string>("charge");

                    b.Property<int>("diseasesId");

                    b.Property<string>("dosage");

                    b.Property<string>("earTagNo");

                    b.Property<string>("receiptNo");

                    b.Property<int>("serviceProviderId");

                    b.Property<int>("vaccinId");

                    b.Property<DateTime>("vaccinationDate");

                    b.Property<int?>("vaccinationid");

                    b.HasKey("id");

                    b.HasIndex("animalRegistrationid");

                    b.HasIndex("diseasesId");

                    b.HasIndex("vaccinationid");

                    b.ToTable("dbug_vaccinationAnimal");
                });

            modelBuilder.Entity("Animal.Models.VaccinationSubType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubTypeName");

                    b.Property<int>("VaccinationTypeId");

                    b.HasKey("id");

                    b.HasIndex("VaccinationTypeId");

                    b.ToTable("dbug_vaccinationSubType");
                });

            modelBuilder.Entity("Animal.Models.VaccinationType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("shortNote");

                    b.Property<string>("vaccinationName");

                    b.HasKey("id");

                    b.ToTable("dbug_vaccinationType");
                });

            modelBuilder.Entity("Animal.Models.AnimalOwner", b =>
                {
                    b.HasOne("Animal.Models.AnimalRegistration", "AnimalRegistration")
                        .WithMany("AnimalOwners")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Animal.Models.OwnerKeeper", "Owner")
                        .WithMany("AnimalOwners")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Animal.Models.AnimalRegistration", b =>
                {
                    b.HasOne("Animal.Models.Breed", "Breed")
                        .WithMany("AnimalRegistrations")
                        .HasForeignKey("breedId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Animal.Models.Diseases", b =>
                {
                    b.HasOne("Animal.Models.AnimalRegistration")
                        .WithMany("Diseases")
                        .HasForeignKey("AnimalRegistrationid");
                });

            modelBuilder.Entity("Animal.Models.GrowthMonitoring", b =>
                {
                    b.HasOne("Animal.Models.AnimalRegistration", "aniamlRegistration")
                        .WithMany("GrowtthMonitorings")
                        .HasForeignKey("animalRegistrationid");
                });

            modelBuilder.Entity("Animal.Models.HealthCheckUp", b =>
                {
                    b.HasOne("Animal.Models.AnimalRegistration", "animalRegistration")
                        .WithMany("HealthCheckUps")
                        .HasForeignKey("animalRegistrationid");
                });

            modelBuilder.Entity("Animal.Models.MilkRecord", b =>
                {
                    b.HasOne("Animal.Models.AnimalRegistration", "animalRegistration")
                        .WithMany("MilkRecords")
                        .HasForeignKey("animalRegistrationid");
                });

            modelBuilder.Entity("Animal.Models.OwnerKeeper", b =>
                {
                    b.HasOne("Animal.Models.Farm", "farm")
                        .WithMany("OwnerKeepers")
                        .HasForeignKey("farmid");
                });

            modelBuilder.Entity("Animal.Models.Vaccination", b =>
                {
                    b.HasOne("Animal.Models.VaccinationSubType", "vaccinationSubType")
                        .WithMany()
                        .HasForeignKey("vaccinationSubTypeId");

                    b.HasOne("Animal.Models.VaccinationType", "vaccinationType")
                        .WithMany()
                        .HasForeignKey("vaccinationTypeid");
                });

            modelBuilder.Entity("Animal.Models.VaccinationAnimal", b =>
                {
                    b.HasOne("Animal.Models.AnimalRegistration", "animalRegistration")
                        .WithMany()
                        .HasForeignKey("animalRegistrationid");

                    b.HasOne("Animal.Models.Diseases", "diseases")
                        .WithMany()
                        .HasForeignKey("diseasesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Animal.Models.Vaccination", "vaccination")
                        .WithMany("vaccinationAnimals")
                        .HasForeignKey("vaccinationid");
                });

            modelBuilder.Entity("Animal.Models.VaccinationSubType", b =>
                {
                    b.HasOne("Animal.Models.VaccinationType", "VaccinationType")
                        .WithMany("VaccinationSubTypes")
                        .HasForeignKey("VaccinationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
