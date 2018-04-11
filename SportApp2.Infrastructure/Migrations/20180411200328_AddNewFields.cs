using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SportApp2.Infrastructure.Migrations
{
    public partial class AddNewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductImageId",
                table: "FoodTypes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodTypes_ProductImageId",
                table: "FoodTypes",
                column: "ProductImageId",
                unique: true,
                filter: "[ProductImageId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodTypes_ProductImages_ProductImageId",
                table: "FoodTypes",
                column: "ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodTypes_ProductImages_ProductImageId",
                table: "FoodTypes");

            migrationBuilder.DropIndex(
                name: "IX_FoodTypes_ProductImageId",
                table: "FoodTypes");

            migrationBuilder.DropColumn(
                name: "ProductImageId",
                table: "FoodTypes");
        }
    }
}
