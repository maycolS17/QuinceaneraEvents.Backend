using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace QuinceaneraEvents.Backend.Migrations;

/// <inheritdoc />
public partial class _20261127074322_InitialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Contacts",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                Email = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                Phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                EventType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                EventDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                GuestCount = table.Column<int>(type: "integer", nullable: true),
                Message = table.Column<string>(type: "text", nullable: true),
                RegisterDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                ApplicationStatus = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                NotificationStatus = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Contacts", x => x.Id);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Contacts");
    }
}
