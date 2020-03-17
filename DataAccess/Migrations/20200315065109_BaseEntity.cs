using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class BaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_categoryEntities",
                table: "categoryEntities");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "categoryEntities",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "categoryEntities",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "categoryEntities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_categoryEntities",
                table: "categoryEntities",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_categoryEntities",
                table: "categoryEntities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "categoryEntities");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "categoryEntities");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "categoryEntities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_categoryEntities",
                table: "categoryEntities",
                column: "CategoryId");
        }
    }
}
