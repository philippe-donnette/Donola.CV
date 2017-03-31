using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CV.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Caption = table.Column<string>(maxLength: 100, nullable: true),
                    CaptionIconClass = table.Column<string>(maxLength: 100, nullable: true),
                    ImageBackUrl = table.Column<string>(maxLength: 200, nullable: true),
                    ImageFrontUrl = table.Column<string>(maxLength: 200, nullable: true),
                    Rotate = table.Column<string>(maxLength: 1, nullable: true),
                    TextBack = table.Column<string>(maxLength: 500, nullable: true),
                    TextFront = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    CompanyName = table.Column<string>(maxLength: 300, nullable: true),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 3000, nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    ImageUrl = table.Column<string>(maxLength: 200, nullable: true),
                    RoleTitle = table.Column<string>(maxLength: 200, nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    WebsiteUrl = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AboutCaption = table.Column<string>(maxLength: 200, nullable: true),
                    AboutImage = table.Column<string>(maxLength: 200, nullable: true),
                    AboutMotto = table.Column<string>(maxLength: 400, nullable: true),
                    AboutText = table.Column<string>(maxLength: 1000, nullable: true),
                    Firstname = table.Column<string>(maxLength: 200, nullable: true),
                    GitHubUrl = table.Column<string>(maxLength: 400, nullable: true),
                    HomeImage = table.Column<string>(maxLength: 200, nullable: true),
                    Lastname = table.Column<string>(maxLength: 200, nullable: true),
                    LinkedinUrl = table.Column<string>(maxLength: 400, nullable: true),
                    Occupation = table.Column<string>(maxLength: 200, nullable: true),
                    OccupationMotto = table.Column<string>(maxLength: 400, nullable: true),
                    PrimaryImage = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    PrimaryImage = table.Column<string>(maxLength: 200, nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    City = table.Column<string>(maxLength: 200, nullable: true),
                    Country = table.Column<string>(maxLength: 200, nullable: true),
                    DegreeFile = table.Column<string>(maxLength: 200, nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ImageUrl = table.Column<string>(maxLength: 200, nullable: true),
                    SchoolName = table.Column<string>(maxLength: 200, nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(maxLength: 200, nullable: true),
                    WebsiteUrl = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    ExperienceRating = table.Column<int>(nullable: false),
                    IconClass = table.Column<string>(maxLength: 200, nullable: true),
                    InterestRating = table.Column<int>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    UsageRating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CertificateFile = table.Column<string>(maxLength: 200, nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    ImageUrl = table.Column<string>(maxLength: 200, nullable: true),
                    Provider = table.Column<string>(maxLength: 200, nullable: true),
                    Subject = table.Column<string>(maxLength: 200, nullable: true),
                    WebsiteUrl = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    ImageUrl = table.Column<string>(maxLength: 200, nullable: true),
                    ProjectId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectImages_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceSkills",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false),
                    UsageRating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceSkills", x => new { x.ExperienceId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ExperienceSkills_Experiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperienceSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSkills",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false),
                    UsageRating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSkills", x => new { x.ProjectId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ProjectSkills_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillVersions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillVersions_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceSkillVersions",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false),
                    SkillVersionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceSkillVersions", x => new { x.ExperienceId, x.SkillId, x.SkillVersionId });
                    table.ForeignKey(
                        name: "FK_ExperienceSkillVersions_SkillVersions_SkillVersionId",
                        column: x => x.SkillVersionId,
                        principalTable: "SkillVersions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperienceSkillVersions_ExperienceSkills_ExperienceId_SkillId",
                        columns: x => new { x.ExperienceId, x.SkillId },
                        principalTable: "ExperienceSkills",
                        principalColumns: new[] { "ExperienceId", "SkillId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSkillVersions",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false),
                    SkillVersionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSkillVersions", x => new { x.ProjectId, x.SkillId, x.SkillVersionId });
                    table.ForeignKey(
                        name: "FK_ProjectSkillVersions_SkillVersions_SkillVersionId",
                        column: x => x.SkillVersionId,
                        principalTable: "SkillVersions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSkillVersions_ProjectSkills_ProjectId_SkillId",
                        columns: x => new { x.ProjectId, x.SkillId },
                        principalTable: "ProjectSkills",
                        principalColumns: new[] { "ProjectId", "SkillId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceSkills_SkillId",
                table: "ExperienceSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceSkillVersions_SkillVersionId",
                table: "ExperienceSkillVersions",
                column: "SkillVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImages_ProjectId",
                table: "ProjectImages",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkills_SkillId",
                table: "ProjectSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkillVersions_SkillVersionId",
                table: "ProjectSkillVersions",
                column: "SkillVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillVersions_SkillId",
                table: "SkillVersions",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "ExperienceSkillVersions");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "ProjectImages");

            migrationBuilder.DropTable(
                name: "ProjectSkillVersions");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "ExperienceSkills");

            migrationBuilder.DropTable(
                name: "SkillVersions");

            migrationBuilder.DropTable(
                name: "ProjectSkills");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
