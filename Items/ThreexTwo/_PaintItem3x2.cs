namespace MinecraftPaintings.Items.ThreexTwo
{
    public class Courbet : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 0;
        }
    }

    public class Creebet : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 1;
        }
    }

    public class Pool : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 2;
        }
    }

    public class Sea : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 3;
        }
    }

    public class Sunset : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 4;
        }
    }
}
