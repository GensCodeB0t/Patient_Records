using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Patient_Records.Data.Migrations
{
    public partial class RobotDoctors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Human",
                table: "Human");

            migrationBuilder.RenameTable(
                name: "Human",
                newName: "Humans");

            migrationBuilder.AlterColumn<string>(
                name: "SocialSecurityNumber",
                table: "Humans",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RobotDoctorId",
                table: "Humans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Humans",
                table: "Humans",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "RobotDoctors",
                columns: table => new
                {
                    RobotDoctorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ModelNumber = table.Column<int>(nullable: false),
                    PreferredName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RobotDoctors", x => x.RobotDoctorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Humans_RobotDoctorId",
                table: "Humans",
                column: "RobotDoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Humans_RobotDoctors_RobotDoctorId",
                table: "Humans",
                column: "RobotDoctorId",
                principalTable: "RobotDoctors",
                principalColumn: "RobotDoctorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Humans_RobotDoctors_RobotDoctorId",
                table: "Humans");

            migrationBuilder.DropTable(
                name: "RobotDoctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Humans",
                table: "Humans");

            migrationBuilder.DropIndex(
                name: "IX_Humans_RobotDoctorId",
                table: "Humans");

            migrationBuilder.DropColumn(
                name: "RobotDoctorId",
                table: "Humans");

            migrationBuilder.RenameTable(
                name: "Humans",
                newName: "Human");

            migrationBuilder.AlterColumn<string>(
                name: "SocialSecurityNumber",
                table: "Human",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Human",
                table: "Human",
                column: "ID");
        }
    }
}
