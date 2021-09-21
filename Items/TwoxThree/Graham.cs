using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.TwoxThree {
    public class Graham : MCPaintingItem {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByThree;

        public override void SafeSetStaticDefaults() {
            DisplayName.SetDefault("Graham");
            Tooltip.SetDefault(DefaultTooltip);
        }

        public override void SafeSetDefaults() {
            PaintingPlaceStyle = 0;
        }
    }
}