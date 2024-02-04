using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace pfSOverhaul.content
{
	public class pfRecipeGroups : ModSystem
	{
		public static RecipeGroup pfGoldBarGroup;

		public override void Unload() {
			pfGoldBarGroup = null;
		}
		
		public override void AddRecipeGroups() {
			pfGoldBarGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.GoldBar)}",
				ItemID.GoldBar, ItemID.PlatinumBar);
			RecipeGroup.RegisterGroup(nameof(ItemID.GoldBar),pfGoldBarGroup);
		}
	}
}
