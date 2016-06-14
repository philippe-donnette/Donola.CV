using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CV.Api.NpgsqlMigrations
{
    public partial class Initial_Npgsql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    Caption = table.Column<string>(nullable: true),
                    CaptionIconClass = table.Column<string>(nullable: true),
                    ImageBackUrl = table.Column<string>(nullable: true),
                    ImageFrontUrl = table.Column<string>(nullable: true),
                    Rotate = table.Column<string>(nullable: true),
                    TextBack = table.Column<string>(nullable: true),
                    TextFront = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    City = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    RoleTitle = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    WebsiteUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    AboutCaption = table.Column<string>(nullable: true),
                    AboutImage = table.Column<string>(nullable: true),
                    AboutMotto = table.Column<string>(nullable: true),
                    AboutText = table.Column<string>(nullable: true),
                    Firstname = table.Column<string>(nullable: true),
                    GitHubUrl = table.Column<string>(nullable: true),
                    HomeImage = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    LinkedinUrl = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    OccupationMotto = table.Column<string>(nullable: true),
                    PrimaryImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PrimaryImage = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    DegreeFile = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    SchoolName = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    WebsiteUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    Description = table.Column<string>(nullable: true),
                    ExperienceRating = table.Column<int>(nullable: false),
                    IconClass = table.Column<string>(nullable: true),
                    InterestRating = table.Column<int>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UsageRating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    CertificateFile = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Provider = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    WebsiteUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectImage_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceSkill",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false),
                    UsageRating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceSkill", x => new { x.ExperienceId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ExperienceSkill_Experience_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experience",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperienceSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSkill",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false),
                    UsageRating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSkill", x => new { x.ProjectId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ProjectSkill_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillVersion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:Serial", true),
                    Name = table.Column<string>(nullable: true),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillVersion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillVersion_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceSkillVersion",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false),
                    SkillVersionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceSkillVersion", x => new { x.ExperienceId, x.SkillId, x.SkillVersionId });
                    table.ForeignKey(
                        name: "FK_ExperienceSkillVersion_SkillVersion_SkillVersionId",
                        column: x => x.SkillVersionId,
                        principalTable: "SkillVersion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperienceSkillVersion_ExperienceSkill_ExperienceId_SkillId",
                        columns: x => new { x.ExperienceId, x.SkillId },
                        principalTable: "ExperienceSkill",
                        principalColumns: new[] { "ExperienceId", "SkillId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSkillVersion",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false),
                    SkillVersionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSkillVersion", x => new { x.ProjectId, x.SkillId, x.SkillVersionId });
                    table.ForeignKey(
                        name: "FK_ProjectSkillVersion_SkillVersion_SkillVersionId",
                        column: x => x.SkillVersionId,
                        principalTable: "SkillVersion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSkillVersion_ProjectSkill_ProjectId_SkillId",
                        columns: x => new { x.ProjectId, x.SkillId },
                        principalTable: "ProjectSkill",
                        principalColumns: new[] { "ProjectId", "SkillId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceSkill_ExperienceId",
                table: "ExperienceSkill",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceSkill_SkillId",
                table: "ExperienceSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceSkillVersion_SkillVersionId",
                table: "ExperienceSkillVersion",
                column: "SkillVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceSkillVersion_ExperienceId_SkillId",
                table: "ExperienceSkillVersion",
                columns: new[] { "ExperienceId", "SkillId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImage_ProjectId",
                table: "ProjectImage",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkill_ProjectId",
                table: "ProjectSkill",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkill_SkillId",
                table: "ProjectSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkillVersion_SkillVersionId",
                table: "ProjectSkillVersion",
                column: "SkillVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkillVersion_ProjectId_SkillId",
                table: "ProjectSkillVersion",
                columns: new[] { "ProjectId", "SkillId" });

            migrationBuilder.CreateIndex(
                name: "IX_SkillVersion_SkillId",
                table: "SkillVersion",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "ExperienceSkillVersion");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "ProjectImage");

            migrationBuilder.DropTable(
                name: "ProjectSkillVersion");

            migrationBuilder.DropTable(
                name: "Qualification");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "ExperienceSkill");

            migrationBuilder.DropTable(
                name: "SkillVersion");

            migrationBuilder.DropTable(
                name: "ProjectSkill");

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Skill");
        }
    }
}
