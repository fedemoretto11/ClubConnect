using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubConnect.Api.Migrations
{
    public partial class ConvertEnumsToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EstaActivo",
                table: "Socios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Categoria",
                table: "Socios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.Sql(@"
                UPDATE Socios
                SET EstaActivo = CASE EstaActivo
                WHEN 0 THEN 'SI'
                WHEN 1 THEN 'NO'
                END,
                Categoria = CASE Categoria
                    WHEN 0 THEN 'ACTIVO_SIMPLE'
                    WHEN 1 THEN 'ACTIVO_PLENO'
                    WHEN 2 THEN 'VITALICIO'
                END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EstaActivo",
                table: "Socios",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Categoria",
                table: "Socios",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

			migrationBuilder.Sql(@"
            UPDATE Socios
            SET EstaActivo = CASE EstaActivo
                WHEN 'SI' THEN 0
                WHEN 'NO' THEN 1
            END,
            Categoria = CASE Categoria
                WHEN 'ACTIVO_SIMPLE' THEN 0
                WHEN 'ACTIVO_PLENO' THEN 1
                WHEN 'VITALICIO' THEN 2
            END");
		}
    }
}
