using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SportApp2.Infrastructure.Migrations
{
    public partial class Names : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_FoodTypes_FoodTypesId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Foods_FoodsId",
                table: "ProductImages");

            migrationBuilder.RenameColumn(
                name: "FoodsId",
                table: "ProductImages",
                newName: "FoodTypeId");

            migrationBuilder.RenameColumn(
                name: "FoodTypesId",
                table: "ProductImages",
                newName: "FoodId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_FoodsId",
                table: "ProductImages",
                newName: "IX_ProductImages_FoodTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_FoodTypesId",
                table: "ProductImages",
                newName: "IX_ProductImages_FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Foods_FoodId",
                table: "ProductImages",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_FoodTypes_FoodTypeId",
                table: "ProductImages",
                column: "FoodTypeId",
                principalTable: "FoodTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Foods_FoodId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_FoodTypes_FoodTypeId",
                table: "ProductImages");

            migrationBuilder.RenameColumn(
                name: "FoodTypeId",
                table: "ProductImages",
                newName: "FoodsId");

            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "ProductImages",
                newName: "FoodTypesId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_FoodTypeId",
                table: "ProductImages",
                newName: "IX_ProductImages_FoodsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_FoodId",
                table: "ProductImages",
                newName: "IX_ProductImages_FoodTypesId");

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
    }
}
