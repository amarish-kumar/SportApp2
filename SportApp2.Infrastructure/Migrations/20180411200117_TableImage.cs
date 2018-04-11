using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SportApp2.Infrastructure.Migrations
{
    public partial class TableImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductImageId",
                table: "Foods",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_ProductImageId",
                table: "Foods",
                column: "ProductImageId",
                unique: true,
                filter: "[ProductImageId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_ProductImages_ProductImageId",
                table: "Foods",
                column: "ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_ProductImages_ProductImageId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_Foods_ProductImageId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "ProductImageId",
                table: "Foods");
        }
    }
}
