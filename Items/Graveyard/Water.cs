using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.Graveyard {
    public class Water : MCPaintingItem {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;
        public override bool GraveyardCraft => true;
        public override string DefaultTooltip => "–";

        public override void SafeSetStaticDefaults() {
            DisplayName.SetDefault("Water");
            Tooltip.SetDefault(DefaultTooltip);
        }

        public override void SafeSetDefaults() {
            PaintingPlaceStyle = 9;
        }
    }
}