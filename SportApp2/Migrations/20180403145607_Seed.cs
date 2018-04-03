using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SportApp2.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO Foods (Id, Name, Description) VALUES ('{Guid.NewGuid()}', 'Apple', 'Fruit'), ('{Guid.NewGuid()}', 'Beef', 'Meat'), ('{Guid.NewGuid()}', 'Egg', 'Proteins')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Foods");
        }
    }
}
