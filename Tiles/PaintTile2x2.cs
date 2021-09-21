using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using MinecraftPaintings.Items.TwoxTwo;
using MinecraftPaintings.Items.Graveyard;

namespace MinecraftPaintings.Tiles {
    public class PaintTile2x2 : ModTile {
        public override void SetStaticDefaults() {
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
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Painting");
            AddMapEntry(new Color(90, 50, 30), name);
        }

        public override void NumDust(int i, int j, bool fail, ref int num) {
            num = 0;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            int style = frameX / 36; // 396px / 11
            var paintingList = new[] {
                ModContent.ItemType<Alban>(),
                ModContent.ItemType<Aztec>(),
                ModContent.ItemType<Aztec2>(),
                ModContent.ItemType<Bomb>(),
                ModContent.ItemType<Kebab>(),
                ModContent.ItemType<Plant>(),
                ModContent.ItemType<Wasteland>(),

                ModContent.ItemType<Earth>(),
                ModContent.ItemType<Fire>(),
                ModContent.ItemType<Water>(),
                ModContent.ItemType<Wind>()
            }; // Array MUST be in same order as corresponding item.placeStyle!
            Item.NewItem(i * 16, j * 16, 16, 48, paintingList[style]);
        }
    }
}