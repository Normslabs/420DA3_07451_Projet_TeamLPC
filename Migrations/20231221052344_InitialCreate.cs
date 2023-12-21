using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _420DA3_07451_Projet_Initial.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ville = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    NumeroCivique = table.Column<string>(type: "nvarchar(8)", nullable: false),
                    Pays = table.Column<string>(type: "nvarchar(42)", nullable: false),
                    CodePostal = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(38)", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    Rue = table.Column<string>(type: "nvarchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entrepot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomEntrepot = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    AdresseId = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrepot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entrepot_Adresse_AdresseId",
                        column: x => x.AdresseId,
                        principalTable: "Adresse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fournisseurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomFournisseur = table.Column<string>(type: "nvarchar(100", nullable: false),
                    AdresseId = table.Column<int>(type: "int", nullable: false),
                    PrenomContact = table.Column<string>(type: "nvarchar(20", nullable: false),
                    NomContact = table.Column<string>(type: "nvarchar(20", nullable: false),
                    TelephoneContact = table.Column<string>(type: "nvarchar(24", nullable: false),
                    EmailContact = table.Column<string>(type: "nvarchar(128", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fournisseurs_Adresse_AdresseId",
                        column: x => x.AdresseId,
                        principalTable: "Adresse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsignedWarehouseID = table.Column<int>(type: "int", nullable: false),
                    ClientAdressId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(24)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(24)", nullable: false),
                    Courriel = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    Telephone = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Adresse_ClientAdressId",
                        column: x => x.ClientAdressId,
                        principalTable: "Adresse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Entrepot_AsignedWarehouseID",
                        column: x => x.AsignedWarehouseID,
                        principalTable: "Entrepot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(32)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    EntrepotId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2(7)", nullable: false, defaultValueSql: "getdate()"),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utilisateurs_Entrepot_EntrepotId",
                        column: x => x.EntrepotId,
                        principalTable: "Entrepot",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(128)", nullable: true),
                    DoAutoRestock = table.Column<bool>(type: "bit", nullable: false),
                    InstockQuantity = table.Column<int>(type: "int", nullable: false),
                    TargetStockQuantity = table.Column<int>(type: "int", nullable: false),
                    SupplierCode = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    UpcCode = table.Column<long>(type: "bigint", nullable: false),
                    WeightInKg = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    ClientsDTOId = table.Column<int>(type: "int", nullable: false),
                    DournisseurId = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produits_Clients_ClientsDTOId",
                        column: x => x.ClientsDTOId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produits_Fournisseurs_DournisseurId",
                        column: x => x.DournisseurId,
                        principalTable: "Fournisseurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUtilisateur",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    UtilisateursPossedantRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUtilisateur", x => new { x.RolesId, x.UtilisateursPossedantRoleId });
                    table.ForeignKey(
                        name: "FK_RoleUtilisateur_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUtilisateur_Utilisateurs_UtilisateursPossedantRoleId",
                        column: x => x.UtilisateursPossedantRoleId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ClientsId = table.Column<int>(type: "int", nullable: false),
                    EntrepotOriginalId = table.Column<int>(type: "int", nullable: false),
                    EmployeEntrepotId = table.Column<int>(type: "int", nullable: true),
                    ShipmentId = table.Column<int>(type: "int", nullable: true),
                    DestinationCivicAdress = table.Column<string>(type: "nvarchar(48)", nullable: false),
                    DestinationContact = table.Column<string>(type: "nvarchar(48)", nullable: false),
                    DestinationPostalCode = table.Column<string>(type: "nvarchar(7)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(7)", nullable: false, computedColumnSql: "getdate()"),
                    DateShipped = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipmentOrder_Clients_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipmentOrder_Entrepot_EntrepotOriginalId",
                        column: x => x.EntrepotOriginalId,
                        principalTable: "Entrepot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipmentOrder_Utilisateurs_EmployeEntrepotId",
                        column: x => x.EmployeEntrepotId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(16)", nullable: true),
                    QuantityOrdered = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DestinationWarehouseID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(7)", nullable: false, computedColumnSql: "getdate()"),
                    DateCompleted = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Entrepot_DestinationWarehouseID",
                        column: x => x.DestinationWarehouseID,
                        principalTable: "Entrepot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Produits_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Produits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Service = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Trackingnumber = table.Column<string>(name: "Tracking number", type: "nvarchar(15)", nullable: true),
                    ShippingOrderId = table.Column<int>(type: "int", nullable: true),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipments_ShipmentOrder_ShippingOrderId",
                        column: x => x.ShippingOrderId,
                        principalTable: "ShipmentOrder",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShippingOrderProducts",
                columns: table => new
                {
                    ProduitId = table.Column<int>(type: "int", nullable: false),
                    ShipmentOrderDTOId = table.Column<int>(type: "int", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingOrderProducts", x => new { x.ProduitId, x.ShipmentOrderDTOId });
                    table.ForeignKey(
                        name: "FK_ShippingOrderProducts_Produits_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShippingOrderProducts_ShipmentOrder_ShipmentOrderDTOId",
                        column: x => x.ShipmentOrderDTOId,
                        principalTable: "ShipmentOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adresse",
                columns: new[] { "Id", "CodePostal", "NumeroCivique", "Pays", "Province", "Rue", "Ville" },
                values: new object[,]
                {
                    { 1, "H0H0H0", "5A", "Cehnehdeh", "Quebec", "rue Saint-Laurent", "Montréal" },
                    { 2, "H0H0H0", "55A", "Cehnehdeh", "Quebec", "rue Saint-Laurent", "Montréal" },
                    { 3, "H0H0H0", "555A", "Cehnehdeh", "Quebec", "rue Saint-Laurent", "Montréal" },
                    { 4, "H0H0H0", "1A", "Cehnehdeh", "Quebec", "rue Saint-Laurent", "Montréal" },
                    { 5, "H0H0H0", "11A", "Cehnehdeh", "Quebec", "rue Saint-Laurent", "Montréal" },
                    { 6, "H0H0H0", "111A", "Cehnehdeh", "Quebec", "rue Saint-Laurent", "Montréal" }
                });

            migrationBuilder.InsertData(
                table: "Entrepot",
                columns: new[] { "Id", "AdresseId", "NomEntrepot" },
                values: new object[] { 1, 1, "Entrepot Test" });

            migrationBuilder.InsertData(
                table: "Fournisseurs",
                columns: new[] { "Id", "AdresseId", "EmailContact", "NomContact", "PrenomContact", "NomFournisseur", "TelephoneContact" },
                values: new object[] { 1, 4, "john.doe@fournisseur.net", "Doe", "John", "Fournisseur Test 1", "5145555555" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AsignedWarehouseID", "ClientAdressId", "CompanyName", "Courriel", "Nom", "Prenom", "Telephone" },
                values: new object[,]
                {
                    { 1, 1, 4, "Client Test 1", "john.doe@client.net", "Doe", "John", 5145555555L },
                    { 2, 1, 5, "Normslabs Entertainment Inc.", "ze.norm@client.net", "Norm", "Ze", 5145551234L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AsignedWarehouseID",
                table: "Clients",
                column: "AsignedWarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ClientAdressId",
                table: "Clients",
                column: "ClientAdressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entrepot_AdresseId",
                table: "Entrepot",
                column: "AdresseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fournisseurs_AdresseId",
                table: "Fournisseurs",
                column: "AdresseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produits_ClientsDTOId",
                table: "Produits",
                column: "ClientsDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_DournisseurId",
                table: "Produits",
                column: "DournisseurId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_DestinationWarehouseID",
                table: "PurchaseOrders",
                column: "DestinationWarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_ProductId",
                table: "PurchaseOrders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUtilisateur_UtilisateursPossedantRoleId",
                table: "RoleUtilisateur",
                column: "UtilisateursPossedantRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentOrder_ClientsId",
                table: "ShipmentOrder",
                column: "ClientsId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentOrder_EmployeEntrepotId",
                table: "ShipmentOrder",
                column: "EmployeEntrepotId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentOrder_EntrepotOriginalId",
                table: "ShipmentOrder",
                column: "EntrepotOriginalId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_ShippingOrderId",
                table: "Shipments",
                column: "ShippingOrderId",
                unique: true,
                filter: "[ShippingOrderId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingOrderProducts_ShipmentOrderDTOId",
                table: "ShippingOrderProducts",
                column: "ShipmentOrderDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_EntrepotId",
                table: "Utilisateurs",
                column: "EntrepotId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_Username",
                table: "Utilisateurs",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "RoleUtilisateur");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "ShippingOrderProducts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Produits");

            migrationBuilder.DropTable(
                name: "ShipmentOrder");

            migrationBuilder.DropTable(
                name: "Fournisseurs");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Entrepot");

            migrationBuilder.DropTable(
                name: "Adresse");
        }
    }
}
