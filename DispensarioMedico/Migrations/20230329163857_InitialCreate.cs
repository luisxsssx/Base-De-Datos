using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DispensarioMedico.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FechaConsulta = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PacienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    DoctorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Temperatura = table.Column<double>(type: "REAL", nullable: false),
                    Oxigenacion = table.Column<double>(type: "REAL", nullable: false),
                    Peso = table.Column<double>(type: "REAL", nullable: false),
                    Estatura = table.Column<double>(type: "REAL", nullable: false),
                    Presion = table.Column<string>(type: "TEXT", nullable: false),
                    Sintomas = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Diagnostico = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CedulaProfesional = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Especialidad = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Presentacion = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Genero = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoDeSangre = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    FechaDeNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Alergias = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecetaMedicamentos",
                columns: table => new
                {
                    RecetaId = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicamentoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Dosis = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecetaMedicamentos", x => new { x.RecetaId, x.MedicamentoId });
                });

            migrationBuilder.CreateTable(
                name: "Recetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ConsultaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Dosis = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recetas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Medicamentos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "RecetaMedicamentos");

            migrationBuilder.DropTable(
                name: "Recetas");
        }
    }
}
