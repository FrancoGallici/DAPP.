using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Casting_Time = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Components = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(unicode: false, nullable: false),
                    Duration = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Level = table.Column<int>(unicode: false, maxLength: 2, nullable: false),
                    Range = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    School = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spells");
        }
    }
}
