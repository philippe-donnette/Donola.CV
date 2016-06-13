using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace CV.DataAccessLayer.Migrations
{
    public partial class ProjectSkillVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_ProjectSkill_Project_ProjectId", table: "ProjectSkill");
            migrationBuilder.DropForeignKey(name: "FK_ProjectSkill_Skill_SkillId", table: "ProjectSkill");
            migrationBuilder.DropForeignKey(name: "FK_SkillVersion_Skill_SkillId", table: "SkillVersion");
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
                name: "FK_SkillVersion_Skill_SkillId",
                table: "SkillVersion",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_ProjectSkill_Project_ProjectId", table: "ProjectSkill");
            migrationBuilder.DropForeignKey(name: "FK_ProjectSkill_Skill_SkillId", table: "ProjectSkill");
            migrationBuilder.DropForeignKey(name: "FK_SkillVersion_Skill_SkillId", table: "SkillVersion");
            migrationBuilder.DropTable("ProjectSkillVersion");
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
                name: "FK_SkillVersion_Skill_SkillId",
                table: "SkillVersion",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
