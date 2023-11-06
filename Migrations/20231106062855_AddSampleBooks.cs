using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCatalog.Migrations
{
    /// <inheritdoc />
    public partial class AddSampleBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Title", "Author", "ISBN" },
                values: new object[] { "Sample Book 1", "Author 1", "ISBN123" }
            );

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Title", "Author", "ISBN" },
                values: new object[] { "Sample Book 2", "Author 2", "ISBN456" }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
