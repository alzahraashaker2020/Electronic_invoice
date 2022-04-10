using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class testing2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ADescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    identification = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ADescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    approach = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    packaging = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    dateValidity = table.Column<DateTime>(type: "datetime", nullable: true),
                    exportPort = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    countryOfOrigin = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    grossWeight = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    netWeight = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    terms = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rate = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    action = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "InputControllers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputControllers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bankName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    bankAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    bankAccountIBAN = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    swiftCode = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    terms = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Taxable_Types",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ADescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxable_Types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Unite_Types",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unite_Types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UniteValues",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    currencySold = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    amountEGP = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    amountSold = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    currencyExchangeRate = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniteValues", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Validation_Types",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Validation_Types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Address_Property",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    type = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    caption = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    controller_id = table.Column<int>(type: "int", nullable: true),
                    hasValidation = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address_Property", x => x.id);
                    table.ForeignKey(
                        name: "FK_Address_Property_Controllers",
                        column: x => x.controller_id,
                        principalTable: "InputControllers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    identification = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    role_id = table.Column<int>(type: "int", nullable: true),
                    signature_id = table.Column<int>(type: "int", nullable: true),
                    activityType_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_ActivityTypes",
                        column: x => x.activityType_id,
                        principalTable: "ActivityTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Roles",
                        column: x => x.role_id,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tax_SubTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ADescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    taxType_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax_SubTypes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tax_SubTypes_Taxable_Types",
                        column: x => x.taxType_id,
                        principalTable: "Taxable_Types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Validations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    hasValue = table.Column<bool>(type: "bit", nullable: true),
                    validationType_id = table.Column<int>(type: "int", nullable: true),
                    controllerNames = table.Column<string>(type: "nvarchar(3900)", maxLength: 3900, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Validations", x => x.id);
                    table.ForeignKey(
                        name: "FK_Validations_Validation_Types",
                        column: x => x.validationType_id,
                        principalTable: "Validation_Types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AddressProperty_Events",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    event_id = table.Column<int>(type: "int", nullable: true),
                    addressProperty_id = table.Column<int>(type: "int", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressProperty_Events", x => x.id);
                    table.ForeignKey(
                        name: "FK_AddressProperty_Events_Address_Property",
                        column: x => x.addressProperty_id,
                        principalTable: "Address_Property",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddressProperty_Events_Events",
                        column: x => x.event_id,
                        principalTable: "Events",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    branch_Id = table.Column<int>(type: "int", nullable: true),
                    address_prop_id = table.Column<int>(type: "int", nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    country_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.id);
                    table.ForeignKey(
                        name: "FK_Address_Address_Property",
                        column: x => x.address_prop_id,
                        principalTable: "Address_Property",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Branches",
                        column: x => x.branch_Id,
                        principalTable: "Branches",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Countries",
                        column: x => x.country_id,
                        principalTable: "Countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Users",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    issuer_id = table.Column<int>(type: "int", nullable: false),
                    receiver_id = table.Column<int>(type: "int", nullable: false),
                    document_type = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    document_type_version = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    dateTime_issued = table.Column<DateTime>(type: "datetime", nullable: false),
                    taxpayer_activ_code = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    internalId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    purchase_order_ref = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    purchase_order_descrip = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    sales_order_ref = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    sales_order_descrip = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    proformaInvoiceNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    payment_id = table.Column<int>(type: "int", nullable: true),
                    delivery_id = table.Column<int>(type: "int", nullable: true),
                    tota_sales_amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    total_disc_amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    net_amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    extra_disc_amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    total_item_disc_amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    total_amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.id);
                    table.ForeignKey(
                        name: "FK_Documents_Delivery",
                        column: x => x.delivery_id,
                        principalTable: "Delivery",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_Payments",
                        column: x => x.payment_id,
                        principalTable: "Payments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_Users",
                        column: x => x.issuer_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_Users1",
                        column: x => x.receiver_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Signature",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    value = table.Column<string>(type: "nchar(500)", fixedLength: true, maxLength: 500, nullable: true),
                    issure_id = table.Column<int>(type: "int", nullable: true),
                    reciever_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signature", x => x.id);
                    table.ForeignKey(
                        name: "FK_Signature_Users",
                        column: x => x.issure_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Signature_Users1",
                        column: x => x.reciever_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AddressProperty_Validations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    validation_id = table.Column<int>(type: "int", nullable: true),
                    addressProperty_id = table.Column<int>(type: "int", nullable: true),
                    value = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressProperty_Validations", x => x.id);
                    table.ForeignKey(
                        name: "FK_AddressProperty_Validations_Address_Property",
                        column: x => x.addressProperty_id,
                        principalTable: "Address_Property",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddressProperty_Validations_Validations",
                        column: x => x.validation_id,
                        principalTable: "Validations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoice_Line",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    itemType = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    itemCode = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    unitType_id = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    unitValue_id = table.Column<int>(type: "int", nullable: true),
                    salesTotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    total = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    valueDifference = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    totalTaxableFees = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    netTotal = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    itemsDiscount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    discount_id = table.Column<int>(type: "int", nullable: true),
                    internalCode = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    document_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice_Line", x => x.id);
                    table.ForeignKey(
                        name: "FK_Invoice_Line_Discounts",
                        column: x => x.discount_id,
                        principalTable: "Discounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_Line_Documents",
                        column: x => x.document_id,
                        principalTable: "Documents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_Line_Unite_Types",
                        column: x => x.unitType_id,
                        principalTable: "Unite_Types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_Line_UniteValues",
                        column: x => x.unitValue_id,
                        principalTable: "UniteValues",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Taxable_Item",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taxType_id = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    subType_id = table.Column<int>(type: "int", nullable: true),
                    rate = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    invoiceLine_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxable_Item", x => x.id);
                    table.ForeignKey(
                        name: "FK_Taxable_Item_Invoice_Line",
                        column: x => x.invoiceLine_id,
                        principalTable: "Invoice_Line",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Taxable_Item_Tax_SubTypes",
                        column: x => x.subType_id,
                        principalTable: "Tax_SubTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Taxable_Item_Taxable_Types",
                        column: x => x.taxType_id,
                        principalTable: "Taxable_Types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_address_prop_id",
                table: "Address",
                column: "address_prop_id");

            migrationBuilder.CreateIndex(
                name: "IX_Address_branch_Id",
                table: "Address",
                column: "branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Address_country_id",
                table: "Address",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_Address_user_id",
                table: "Address",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Address_Property_controller_id",
                table: "Address_Property",
                column: "controller_id");

            migrationBuilder.CreateIndex(
                name: "IX_AddressProperty_Events_addressProperty_id",
                table: "AddressProperty_Events",
                column: "addressProperty_id");

            migrationBuilder.CreateIndex(
                name: "IX_AddressProperty_Events_event_id",
                table: "AddressProperty_Events",
                column: "event_id");

            migrationBuilder.CreateIndex(
                name: "IX_AddressProperty_Validations_addressProperty_id",
                table: "AddressProperty_Validations",
                column: "addressProperty_id");

            migrationBuilder.CreateIndex(
                name: "IX_AddressProperty_Validations_validation_id",
                table: "AddressProperty_Validations",
                column: "validation_id");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_delivery_id",
                table: "Documents",
                column: "delivery_id");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_issuer_id",
                table: "Documents",
                column: "issuer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_payment_id",
                table: "Documents",
                column: "payment_id");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_receiver_id",
                table: "Documents",
                column: "receiver_id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Line_discount_id",
                table: "Invoice_Line",
                column: "discount_id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Line_document_id",
                table: "Invoice_Line",
                column: "document_id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Line_unitType_id",
                table: "Invoice_Line",
                column: "unitType_id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Line_unitValue_id",
                table: "Invoice_Line",
                column: "unitValue_id");

            migrationBuilder.CreateIndex(
                name: "IX_Signature_issure_id",
                table: "Signature",
                column: "issure_id");

            migrationBuilder.CreateIndex(
                name: "IX_Signature_reciever_id",
                table: "Signature",
                column: "reciever_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_SubTypes_taxType_id",
                table: "Tax_SubTypes",
                column: "taxType_id");

            migrationBuilder.CreateIndex(
                name: "IX_Taxable_Item_invoiceLine_id",
                table: "Taxable_Item",
                column: "invoiceLine_id");

            migrationBuilder.CreateIndex(
                name: "IX_Taxable_Item_subType_id",
                table: "Taxable_Item",
                column: "subType_id");

            migrationBuilder.CreateIndex(
                name: "IX_Taxable_Item_taxType_id",
                table: "Taxable_Item",
                column: "taxType_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_activityType_id",
                table: "Users",
                column: "activityType_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_role_id",
                table: "Users",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_Validations_validationType_id",
                table: "Validations",
                column: "validationType_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AddressProperty_Events");

            migrationBuilder.DropTable(
                name: "AddressProperty_Validations");

            migrationBuilder.DropTable(
                name: "Signature");

            migrationBuilder.DropTable(
                name: "Taxable_Item");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Address_Property");

            migrationBuilder.DropTable(
                name: "Validations");

            migrationBuilder.DropTable(
                name: "Invoice_Line");

            migrationBuilder.DropTable(
                name: "Tax_SubTypes");

            migrationBuilder.DropTable(
                name: "InputControllers");

            migrationBuilder.DropTable(
                name: "Validation_Types");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Unite_Types");

            migrationBuilder.DropTable(
                name: "UniteValues");

            migrationBuilder.DropTable(
                name: "Taxable_Types");

            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ActivityTypes");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
