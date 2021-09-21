using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.Graveyard {
    public class Fire : MCPaintingItem {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;
        public override bool GraveyardCraft => true;
        public override string DefaultTooltip => "–";

        public override void SafeSetStaticDefaults() {
            DisplayName.SetDefault("Fire");
            Tooltip.SetDefault(DefaultTooltip);
        }

        public override void SafeSetDefaults() {
            PaintingPlaceStyle = 8;
        }
    }
}