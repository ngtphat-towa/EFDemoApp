﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDemo.DataAccessLibrary.Migrations
{
    /// <inheritdoc />
    public partial class PersonTable_AddBirthDateColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "People");
        }
    }
}
