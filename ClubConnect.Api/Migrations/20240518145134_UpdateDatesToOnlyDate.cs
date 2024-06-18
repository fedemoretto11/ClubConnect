using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace ClubConnect.Api.Migrations
{
	public partial class UpdateDatesToOnlyDate : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			// Actualizar los registros existentes para eliminar la hora
			migrationBuilder.Sql(
				@"UPDATE Socios 
                  SET FechaDeNacimiento = CAST(FechaDeNacimiento AS date), 
                      FechaDeRegistro = CAST(FechaDeRegistro AS date)");

			// Alterar las columnas para cambiar el tipo a date
			migrationBuilder.AlterColumn<DateTime>(
				name: "FechaDeNacimiento",
				table: "Socios",
				type: "date",
				nullable: false,
				oldClrType: typeof(DateTime),
				oldType: "datetime2");

			migrationBuilder.AlterColumn<DateTime>(
				name: "FechaDeRegistro",
				table: "Socios",
				type: "date",
				nullable: false,
				oldClrType: typeof(DateTime),
				oldType: "datetime2");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			// Revertir las columnas a datetime2
			migrationBuilder.AlterColumn<DateTime>(
				name: "FechaDeNacimiento",
				table: "Socios",
				type: "datetime2",
				nullable: false,
				oldClrType: typeof(DateTime),
				oldType: "date");

			migrationBuilder.AlterColumn<DateTime>(
				name: "FechaDeRegistro",
				table: "Socios",
				type: "datetime2",
				nullable: false,
				oldClrType: typeof(DateTime),
				oldType: "date");
		}
	}
}
