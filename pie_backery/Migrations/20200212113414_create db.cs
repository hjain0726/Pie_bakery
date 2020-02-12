using Microsoft.EntityFrameworkCore.Migrations;

namespace pie_backery.Migrations
{
    public partial class createdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Fruit pies", "All-fruity pies" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Cheese cakes", "All-cheesey pies" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Seasonal Pies", "All-seasonal pies" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "Instock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { "1", null, 1, "https://media.istockphoto.com/photos/whole-cherry-pie-picture-id535475493?k=6&m=535475493&s=612x612&w=0&h=yyG800xq7-noeZMUuCcSvieN_Pq7k_hY6y7AbISmz-s=", "https://media.istockphoto.com/photos/whole-cherry-pie-picture-id535475493?k=6&m=535475493&s=612x612&w=0&h=yyG800xq7-noeZMUuCcSvieN_Pq7k_hY6y7AbISmz-s=", true, true, "Long long description", "Strawberry Pie", 15.95m, "Lorem Ipsum" },
                    { "3", null, 1, "https://ichef.bbci.co.uk/food/ic/food_16x9_832/recipes/chicken_pie_24044_16x9.jpg", "https://ichef.bbci.co.uk/food/ic/food_16x9_832/recipes/chicken_pie_24044_16x9.jpg", false, true, "Long long description", "Rhubarb Pie", 11.95m, "Lorem Ipsum" },
                    { "2", null, 2, "https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg", "https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg", true, false, "Long long description", "Cheese Cake", 10.95m, "Lorem Ipsum" },
                    { "4", null, 3, "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2009/6/15/0/JI_20731_s4x3.jpg.rend.hgtvcom.826.620.suffix/1371589402748.jpeg", "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2009/6/15/0/JI_20731_s4x3.jpg.rend.hgtvcom.826.620.suffix/1371589402748.jpeg", true, false, "Long long description", "Pumpkin Pie", 12.95m, "Lorem Ipsum" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
