using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using MinecraftPaintings.Tiles;
using System.Linq;
using MinecraftPaintings.Items.SixxFour;

namespace MinecraftPaintings.Items
{
    public abstract class MCPaintingItem : ModItem
    {
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

        /////////////////////////

        public sealed override void SetStaticDefaults()
        {
            SafeSetStaticDefaults();
        }

        public virtual void SafeSetStaticDefaults()
        {

        }

        public sealed override void SetDefaults()
        {
            SafeSetDefaults();

            switch (PaintingType)
            {
                case MCPaintingType.TwoByTwo:
                    Item.DefaultToPlaceableTile(ModContent.TileType<PaintTile2x2>(), PaintingPlaceStyle);
                    Item.width = 20;
                    Item.height = 20;
                    break;

                case MCPaintingType.TwoByThree:
                    Item.DefaultToPlaceableTile(ModContent.TileType<PaintTile2x3>(), PaintingPlaceStyle);
                    Item.width = 20;
                    Item.height = 30;
                    break;

                case MCPaintingType.ThreeByTwo:
                    Item.DefaultToPlaceableTile(ModContent.TileType<PaintTile3x2>(), PaintingPlaceStyle);
                    Item.width = 30;
                    Item.height = 20;
                    break;

                case MCPaintingType.ThreeByThree:
                    Item.DefaultToPlaceableTile(ModContent.TileType<PaintTile3x3>(), PaintingPlaceStyle);
                    Item.width = 30;
                    Item.height = 30;
                    break;

                case MCPaintingType.SixByFour:
                    Item.DefaultToPlaceableTile(ModContent.TileType<PaintTile6x4>(), PaintingPlaceStyle);
                    Item.width = 50;
                    Item.height = 34;
                    break;
            }

            Item.maxStack = Item.CommonMaxStack;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 10, 0);
            Item.rare = ItemRarityID.White;
        }

        public virtual void SafeSetDefaults()
        {

        }

        public override void AddRecipes()
        {
            var recipe = CreateRecipe(1);
            recipe.AddRecipeGroup("Wood", 8);
            recipe.AddRecipeGroup("MinecraftPaintings:AnyPaint", 1);
            recipe.AddTile(TileID.WorkBenches);
            if (GraveyardCraft)
            {
                recipe.AddCondition(Condition.InGraveyard);
                // TODO - clean this up
                recipe.SortBefore(Main.recipe.First(recipe => recipe.createItem.type == ModContent.ItemType<DonkeyKong>()));
            }

            recipe.Register();
        }
    }
}