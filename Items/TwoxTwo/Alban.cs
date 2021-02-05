using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.TwoxTwo {
    public class Alban : ModItem {
        //public override string Texture => "MinecraftPaintings/Items/_Placeholder2x2";

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Alban");
            Tooltip.SetDefault("'K. Zetterstrand'");
        }

        public override void SetDefaults() {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 5000;
            item.rare = 0;
            item.createTile = mod.TileType("PaintTile2x2");
            item.placeStyle = 0;
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