using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogAdoptionWebsite.Migrations
{
    /// <inheritdoc />
    public partial class userandregisterupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CurrentNumberOfPets",
                table: "User");

            migrationBuilder.DropColumn(
                name: "EmploymentStatus",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Dog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeePhoneNumber",
                table: "AdoptionForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PetAge",
                table: "AdoptionForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PetBreed",
                table: "AdoptionForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PetName",
                table: "AdoptionForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeePhoneNumber",
                table: "AdoptionForm");

            migrationBuilder.DropColumn(
                name: "PetAge",
                table: "AdoptionForm");

            migrationBuilder.DropColumn(
                name: "PetBreed",
                table: "AdoptionForm");

            migrationBuilder.DropColumn(
                name: "PetName",
                table: "AdoptionForm");

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CurrentNumberOfPets",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmploymentStatus",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Dog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
