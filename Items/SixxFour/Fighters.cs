using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.SixxFour {
    public class Fighters : MCPaintingItem {
        //public override string Texture => "MinecraftPaintings/Items/_Placeholder6x4";

        public override MCPaintingType PaintingType => MCPaintingType.SixByFour;

        public override void SafeSetStaticDefaults() {
            DisplayName.SetDefault("Fighters");
            Tooltip.SetDefault(DefaultTooltip);
        }

        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 1;
        }
    }
}