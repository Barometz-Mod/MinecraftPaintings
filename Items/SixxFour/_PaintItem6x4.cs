namespace MinecraftPaintings.Items.SixxFour
{
    public class DonkeyKong : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath6x4 + "DonkeyKong";
        public override MCPaintingType PaintingType => MCPaintingType.SixByFour;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 0;
        }
    }

    public class Fighters : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath6x4 + "Fighters";
        public override MCPaintingType PaintingType => MCPaintingType.SixByFour;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 1;
        }
    }

    public class Skeleton : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath6x4 + "Skeleton";
        public override MCPaintingType PaintingType => MCPaintingType.SixByFour;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 2;
        }
    }
}
