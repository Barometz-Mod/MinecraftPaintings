namespace MinecraftPaintings.Items.TwoxThree
{
    public class Graham : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByThree;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 0;
        }
    }

    public class Wanderer : MCPaintingItem
    {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByThree;
        public override void SafeSetDefaults()
        {
            PaintingPlaceStyle = 1;
        }
    }
}
