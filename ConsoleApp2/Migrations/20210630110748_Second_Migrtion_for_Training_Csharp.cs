using Microsoft.EntityFrameworkCore.Migrations;

namespace Training_Csharp.Migrations
{
    public partial class Second_Migrtion_for_Training_Csharp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMarried",
                table: "Modul_Struct_Bases",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMarried",
                table: "Modul_Struct_Bases");
        }
    }
}
