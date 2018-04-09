using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SportApp2.Infrastructure.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var FoodTypeId1 = Guid.NewGuid();
            migrationBuilder.Sql($"INSERT INTO FoodTypes (Id, Name, Description) VALUES ('{FoodTypeId1}', 'Meat', 'Comes from animals')");
            var FoodTypeId2 = Guid.NewGuid();
            migrationBuilder.Sql($"INSERT INTO FoodTypes (Id, Name, Description) VALUES ('{FoodTypeId2}', 'Vegetable', 'Comes from ground')");
            var FoodTypeId3 = Guid.NewGuid();
            migrationBuilder.Sql($"INSERT INTO FoodTypes (Id, Name, Description) VALUES ('{FoodTypeId3}', 'Eggs', 'Comes from chickens')");

            var FoodId1 = Guid.NewGuid();
            migrationBuilder.Sql($"INSERT INTO Foods (Id, Name, Description, FoodTypeId) VALUES ('{FoodId1}', 'Apple', 'Fruit', '{FoodTypeId2}')");
            var FoodId2 = Guid.NewGuid();
            migrationBuilder.Sql($"INSERT INTO Foods (Id, Name, Description, FoodTypeId) VALUES ('{FoodId2}', 'Egg', 'Proteins', '{FoodTypeId1}')");
            var FoodId3 = Guid.NewGuid();
            migrationBuilder.Sql($"INSERT INTO Foods (Id, Name, Description, FoodTypeId) VALUES ('{FoodId3}', 'Apple', 'Fruit', '{FoodTypeId3}')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Foods");
            migrationBuilder.Sql("DELETE FROM FoodTypes");
        }
    }
}
