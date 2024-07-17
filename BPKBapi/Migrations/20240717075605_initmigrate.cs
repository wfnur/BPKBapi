using System;
using System.Numerics;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BPKBapi.Migrations
{
    /// <inheritdoc />
    public partial class initmigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ms_storage_locations",
                columns: table => new
                {
                    location_id = table.Column<string>(type: "varchar(10)", nullable: false),
                    location_name = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ms_storage_locations", x => x.location_id);
                });

            migrationBuilder.CreateTable(
                name: "tr_bpkb",
                columns: table => new
                {
                    agreement_number = table.Column<string>(type: "varchar(100)", nullable: false),
                    bpkb_no = table.Column<string>(type: "varchar(100)", nullable: false),
                    branch_id = table.Column<string>(type: "varchar(10)", nullable: false),
                    bpkb_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    faktur_no = table.Column<string>(type: "varchar(100)", nullable: false),
                    faktur_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    location_id = table.Column<string>(type: "varchar(10)", nullable: false),
                    police_no = table.Column<string>(type: "varchar(20)", nullable: false),
                    bpkb_date_in = table.Column<DateTime>(type: "datetime", nullable: false),
                    created_by = table.Column<string>(type: "varchar(20)", nullable: false),
                    last_updated_by = table.Column<string>(type: "varchar(20)", nullable: false),
                    created_on = table.Column<DateTime>(type: "datetime", nullable: false),
                    last_updated_on = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tr_bpkb", x => x.agreement_number);
                });

            migrationBuilder.CreateTable(
                name: "ms_user",
                columns: table => new
                {
                    user_id = table.Column<BigInteger>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.user_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ms_storage_locations");

            migrationBuilder.DropTable(
                name: "ms_user");

            migrationBuilder.DropTable(
                name: "tr_bpkb");
        }
    }
}
