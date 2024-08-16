using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class iniit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2024, 8, 16, 16, 29, 59, 2, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "PlaylistID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 16, 29, 59, 2, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "PlaylistID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 16, 16, 29, 59, 2, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2024, 8, 16, 16, 29, 59, 2, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2024, 8, 16, 16, 29, 59, 2, DateTimeKind.Local).AddTicks(6723));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2024, 8, 9, 19, 56, 50, 632, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "PlaylistID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 9, 19, 56, 50, 632, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "PlaylistID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 9, 19, 56, 50, 632, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2024, 8, 9, 19, 56, 50, 632, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2024, 8, 9, 19, 56, 50, 632, DateTimeKind.Local).AddTicks(779));
        }
    }
}
