using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.ThreexThree {
    public class Stage : MCPaintingItem {
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByThree;

        public override void SafeSetStaticDefaults() {
            DisplayName.SetDefault("Stage");
            Tooltip.SetDefault(DefaultTooltip);
        }

        public override void SafeSetDefaults() {
            PaintingPlaceStyle = 6;
        }
    }
}