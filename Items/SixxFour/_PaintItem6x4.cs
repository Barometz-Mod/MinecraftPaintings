namespace MinecraftPaintings.Items.SixxFour
{
    public class DonkeyKong : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.SixByFour;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 0;
        }
    }

    public class Fighters : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.SixByFour;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 1;
        }
    }

    public class Skeleton : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.SixByFour;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 2;
        }
    }
}
