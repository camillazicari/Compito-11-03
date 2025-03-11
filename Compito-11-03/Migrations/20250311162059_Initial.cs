﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Compito_11_03.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titolo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Autore = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Genere = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Disponibilita = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
