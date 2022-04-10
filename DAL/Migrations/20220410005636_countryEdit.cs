using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class countryEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EDescription",
                table: "Countries",
                newName: "Desc_en");

            migrationBuilder.RenameColumn(
                name: "ADescription",
                table: "Countries",
                newName: "Desc_ar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desc_en",
                table: "Countries",
                newName: "EDescription");

            migrationBuilder.RenameColumn(
                name: "Desc_ar",
                table: "Countries",
                newName: "ADescription");
        }
    }
}
