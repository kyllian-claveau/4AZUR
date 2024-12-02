using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinkUp.API.Migrations
{
    /// <inheritdoc />
    public partial class AddIsPrivateToApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPrivateProfile",
                table: "AspNetUsers",
                newName: "IsPrivate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPrivate",
                table: "AspNetUsers",
                newName: "IsPrivateProfile");
        }
    }
}
