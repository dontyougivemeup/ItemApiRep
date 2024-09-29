using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItemApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCreatedAtColumn2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Items",
                newName: "Created_at");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "Items",
                newName: "created_at");
        }
    }
}
