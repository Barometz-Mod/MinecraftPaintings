using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.TwoxThree {
    public class Wanderer : MCPaintingItem {
        //public override string Texture => "MinecraftPaintings/Items/_Placeholder2x3";

        public override MCPaintingType PaintingType => MCPaintingType.TwoByThree;

        public override void SafeSetStaticDefaults() {
            DisplayName.SetDefault("Wanderer");
            Tooltip.SetDefault(DefaultTooltip);
        }

        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 1;
        }
    }
}