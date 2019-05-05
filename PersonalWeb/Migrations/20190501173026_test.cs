using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalWeb.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "edus",
                columns: table => new
                {
                    EduId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    SchoolName = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    FromYear = table.Column<int>(nullable: false),
                    FromMonth = table.Column<int>(nullable: false),
                    FromDay = table.Column<int>(nullable: false),
                    ToYear = table.Column<int>(nullable: true),
                    ToMonth = table.Column<int>(nullable: true),
                    ToDay = table.Column<int>(nullable: true),
                    Major = table.Column<string>(nullable: true),
                    ReleventCourses = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edus", x => x.EduId);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    ProjectName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FromYear = table.Column<int>(nullable: false),
                    FromMonth = table.Column<int>(nullable: false),
                    FromDay = table.Column<int>(nullable: false),
                    ToYear = table.Column<int>(nullable: true),
                    ToMonth = table.Column<int>(nullable: true),
                    ToDay = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "works",
                columns: table => new
                {
                    WorkId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Responsibility = table.Column<string>(nullable: true),
                    FromYear = table.Column<int>(nullable: false),
                    FromMonth = table.Column<int>(nullable: false),
                    FromDay = table.Column<int>(nullable: false),
                    ToYear = table.Column<int>(nullable: true),
                    ToMonth = table.Column<int>(nullable: true),
                    ToDay = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_works", x => x.WorkId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "edus");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "works");
        }
    }
}
