using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace filterandsearchdemo.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empolyees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    performance = table.Column<int>(type: "int", nullable: false),
                    occuapation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empolyees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empolyees_Departmentes_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departmentes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empolyees_DepartmentId",
                table: "Empolyees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empolyees");

            migrationBuilder.DropTable(
                name: "Departmentes");
        }
    }
}
