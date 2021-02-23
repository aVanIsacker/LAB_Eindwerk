using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactNr = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BTWnr = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    Straat = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Postcode = table.Column<int>(nullable: false),
                    Gemeente = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactNr);
                });

            migrationBuilder.CreateTable(
                name: "FactuurType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    FactuurTypeName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactuurType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeBetaling",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    BetalingsType = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeBetaling", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Klant",
                columns: table => new
                {
                    KlantNr = table.Column<int>(nullable: false),
                    Voornaam = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Familienaam = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klant", x => x.KlantNr);
                    table.ForeignKey(
                        name: "FK_Klant_Contact_KlantNr",
                        column: x => x.KlantNr,
                        principalTable: "Contact",
                        principalColumn: "ContactNr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Leverancier",
                columns: table => new
                {
                    LeverancierNr = table.Column<int>(nullable: false),
                    NaamBedrijf = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leverancier", x => x.LeverancierNr);
                    table.ForeignKey(
                        name: "FK_Leverancier_Contact_LeverancierNr",
                        column: x => x.LeverancierNr,
                        principalTable: "Contact",
                        principalColumn: "ContactNr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Factuur",
                columns: table => new
                {
                    FactuurNr = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(nullable: false),
                    Bedrag = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    BTWTarief = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Status = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Omschrijving = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    FactuurDatum = table.Column<DateTime>(type: "datetime", nullable: false),
                    BetaalDatum = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factuur", x => x.FactuurNr);
                    table.ForeignKey(
                        name: "FK_Factuur_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "ContactNr",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factuur_FactuurType_Type",
                        column: x => x.Type,
                        principalTable: "FactuurType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KasVerrichting",
                columns: table => new
                {
                    KasNr = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactuurNr = table.Column<int>(nullable: true),
                    TypeBetalingId = table.Column<int>(nullable: false),
                    BedragExcl = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    BTWTarief = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KasVerrichting", x => x.KasNr);
                    table.ForeignKey(
                        name: "FK_KasVerrichting_Factuur_FactuurNr",
                        column: x => x.FactuurNr,
                        principalTable: "Factuur",
                        principalColumn: "FactuurNr",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KasVerrichting_TypeBetaling_TypeBetalingId",
                        column: x => x.TypeBetalingId,
                        principalTable: "TypeBetaling",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "ContactNr", "BTWnr", "Gemeente", "Postcode", "Straat" },
                values: new object[,]
                {
                    { 1, "", "Halle", 1500, "Nijvelsesteenweg 346" },
                    { 2, "0123456472", "Etterbeek", 1040, "Biesputstraat 24" },
                    { 3, "1234564890", "Kontich", 2550, "Prins Boudewijnlaan 95" },
                    { 4, "", "Izegem", 8870, "Roeselaarsestraat 282" },
                    { 5, "00014578441", "Brussel", 1060, "Frankrijkstraat 85" },
                    { 6, "0008965321", "Brussel", 1030, "Koning Albert II-laan 27.B" },
                    { 7, "00077638903", "Roeselare", 8800, "Ter Reigerie 1" },
                    { 8, "0008965321", "Sint-Niklaas", 9100, "Industriepark-Noord 28.A 2" }
                });

            migrationBuilder.InsertData(
                table: "FactuurType",
                columns: new[] { "Id", "FactuurTypeName" },
                values: new object[,]
                {
                    { 1, "Verkoop" },
                    { 2, "Aankoop" }
                });

            migrationBuilder.InsertData(
                table: "TypeBetaling",
                columns: new[] { "Id", "BetalingsType" },
                values: new object[,]
                {
                    { 1, "Contant" },
                    { 2, "Bancontact" },
                    { 3, "Overschrijving" }
                });

            migrationBuilder.InsertData(
                table: "Factuur",
                columns: new[] { "FactuurNr", "Bedrag", "BetaalDatum", "BTWTarief", "ContactId", "FactuurDatum", "Omschrijving", "Status", "Type" },
                values: new object[,]
                {
                    { 1, 260m, null, 6m, 1, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tafel", "Open", 1 },
                    { 2, 450m, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 21m, 3, new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Herstoffering", "Betaald", 1 },
                    { 3, 120m, new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6m, 5, new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kast", "Betaald", 2 },
                    { 4, 600m, null, 6m, 6, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Telecom installatie", "Open", 2 }
                });

            migrationBuilder.InsertData(
                table: "Klant",
                columns: new[] { "KlantNr", "Familienaam", "Voornaam" },
                values: new object[,]
                {
                    { 1, "De Smet", "Maria" },
                    { 2, "Peeters", "Arthur" },
                    { 3, "Goossens", "Lucas" },
                    { 4, "Mertens", "Elena" }
                });

            migrationBuilder.InsertData(
                table: "Leverancier",
                columns: new[] { "LeverancierNr", "NaamBedrijf" },
                values: new object[,]
                {
                    { 1, "HR-Rail" },
                    { 2, "Proximus" },
                    { 3, "KBC" },
                    { 4, "Standaard Boekhandel" }
                });

            migrationBuilder.InsertData(
                table: "KasVerrichting",
                columns: new[] { "KasNr", "BedragExcl", "BTWTarief", "FactuurNr", "TypeBetalingId" },
                values: new object[] { 1, 450m, 21m, 2, 1 });

            migrationBuilder.InsertData(
                table: "KasVerrichting",
                columns: new[] { "KasNr", "BedragExcl", "BTWTarief", "FactuurNr", "TypeBetalingId" },
                values: new object[] { 2, 120m, 6m, 3, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Factuur_ContactId",
                table: "Factuur",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Factuur_Type",
                table: "Factuur",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_KasVerrichting_FactuurNr",
                table: "KasVerrichting",
                column: "FactuurNr");

            migrationBuilder.CreateIndex(
                name: "IX_KasVerrichting_TypeBetalingId",
                table: "KasVerrichting",
                column: "TypeBetalingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KasVerrichting");

            migrationBuilder.DropTable(
                name: "Klant");

            migrationBuilder.DropTable(
                name: "Leverancier");

            migrationBuilder.DropTable(
                name: "Factuur");

            migrationBuilder.DropTable(
                name: "TypeBetaling");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "FactuurType");
        }
    }
}
