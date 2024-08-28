using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2024, 8, 27, 23, 51, 4, 971, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d9eaade-8257-43d8-9680-50d2ee1a344f", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "627dc222-7e37-436c-9281-e8e282ad65e2", 0, "242614c2-a479-4179-8855-d99eb7b44e07", "admin@tunify.com", true, false, null, "ADMIN@TUNIFY.COM", "ADMIN", "AQAAAAIAAYagAAAAEA3zCtKNDRCeXUTkO6pfu5zhrfSAKGwG7JGllO1hYzjhiNDUAeDiBK6ZVdfx0UvwGQ==", null, false, "0c5f1f3e-5dc5-4bb3-a94f-1e308fd98f02", false, "admin" });

            migrationBuilder.UpdateData(
                table: "ModelUsers",
                keyColumn: "ModelUserID",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2024, 8, 27, 23, 51, 4, 971, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "ModelUsers",
                keyColumn: "ModelUserID",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2024, 8, 27, 23, 51, 4, 971, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "PlaylistID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 27, 23, 51, 4, 971, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "PlaylistID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 27, 23, 51, 4, 971, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9d9eaade-8257-43d8-9680-50d2ee1a344f", "627dc222-7e37-436c-9281-e8e282ad65e2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d9eaade-8257-43d8-9680-50d2ee1a344f", "627dc222-7e37-436c-9281-e8e282ad65e2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d9eaade-8257-43d8-9680-50d2ee1a344f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "627dc222-7e37-436c-9281-e8e282ad65e2");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2024, 8, 24, 10, 55, 25, 196, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "ModelUsers",
                keyColumn: "ModelUserID",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2024, 8, 24, 10, 55, 25, 196, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "ModelUsers",
                keyColumn: "ModelUserID",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2024, 8, 24, 10, 55, 25, 196, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "PlaylistID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 24, 10, 55, 25, 196, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "PlaylistID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 24, 10, 55, 25, 196, DateTimeKind.Local).AddTicks(5267));
        }
    }
}
