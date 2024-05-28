using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WowLanches.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES('Normal','Lanche feito com ingredientes industrializados')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) " +
                "VALUES('Natural','Lanche feito com ingredientes naturais')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) " +
                "VALUES('Vegano','Lanche feito apenas com ingredientes veganos')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
