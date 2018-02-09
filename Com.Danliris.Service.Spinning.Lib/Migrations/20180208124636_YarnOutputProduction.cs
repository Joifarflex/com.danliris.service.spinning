﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Com.Danliris.Service.Spinning.Lib.Migrations
{
    public partial class YarnOutputProduction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YarnOutputProductions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    BadOutput = table.Column<double>(nullable: false),
                    Code = table.Column<string>(maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    DrumTotal = table.Column<double>(nullable: false),
                    GoodOutput = table.Column<double>(nullable: false),
                    LotYarnCode = table.Column<string>(maxLength: 10, nullable: true),
                    LotYarnId = table.Column<int>(maxLength: 500, nullable: false),
                    LotYarnName = table.Column<string>(maxLength: 500, nullable: true),
                    MachineId = table.Column<string>(maxLength: 500, nullable: true),
                    MachineName = table.Column<string>(maxLength: 500, nullable: true),
                    Shift = table.Column<string>(maxLength: 500, nullable: true),
                    Spinning = table.Column<string>(maxLength: 500, nullable: true),
                    SpinningId = table.Column<string>(nullable: true),
                    YarnCode = table.Column<string>(maxLength: 100, nullable: true),
                    YarnId = table.Column<int>(maxLength: 500, nullable: false),
                    YarnName = table.Column<string>(maxLength: 500, nullable: true),
                    YarnWeightPerCone = table.Column<double>(nullable: false),
                    _CreatedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    _CreatedBy = table.Column<string>(maxLength: 255, nullable: false),
                    _CreatedUtc = table.Column<DateTime>(nullable: false),
                    _DeletedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    _DeletedBy = table.Column<string>(maxLength: 255, nullable: false),
                    _DeletedUtc = table.Column<DateTime>(nullable: false),
                    _IsDeleted = table.Column<bool>(nullable: false),
                    _LastModifiedAgent = table.Column<string>(maxLength: 255, nullable: false),
                    _LastModifiedBy = table.Column<string>(maxLength: 255, nullable: false),
                    _LastModifiedUtc = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YarnOutputProductions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YarnOutputProductions");
        }
    }
}