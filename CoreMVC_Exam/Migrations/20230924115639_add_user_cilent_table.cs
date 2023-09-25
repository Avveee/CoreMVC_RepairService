using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVC_Exam.Migrations
{
    /// <inheritdoc />
    public partial class add_user_cilent_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersClients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    passport_id = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersClients", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersClients");
        }
    }
}
