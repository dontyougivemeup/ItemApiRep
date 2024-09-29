using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItemApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateItemModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Rename the column if necessary
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Items",
                newName: "created_at");

            // Set the default value for created_at to the current timestamp
            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "Items",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP", // Set default value in the database
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone"); // Update this if your column type is different
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Reverse the rename operation
            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Items",
                newName: "CreatedAt");

            // Restore the old column type and remove the default value
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Items",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                defaultValueSql: "CURRENT_TIMESTAMP"); // Ensure this matches your previous setup
        }
    }
}
