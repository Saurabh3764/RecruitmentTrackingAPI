using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitmentTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedAdminsSection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobPostedDay",
                table: "OpenJob",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobPostedDay",
                table: "OpenJob");
        }
    }
}
