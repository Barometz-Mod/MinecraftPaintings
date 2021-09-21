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

        /// <summary>
        /// Defines if the painting recipe requires Ecto Mist to craft.
        /// Should only be used for the unused Bedrock Edition paintings.
        /// Defaults to false.
        /// </summary>
        public virtual bool GraveyardCraft => false;

        public virtual string DefaultTooltip => "'K. Zetterstrand'";

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
                    Item.width = 20; Item.height = 20;
                    Item.createTile = ModContent.TileType<PaintTile2x2>();
                    break;

                case MCPaintingType.TwoByThree:
                    Item.width = 20; Item.height = 30;
                    Item.createTile = ModContent.TileType<PaintTile2x3>();
                    break;

                case MCPaintingType.ThreeByTwo:
                    Item.width = 30; Item.height = 20;
                    Item.createTile = ModContent.TileType<PaintTile3x2>();
                    break;

                case MCPaintingType.ThreeByThree:
                    Item.width = 30; Item.height = 30;
                    Item.createTile = ModContent.TileType<PaintTile3x3>();
                    break;

                case MCPaintingType.SixByFour:
                    Item.width = 50; Item.height = 34;
                    Item.createTile = ModContent.TileType<PaintTile6x4>();
                    break;
            }

            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = 1;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 10, 0);
            Item.rare = 0;

            Item.placeStyle = PaintingPlaceStyle;
        }

        public virtual void SafeSetDefaults() {

        }

        public override void AddRecipes() {
            var recipe = CreateRecipe(1);
            recipe.AddRecipeGroup("Wood", 8);
            recipe.AddRecipeGroup("MinecraftPaintings:AnyPaint", 1);
            recipe.AddTile(TileID.WorkBenches);
            if (GraveyardCraft) recipe.AddCondition(Recipe.Condition.InGraveyardBiome);

            recipe.Register();
        }
    }
}