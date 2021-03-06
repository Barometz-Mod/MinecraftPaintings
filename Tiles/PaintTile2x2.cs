using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace MinecraftPaintings.Tiles {
    public class PaintTile2x2 : ModTile {
        public override void SetDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Width = 2;
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.StyleWrapLimit = 111;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16 };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Painting");
            AddMapEntry(new Color(90, 50, 30), name);
        }

        public override void NumDust(int i, int j, bool fail, ref int num) {
            num = 0;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            int style = frameX / 36; // 252px / 7
            var paintingList = new[] { "Alban", "Aztec", "Aztec2", "Bomb", "Kebab", "Plant", "Wasteland" }; // Array MUST be in same order as corresponding item.placeStyle!
            string item = paintingList[style];
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType(item));
        }
    }
}