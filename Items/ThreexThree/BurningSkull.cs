using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.ThreexThree {
    public class BurningSkull : MCPaintingItem {
        //public override string Texture => "MinecraftPaintings/Items/_Placeholder3x3";

        public override MCPaintingType PaintingType => MCPaintingType.ThreeByThree;

        public override void SafeSetStaticDefaults() {
            DisplayName.SetDefault("Burning Skull");
            Tooltip.SetDefault(DefaultTooltip);
        }

        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 0;
        }
    }
}