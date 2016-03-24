using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace CV.DataAccessLayer.Migrations
{
    public partial class Qualification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_ExperienceSkill_Experience_ExperienceId", table: "ExperienceSkill");
            migrationBuilder.DropForeignKey(name: "FK_ExperienceSkill_Skill_SkillId", table: "ExperienceSkill");
            migrationBuilder.DropForeignKey(name: "FK_ExperienceSkillVersion_SkillVersion_SkillVersionId", table: "ExperienceSkillVersion");
            migrationBuilder.DropForeignKey(name: "FK_ProjectImage_Project_ProjectId", table: "ProjectImage");
            migrationBuilder.DropForeignKey(name: "FK_ProjectSkill_Project_ProjectId", table: "ProjectSkill");
            migrationBuilder.DropForeignKey(name: "FK_ProjectSkill_Skill_SkillId", table: "ProjectSkill");
            migrationBuilder.DropForeignKey(name: "FK_ProjectSkillVersion_SkillVersion_SkillVersionId", table: "ProjectSkillVersion");
            migrationBuilder.DropForeignKey(name: "FK_SkillVersion_Skill_SkillId", table: "SkillVersion");
            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceSkill_Experience_ExperienceId",
                table: "ExperienceSkill",
                column: "ExperienceId",
                principalTable: "Experience",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceSkill_Skill_SkillId",
                table: "ExperienceSkill",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceSkillVersion_SkillVersion_SkillVersionId",
                table: "ExperienceSkillVersion",
                column: "SkillVersionId",
                principalTable: "SkillVersion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_ProjectImage_Project_ProjectId",
                table: "ProjectImage",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSkill_Project_ProjectId",
                table: "ProjectSkill",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSkill_Skill_SkillId",
                table: "ProjectSkill",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSkillVersion_SkillVersion_SkillVersionId",
                table: "ProjectSkillVersion",
                column: "SkillVersionId",
                principalTable: "SkillVersion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_SkillVersion_Skill_SkillId",
                table: "SkillVersion",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_ExperienceSkill_Experience_ExperienceId", table: "ExperienceSkill");
            migrationBuilder.DropForeignKey(name: "FK_ExperienceSkill_Skill_SkillId", table: "ExperienceSkill");
            migrationBuilder.DropForeignKey(name: "FK_ExperienceSkillVersion_SkillVersion_SkillVersionId", table: "ExperienceSkillVersion");
            migrationBuilder.DropForeignKey(name: "FK_ProjectImage_Project_ProjectId", table: "ProjectImage");
            migrationBuilder.DropForeignKey(name: "FK_ProjectSkill_Project_ProjectId", table: "ProjectSkill");
            migrationBuilder.DropForeignKey(name: "FK_ProjectSkill_Skill_SkillId", table: "ProjectSkill");
            migrationBuilder.DropForeignKey(name: "FK_ProjectSkillVersion_SkillVersion_SkillVersionId", table: "ProjectSkillVersion");
            migrationBuilder.DropForeignKey(name: "FK_SkillVersion_Skill_SkillId", table: "SkillVersion");
            migrationBuilder.DropTable("Qualification");
            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceSkill_Experience_ExperienceId",
                table: "ExperienceSkill",
                column: "ExperienceId",
                principalTable: "Experience",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceSkill_Skill_SkillId",
                table: "ExperienceSkill",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ExperienceSkillVersion_SkillVersion_SkillVersionId",
                table: "ExperienceSkillVersion",
                column: "SkillVersionId",
                principalTable: "SkillVersion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ProjectImage_Project_ProjectId",
                table: "ProjectImage",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSkill_Project_ProjectId",
                table: "ProjectSkill",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSkill_Skill_SkillId",
                table: "ProjectSkill",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSkillVersion_SkillVersion_SkillVersionId",
                table: "ProjectSkillVersion",
                column: "SkillVersionId",
                principalTable: "SkillVersion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_SkillVersion_Skill_SkillId",
                table: "SkillVersion",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
