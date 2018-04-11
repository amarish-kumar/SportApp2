using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SportApp2.Infrastructure.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_ProductImages_ProductImageId",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodTypes_ProductImages_ProductImageId",
                table: "FoodTypes");

            migrationBuilder.DropIndex(
                name: "IX_FoodTypes_ProductImageId",
                table: "FoodTypes");

            migrationBuilder.DropIndex(
                name: "IX_Foods_ProductImageId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "ProductImageId",
                table: "FoodTypes");

            migrationBuilder.DropColumn(
                name: "ProductImageId",
                table: "Foods");

            migrationBuilder.AddColumn<Guid>(
                name: "FoodTypesId",
                table: "ProductImages",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FoodsId",
                table: "ProductImages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_FoodTypesId",
                table: "ProductImages",
                column: "FoodTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_FoodsId",
                table: "ProductImages",
                column: "FoodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_FoodTypes_FoodTypesId",
                table: "ProductImages",
                column: "FoodTypesId",
                principalTable: "FoodTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Foods_FoodsId",
                table: "ProductImages",
                column: "FoodsId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_FoodTypes_FoodTypesId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Foods_FoodsId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_FoodTypesId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_FoodsId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "FoodTypesId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "FoodsId",
                table: "ProductImages");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductImageId",
                table: "FoodTypes",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductImageId",
                table: "Foods",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodTypes_ProductImageId",
                table: "FoodTypes",
                column: "ProductImageId",
                unique: true,
                filter: "[ProductImageId] IS NOT NULL");

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

            migrationBuilder.AddForeignKey(
                name: "FK_FoodTypes_ProductImages_ProductImageId",
                table: "FoodTypes",
                column: "ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
