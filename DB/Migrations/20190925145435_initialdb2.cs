using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class initialdb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Range",
                table: "Spells",
                unicode: false,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Spells",
                unicode: false,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Components",
                table: "Spells",
                unicode: false,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Casting_Time",
                table: "Spells",
                unicode: false,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Range",
                table: "Spells",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false);

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Spells",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false);

            migrationBuilder.AlterColumn<string>(
                name: "Components",
                table: "Spells",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false);

            migrationBuilder.AlterColumn<string>(
                name: "Casting_Time",
                table: "Spells",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false);
        }
    }
}
