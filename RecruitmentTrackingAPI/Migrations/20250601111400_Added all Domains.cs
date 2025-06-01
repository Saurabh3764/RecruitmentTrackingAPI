using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitmentTrackingAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedallDomains : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConcernedManager",
                columns: table => new
                {
                    ManagerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Contact = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConcernedManager", x => x.ManagerID);
                });

            migrationBuilder.CreateTable(
                name: "JobApplication",
                columns: table => new
                {
                    ApplicationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfApplication = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplication", x => x.ApplicationID);
                });

            migrationBuilder.CreateTable(
                name: "OpenJob",
                columns: table => new
                {
                    JobID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfOpenJobs = table.Column<int>(type: "int", nullable: false),
                    ManagerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenJob", x => x.JobID);
                    table.ForeignKey(
                        name: "FK_OpenJob_ConcernedManager_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "ConcernedManager",
                        principalColumn: "ManagerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applicant",
                columns: table => new
                {
                    ApplicantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fresher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobApplicationsApplicationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicant", x => x.ApplicantID);
                    table.ForeignKey(
                        name: "FK_Applicant_JobApplication_JobApplicationsApplicationID",
                        column: x => x.JobApplicationsApplicationID,
                        principalTable: "JobApplication",
                        principalColumn: "ApplicationID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applicant_JobApplicationsApplicationID",
                table: "Applicant",
                column: "JobApplicationsApplicationID");

            migrationBuilder.CreateIndex(
                name: "IX_OpenJob_ManagerID",
                table: "OpenJob",
                column: "ManagerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicant");

            migrationBuilder.DropTable(
                name: "OpenJob");

            migrationBuilder.DropTable(
                name: "JobApplication");

            migrationBuilder.DropTable(
                name: "ConcernedManager");
        }
    }
}
