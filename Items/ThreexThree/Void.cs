using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.ThreexThree {
    public class Void : ModItem {
        //public override string Texture => "MinecraftPaintings/Items/_Placeholder3x3";

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Void");
            Tooltip.SetDefault("'K. Zetterstrand'");
        }

        public override void SetDefaults() {
            item.width = 28;
            item.height = 28;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 5000;
            item.rare = 0;
            item.createTile = mod.TileType("PaintTile3x3");
            item.placeStyle = 7;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Wood", 8);
            recipe.AddRecipeGroup("MinecraftPaintings:AnyPaint", 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}