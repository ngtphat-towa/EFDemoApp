using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDemo.DataAccessLibrary.Migrations
{
    /// <inheritdoc />
    public partial class Fix_Typo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_People_PersonId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailAressess_People_PersonId",
                table: "EmailAressess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmailAressess",
                table: "EmailAressess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adresses",
                table: "Adresses");

            migrationBuilder.RenameTable(
                name: "EmailAressess",
                newName: "EmailAddresses");

            migrationBuilder.RenameTable(
                name: "Adresses",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_EmailAressess_PersonId",
                table: "EmailAddresses",
                newName: "IX_EmailAddresses_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_PersonId",
                table: "Addresses",
                newName: "IX_Addresses_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmailAddresses",
                table: "EmailAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_People_PersonId",
                table: "Addresses",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddresses_People_PersonId",
                table: "EmailAddresses",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_People_PersonId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddresses_People_PersonId",
                table: "EmailAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmailAddresses",
                table: "EmailAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "EmailAddresses",
                newName: "EmailAressess");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Adresses");

            migrationBuilder.RenameIndex(
                name: "IX_EmailAddresses_PersonId",
                table: "EmailAressess",
                newName: "IX_EmailAressess_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_PersonId",
                table: "Adresses",
                newName: "IX_Adresses_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmailAressess",
                table: "EmailAressess",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adresses",
                table: "Adresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_People_PersonId",
                table: "Adresses",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAressess_People_PersonId",
                table: "EmailAressess",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }
    }
}
