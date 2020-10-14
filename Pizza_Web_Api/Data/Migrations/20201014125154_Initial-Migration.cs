using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    IsDelivered = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pizzas_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    PizzaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PizzaOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PizzaId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PizzaOrder_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PizzaOrder_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientPizza",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IngredientId = table.Column<int>(nullable: false),
                    PizzaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientPizza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientPizza_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientPizza_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "PizzaId", "Price", "Type", "Weight" },
                values: new object[,]
                {
                    { 1, "StandardDoughSmall", null, 50, 1, 50 },
                    { 2, "StandardDoughMedium", null, 80, 1, 60 },
                    { 3, "StandardDoughLarge", null, 110, 1, 70 },
                    { 4, "StandardDoughFamily", null, 150, 1, 80 },
                    { 5, "Peperoni", null, 50, 3, 40 },
                    { 6, "Mushrooms", null, 70, 4, 50 },
                    { 7, "Chedar", null, 110, 2, 60 },
                    { 8, "MozarellaCheese", null, 40, 2, 70 }
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Name", "OrderId", "Price", "Size" },
                values: new object[,]
                {
                    { 8, "DifferentPizza", null, 0, 4 },
                    { 7, "DifferentPizza", null, 0, 3 },
                    { 6, "DifferentPizza", null, 0, 2 },
                    { 5, "DifferentPizza", null, 0, 1 },
                    { 2, "PassionPizza", null, 0, 2 },
                    { 3, "PassionPizza", null, 0, 3 },
                    { 1, "PassionPizza", null, 0, 1 },
                    { 4, "PassionPizza", null, 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Password", "Phone", "Username" },
                values: new object[,]
                {
                    { 2, "Address2", "Goce", "Kabov", "456goce456", 71585969, "GoceK456" },
                    { 1, "Address1", "Vaska", "Vasileva", "123vaska123", 70264353, "Vaska123" },
                    { 3, "Address3", "Darko", "Panchevski", "789dare789", 75742394, "DareP789" }
                });

            migrationBuilder.InsertData(
                table: "IngredientPizza",
                columns: new[] { "Id", "IngredientId", "PizzaId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 22, 2, 6 },
                    { 23, 5, 6 },
                    { 24, 6, 6 },
                    { 25, 7, 6 },
                    { 26, 8, 6 },
                    { 27, 3, 7 },
                    { 28, 5, 7 },
                    { 29, 6, 7 },
                    { 30, 7, 7 },
                    { 31, 8, 7 },
                    { 32, 4, 8 },
                    { 33, 5, 8 },
                    { 34, 6, 8 },
                    { 35, 7, 8 },
                    { 36, 8, 8 },
                    { 20, 7, 5 },
                    { 19, 6, 5 },
                    { 21, 8, 5 },
                    { 17, 1, 5 },
                    { 2, 5, 1 },
                    { 3, 6, 1 },
                    { 4, 8, 1 },
                    { 5, 2, 2 },
                    { 6, 5, 2 },
                    { 7, 6, 2 },
                    { 18, 5, 5 },
                    { 9, 3, 3 },
                    { 8, 8, 2 },
                    { 11, 6, 3 },
                    { 12, 8, 3 },
                    { 13, 4, 4 },
                    { 14, 5, 4 },
                    { 15, 6, 4 },
                    { 16, 8, 4 },
                    { 10, 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "IsDelivered", "UserId" },
                values: new object[,]
                {
                    { 4, false, 3 },
                    { 1, false, 1 },
                    { 2, true, 1 },
                    { 3, false, 2 },
                    { 5, true, 3 }
                });

            migrationBuilder.InsertData(
                table: "PizzaOrder",
                columns: new[] { "Id", "OrderId", "PizzaId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 6 },
                    { 3, 2, 2 },
                    { 4, 3, 2 },
                    { 5, 3, 4 },
                    { 6, 4, 3 },
                    { 7, 4, 7 },
                    { 8, 5, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientPizza_IngredientId",
                table: "IngredientPizza",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientPizza_PizzaId",
                table: "IngredientPizza",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_PizzaId",
                table: "Ingredients",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaOrder_OrderId",
                table: "PizzaOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaOrder_PizzaId",
                table: "PizzaOrder",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_OrderId",
                table: "Pizzas",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientPizza");

            migrationBuilder.DropTable(
                name: "PizzaOrder");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
