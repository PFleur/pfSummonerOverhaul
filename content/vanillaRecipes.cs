using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace pfSOverhaul.content
{
	public class pfVanillaRecipes : ModSystem
	{
		public override void AddRecipes(){
			Recipe.Create(ItemID.BabyBirdStaff)
				.AddRecipeGroup(RecipeGroupID.Wood, 5)
				.AddIngredient(ItemID.Acorn)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
