using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace CV.DataAccessLayer.Migrations
{
    public partial class PrimaryImage_In_Project_String : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_ProjectSkill_Project_ProjectId", table: "ProjectSkill");
            migrationBuilder.DropForeignKey(name: "FK_ProjectSkill_Skill_SkillId", table: "ProjectSkill");
            migrationBuilder.DropForeignKey(name: "FK_SkillVersion_Skill_SkillId", table: "SkillVersion");
            migrationBuilder.AlterColumn<string>(
                name: "PrimaryImage",
                table: "Project",
                nullable: true);
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
            migrationBuilder.AlterColumn<byte[]>(
                name: "PrimaryImage",
                table: "Project",
                nullable: true);
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
