using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catolog.Migrations
{
    /// <inheritdoc />
    public partial class InitailCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuizAnswers_QuizAnswers_QuizAnswerId",
                table: "QuizAnswers");

            migrationBuilder.DropIndex(
                name: "IX_QuizAnswers_QuizAnswerId",
                table: "QuizAnswers");

            migrationBuilder.DropColumn(
                name: "QuizAnswerId",
                table: "QuizAnswers");

            migrationBuilder.AddColumn<int>(
                name: "QuizAnswerId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizAnswerId",
                table: "Questions",
                column: "QuizAnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuizAnswers_QuizAnswerId",
                table: "Questions",
                column: "QuizAnswerId",
                principalTable: "QuizAnswers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuizAnswers_QuizAnswerId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuizAnswerId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuizAnswerId",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "QuizAnswerId",
                table: "QuizAnswers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuizAnswers_QuizAnswerId",
                table: "QuizAnswers",
                column: "QuizAnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizAnswers_QuizAnswers_QuizAnswerId",
                table: "QuizAnswers",
                column: "QuizAnswerId",
                principalTable: "QuizAnswers",
                principalColumn: "Id");
        }
    }
}
