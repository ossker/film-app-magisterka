using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace film_app_magisterka.Migrations
{
    public partial class poster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Poster",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1,
                column: "Poster",
                value: "poster_1.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2,
                column: "Poster",
                value: "poster_2.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3,
                column: "Poster",
                value: "poster_3.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4,
                column: "Poster",
                value: "poster_4.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5,
                column: "Poster",
                value: "poster_5.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6,
                column: "Poster",
                value: "poster_6.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7,
                column: "Poster",
                value: "poster_7.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8,
                column: "Poster",
                value: "poster_8.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9,
                column: "Poster",
                value: "poster_9.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10,
                column: "Poster",
                value: "poster_10.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 11,
                column: "Poster",
                value: "poster_11.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 12,
                column: "Poster",
                value: "poster_12.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 13,
                column: "Poster",
                value: "poster_13.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 14,
                column: "Poster",
                value: "poster_14.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 15,
                column: "Poster",
                value: "poster_15.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 16,
                column: "Poster",
                value: "poster_16.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 17,
                column: "Poster",
                value: "poster_17.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 18,
                column: "Poster",
                value: "poster_18.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 19,
                column: "Poster",
                value: "poster_19.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 20,
                column: "Poster",
                value: "poster_20.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Poster",
                table: "Films");
        }
    }
}
