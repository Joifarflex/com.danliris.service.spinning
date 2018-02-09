﻿// <auto-generated />
using Com.Danliris.Service.Spinning.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Com.Danliris.Service.Spinning.Lib.Migrations
{
    [DbContext(typeof(SpinningDbContext))]
    [Migration("20180209114948_spinninginput")]
    partial class spinninginput
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Danliris.Service.Spinning.Lib.Models.LotYarn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Lot")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<int>("UnitId")
                        .HasMaxLength(100);

                    b.Property<int>("YarnId");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("YarnId");

                    b.ToTable("LotYarns");
                });

            modelBuilder.Entity("Com.Danliris.Service.Spinning.Lib.Models.SpinningInputProduction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Lot");

                    b.Property<string>("NomorInputProduksi")
                        .HasMaxLength(100);

                    b.Property<string>("Shift");

                    b.Property<int>("UnitId");

                    b.Property<string>("UnitName");

                    b.Property<int>("YarnId");

                    b.Property<string>("YarnName");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.Property<DateTime>("tanggal");

                    b.HasKey("Id");

                    b.ToTable("SpinningInputProductions");
                });

            modelBuilder.Entity("Com.Danliris.Service.Spinning.Lib.Models.SpinningInputProduction_InputDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100);

                    b.Property<bool>("Active");

                    b.Property<string>("Code");

                    b.Property<int>("Counter");

                    b.Property<int>("Hash");

                    b.Property<int>("SpinningInputProductionId");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.Property<int>("test");

                    b.HasKey("Id");

                    b.HasIndex("SpinningInputProductionId");

                    b.ToTable("SpinningInputProduction_InputDetails");
                });

            modelBuilder.Entity("Com.Danliris.Service.Spinning.Lib.Models.Yarn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<double>("Ne");

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Yarns");
                });

            modelBuilder.Entity("Com.Danliris.Service.Spinning.Lib.Models.YarnOutputProduction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<double>("BadOutput");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Date");

                    b.Property<double>("DrumTotal");

                    b.Property<double>("GoodOutput");

                    b.Property<string>("LotYarnCode")
                        .HasMaxLength(10);

                    b.Property<int>("LotYarnId")
                        .HasMaxLength(500);

                    b.Property<string>("LotYarnName")
                        .HasMaxLength(500);

                    b.Property<string>("MachineId")
                        .HasMaxLength(500);

                    b.Property<string>("MachineName")
                        .HasMaxLength(500);

                    b.Property<string>("Shift")
                        .HasMaxLength(500);

                    b.Property<string>("Spinning")
                        .HasMaxLength(500);

                    b.Property<string>("SpinningId");

                    b.Property<string>("YarnCode")
                        .HasMaxLength(100);

                    b.Property<int>("YarnId")
                        .HasMaxLength(500);

                    b.Property<string>("YarnName")
                        .HasMaxLength(500);

                    b.Property<double>("YarnWeightPerCone");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("YarnOutputProductions");
                });

            modelBuilder.Entity("Com.Danliris.Service.Spinning.Lib.Models.LotYarn", b =>
                {
                    b.HasOne("Com.Danliris.Service.Spinning.Lib.Models.Yarn", "Yarn")
                        .WithMany()
                        .HasForeignKey("YarnId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Danliris.Service.Spinning.Lib.Models.SpinningInputProduction_InputDetails", b =>
                {
                    b.HasOne("Com.Danliris.Service.Spinning.Lib.Models.SpinningInputProduction")
                        .WithMany("Input")
                        .HasForeignKey("SpinningInputProductionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
