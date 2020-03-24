using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class fechamodifica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InputOutputs_Storages_StorageId",
                table: "InputOutputs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InputOutputs",
                table: "InputOutputs");

            migrationBuilder.RenameTable(
                name: "InputOutputs",
                newName: "InOuts");

            migrationBuilder.RenameIndex(
                name: "IX_InputOutputs_StorageId",
                table: "InOuts",
                newName: "IX_InOuts_StorageId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "WhereHouses",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "Storages",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "Products",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "InOuts",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InOuts",
                table: "InOuts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InOuts_Storages_StorageId",
                table: "InOuts",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InOuts_Storages_StorageId",
                table: "InOuts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InOuts",
                table: "InOuts");

            migrationBuilder.RenameTable(
                name: "InOuts",
                newName: "InputOutputs");

            migrationBuilder.RenameIndex(
                name: "IX_InOuts_StorageId",
                table: "InputOutputs",
                newName: "IX_InputOutputs_StorageId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "WhereHouses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "Storages",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "InputOutputs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InputOutputs",
                table: "InputOutputs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InputOutputs_Storages_StorageId",
                table: "InputOutputs",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
