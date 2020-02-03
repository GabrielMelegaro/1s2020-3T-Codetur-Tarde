using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Senai.CodeTur.Infra.Data.Migrations
{
    public partial class criarpacote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "varchar(150)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(150)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(400)", nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    País = table.Column<string>(type: "varchar(150)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Oferta = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacotes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pacotes",
                columns: new[] { "Id", "DataFim", "DataInicio", "Descricao", "Imagem", "Oferta", "País", "Status", "Titulo" },
                values: new object[] { 1, new DateTime(2020, 1, 25, 17, 6, 59, 383, DateTimeKind.Local), new DateTime(2020, 1, 22, 17, 6, 59, 382, DateTimeKind.Local), "O Texas, é uma dos estados mais quentes do Estados Unidos, Terra do Bacon", "https://a.travel-assets.com/findyours-php/viewfinder/images/res10/332000/332960-Dallas.jpg", true, "EUA", true, "Pacote Especial : Texas" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacotes");
        }
    }
}
