namespace MinecraftPaintings.Items.TwoxThree
{
    public class Graham : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath2x3 + "Graham";
        public override MCPaintingType PaintingType => MCPaintingType.TwoByThree;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 0;
        }
    }

    public class Wanderer : MCPaintingItem
    {
        public override string Texture => MCPaintingConsts.texturePath2x3 + "Wanderer";
        public override MCPaintingType PaintingType => MCPaintingType.TwoByThree;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 1;
        }
    }
}
