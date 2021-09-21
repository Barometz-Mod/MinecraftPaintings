using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.ThreexThree {
    public class Wither : MCPaintingItem {
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByThree;
        public override string DefaultTooltip => "–";

        public override void SafeSetStaticDefaults() {
            DisplayName.SetDefault("Wither");
            Tooltip.SetDefault(DefaultTooltip);
        }

        public override void SafeSetDefaults() {
            PaintingPlaceStyle = 8;
        }
    }
}