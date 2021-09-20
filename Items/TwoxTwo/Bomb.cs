using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.TwoxTwo {
    public class Bomb : MCPaintingItem {
        //public override string Texture => "MinecraftPaintings/Items/_Placeholder2x2";

        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;

        public override void SafeSetStaticDefaults() {
            DisplayName.SetDefault("Bomb");
            Tooltip.SetDefault(DefaultTooltip);
        }

        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 3;
        }
    }
}