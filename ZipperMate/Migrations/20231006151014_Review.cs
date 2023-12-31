﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ZipperMate.Migrations
{
    public partial class Review : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Review",
                table: "Zippers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Review",
                table: "Zippers");
        }
    }
}
