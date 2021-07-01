using Microsoft.EntityFrameworkCore.Migrations;

namespace Training_Csharp.Migrations
{
    public partial class First_Migrtion_for_Training_Csharp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modul_Struct_Bases_1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameInfo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameCreate1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameCreate2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameCreate3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameCreate4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameCreate5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameTasks3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameExamples1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameExamples2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameExamples3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameExamples4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameExamples5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationInfo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationCreate1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationCreate2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationCreate3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationCreate4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationCreate5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationTasks1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationTasks2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationTasks3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationTasks4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationTasks5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationExamples1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationExamples2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationExamples3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationExamples4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationExamples5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationExamples6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationExamples7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateCreate1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateCreate2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateCreate3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateCreate4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateCreate5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateCreate6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateExamples1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateExamples2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateExamples3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateExamples4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateExamples5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateExamples6 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modul_Struct_Bases_1", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Modul_Struct_Bases_1");
        }
    }
}
