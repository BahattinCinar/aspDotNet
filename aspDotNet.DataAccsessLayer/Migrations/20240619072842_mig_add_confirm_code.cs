using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspDotNet.DataAccsessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_confirm_code : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "appUserConfirmCode",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "appUserConfirmCode",
                table: "AspNetUsers");
        }
    }
}
