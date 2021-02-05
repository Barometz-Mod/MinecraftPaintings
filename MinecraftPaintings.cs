using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using Terraria.ID;

namespace MinecraftPaintings {
    public class MinecraftPaintings : Mod {
        internal static MinecraftPaintings mod;

        public MinecraftPaintings() {}

        public override void Load() {
            mod = this;
        }

        public override void Unload() {
            mod = null;
        }

        public override void AddRecipeGroups() {
            // int[] paintList = new int[30]; // TODO: increase to [31] when 1.4 comes out
            // int indexCounter = 0;
            // for(int i = 1073; i <= 1099; i++) { // Red Paint to Deep Pink Paint
            //     paintList[indexCounter] = i;
            //     indexCounter++;
            // }
            // for(int i = 1966; i <= 1968; i++) { // Brown Paint to Negative Paint
            //     paintList[indexCounter] = i;
            //     indexCounter++;
            // }

            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Paint", new int[] {
                ItemID.RedPaint,
                ItemID.OrangePaint,
                ItemID.YellowPaint,
                ItemID.LimePaint,
                ItemID.GreenPaint,
                ItemID.TealPaint,
                ItemID.CyanPaint,
                ItemID.SkyBluePaint,
                ItemID.BluePaint,
                ItemID.PurplePaint,
                ItemID.VioletPaint,
                ItemID.PinkPaint,
                ItemID.DeepRedPaint,
                ItemID.DeepOrangePaint,
                ItemID.DeepYellowPaint,
                ItemID.DeepLimePaint,
                ItemID.DeepGreenPaint,
                ItemID.DeepTealPaint,
                ItemID.DeepCyanPaint,
                ItemID.DeepSkyBluePaint,
                ItemID.DeepBluePaint,
                ItemID.DeepPurplePaint,
                ItemID.DeepVioletPaint,
                ItemID.DeepPinkPaint,
                ItemID.BlackPaint,
                ItemID.GrayPaint,
                ItemID.WhitePaint,
                ItemID.ShadowPaint,
                ItemID.NegativePaint,
                ItemID.BrownPaint
            });
            RecipeGroup.RegisterGroup("MinecraftPaintings:AnyPaint", group);
        }
    }
}