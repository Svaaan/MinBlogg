using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinBlogg.Migrations
{
    /// <inheritdoc />
    public partial class foreignkeytoall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogPostId",
                table: "comments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "blogPosts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "blogPosts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogPostId",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "blogPosts");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "blogPosts");
        }
    }
}
