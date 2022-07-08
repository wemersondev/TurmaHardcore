using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AulaUmTurmaH.Infra.Migrations
{
    public partial class RelacionamentoCoordenadorEscola : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Escolas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "EscolaId",
                table: "Coordenadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Coordenadores_EscolaId",
                table: "Coordenadores",
                column: "EscolaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordenadores_Escolas_EscolaId",
                table: "Coordenadores",
                column: "EscolaId",
                principalTable: "Escolas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordenadores_Escolas_EscolaId",
                table: "Coordenadores");

            migrationBuilder.DropIndex(
                name: "IX_Coordenadores_EscolaId",
                table: "Coordenadores");

            migrationBuilder.DropColumn(
                name: "EscolaId",
                table: "Coordenadores");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Escolas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }
    }
}
