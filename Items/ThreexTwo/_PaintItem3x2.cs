namespace MinecraftPaintings.Items.ThreexTwo
{
    public class Courbet : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x2 + "Courbet";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 0;
        }
    }

    public class Creebet : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x2 + "Creebet";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 1;
        }
    }

    public class Pool : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x2 + "Pool";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 2;
        }
    }

    public class Sea : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x2 + "Sea";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 3;
        }
    }

    public class Sunset : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x2 + "Sunset";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 4;
        }
    }
}
