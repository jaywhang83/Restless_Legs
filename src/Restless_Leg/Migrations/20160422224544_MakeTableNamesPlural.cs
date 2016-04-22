using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Restless_Leg.Migrations
{
    public partial class MakeTableNamesPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Posting_Location_LocationId", table: "Posting");
            migrationBuilder.RenameTable(
                name: "Posting",
                newName: "Postings");
            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");
            migrationBuilder.AddForeignKey(
                name: "FK_Posting_Location_LocationId",
                table: "Postings",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Posting_Location_LocationId", table: "Postings");
            migrationBuilder.AddForeignKey(
                name: "FK_Posting_Location_LocationId",
                table: "Posting",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.RenameTable(
                name: "Postings",
                newName: "Posting");
            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");
        }
    }
}
