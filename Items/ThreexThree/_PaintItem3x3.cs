namespace MinecraftPaintings.Items.ThreexThree
{
    public class BurningSkull : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x3 + "BurningSkull";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByThree;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 0;
        }
    }

    public class Bust : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x3 + "Bust";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByThree;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 1;
        }
    }

    public class Match : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x3 + "Match";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByThree;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 2;
        }
    }

    public class Pigscene : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x3 + "Pigscene";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByThree;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 3;
        }
    }

    public class Pointer : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x3 + "Pointer";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByThree;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 4;
        }
    }

    public class SkullAndRoses : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x3 + "SkullAndRoses";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByThree;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 5;
        }
    }

    public class Stage : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x3 + "Stage";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByThree;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 6;
        }
    }

    public class Void : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x3 + "Void";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByThree;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 7;
        }
    }

    public class Wither : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath3x3 + "Wither";
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByThree;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 8;
        }
    }
}
