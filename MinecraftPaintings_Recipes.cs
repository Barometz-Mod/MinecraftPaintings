using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MinecraftPaintings {
    internal class MinecraftPaintings_Recipes : ModSystem {
        public override void AddRecipeGroups()
        {
            RecipeGroup group = new(
                getName: () => Language.GetTextValue("LegacyMisc.37") + " " + Language.GetTextValue($"Mods.MinecraftPaintings.Common.Paint"),
                validItems: new int[]
                {
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
                    ItemID.WhitePaint,
                    ItemID.GrayPaint,
                    ItemID.BrownPaint,
                    ItemID.ShadowPaint,
                    ItemID.NegativePaint,
                    ItemID.GlowPaint,
                    ItemID.EchoCoating
                }
            );
            RecipeGroup.RegisterGroup("MinecraftPaintings:AnyPaint", group);
        }
    }
}
