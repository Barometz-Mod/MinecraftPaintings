using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.ThreexThree {
    public class Match : MCPaintingItem {
        //public override string Texture => "MinecraftPaintings/Items/_Placeholder3x3";

        public override MCPaintingType PaintingType => MCPaintingType.ThreeByThree;

        public override void SafeSetStaticDefaults() {
            DisplayName.SetDefault("Match");
            Tooltip.SetDefault(DefaultTooltip);
        }

        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 2;
        }
    }
}