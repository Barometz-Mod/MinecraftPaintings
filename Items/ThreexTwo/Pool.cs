using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.ThreexTwo {
    public class Pool : MCPaintingItem {
        //public override string Texture => "MinecraftPaintings/Items/_Placeholder3x2";

        public override MCPaintingType PaintingType => MCPaintingType.ThreeByTwo;

        public override void SafeSetStaticDefaults() {
            DisplayName.SetDefault("Pool");
            Tooltip.SetDefault(DefaultTooltip);
        }

        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 2;
        }
    }
}