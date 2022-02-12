using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyJob.Persistence.Migrations
{
    public partial class JobPosting_CreationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "JobPostings",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostings_CreationDate",
                table: "JobPostings",
                column: "CreationDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_JobPostings_CreationDate",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "JobPostings");
        }
    }
}
