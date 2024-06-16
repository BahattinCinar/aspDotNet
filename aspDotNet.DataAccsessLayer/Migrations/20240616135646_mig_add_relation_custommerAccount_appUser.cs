using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspDotNet.DataAccsessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_relation_custommerAccount_appUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "CustommerAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustommerAccounts_AppUserId",
                table: "CustommerAccounts",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustommerAccounts_AspNetUsers_AppUserId",
                table: "CustommerAccounts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustommerAccounts_AspNetUsers_AppUserId",
                table: "CustommerAccounts");

            migrationBuilder.DropIndex(
                name: "IX_CustommerAccounts_AppUserId",
                table: "CustommerAccounts");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "CustommerAccounts");
        }
    }
}
