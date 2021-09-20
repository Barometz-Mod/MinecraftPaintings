using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using MinecraftPaintings.Tiles;

namespace MinecraftPaintings.Items {
    public abstract class MCPaintingItem : ModItem {

        /// <summary>
        /// Defines the mod tile that should be referenced, as well as the item size.
        /// Defaults to 0 (2x2).
        /// </summary>
        public virtual MCPaintingType PaintingType => MCPaintingType.TwoByTwo;

        /// <summary>
        /// Defines the tile place style of the painting.
        /// Defaults to 0.
        /// </summary>
        public int PaintingPlaceStyle { get; protected set; }

        public string DefaultTooltip => "'K. Zetterstrand'";

        /////////////////////////

        public sealed override void SetStaticDefaults() {
            SafeSetStaticDefaults();
        }

        public virtual void SafeSetStaticDefaults() {

        }

        public sealed override void SetDefaults() {
            SafeSetDefaults();

            switch (PaintingType)
            {
                case MCPaintingType.TwoByTwo:
                    item.width = 20; item.height = 20;
                    item.createTile = ModContent.TileType<PaintTile2x2>();
                    break;

                case MCPaintingType.TwoByThree:
                    item.width = 20; item.height = 30;
                    item.createTile = ModContent.TileType<PaintTile2x3>();
                    break;

                case MCPaintingType.ThreeByTwo:
                    item.width = 30; item.height = 20;
                    item.createTile = ModContent.TileType<PaintTile3x2>();
                    break;

                case MCPaintingType.ThreeByThree:
                    item.width = 30; item.height = 30;
                    item.createTile = ModContent.TileType<PaintTile3x3>();
                    break;

                case MCPaintingType.SixByFour:
                    item.width = 50; item.height = 34;
                    item.createTile = ModContent.TileType<PaintTile6x4>();
                    break;
            }

            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = Item.sellPrice(0, 0, 10, 0);
            item.rare = 0;

            item.placeStyle = PaintingPlaceStyle;
        }

        public virtual void SafeSetDefaults()
        {

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