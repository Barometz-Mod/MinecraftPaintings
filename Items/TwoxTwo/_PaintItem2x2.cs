namespace MinecraftPaintings.Items.TwoxTwo
{
    public class Alban : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 0;
        }
    }

    public class Aztec : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 1;
        }
    }

    public class Aztec2 : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 2;
        }
    }

    public class Bomb : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 3;
        }
    }

    public class Kebab : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 4;
        }
    }

    public class Plant : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 5;
        }
    }

    public class Wasteland : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 6;
        }
    }

    public class Earth : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;
        public override bool GraveyardCraft => true;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 7;
        }
    }

    public class Fire : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;
        public override bool GraveyardCraft => true;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 8;
        }
    }

    public class Water : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;
        public override bool GraveyardCraft => true;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 9;
        }
    }

    public class Wind : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;
        public override bool GraveyardCraft => true;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 10;
        }
    }
}
