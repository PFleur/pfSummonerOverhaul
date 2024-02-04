using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static pfSOverhaul.content.pfRecipeGroups;

namespace pfSOverhaul.content.items.armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class pfFlinxSkirt : ModItem
	{
		public override void SetDefaults(){
			Item.width = 18;
			Item.height = 18;
			Item.value = Item.sellPrice(gold: 1);
			Item.rare = ItemRarityID.Green;
			Item.defense = 2;
		}
		public override void UpdateEquip(Player player){
			player.GetDamage(DamageClass.Summon) += 0.05f;
		}
		public override void AddRecipes(){
			CreateRecipe()
				.AddIngredient(ItemID.FlinxFur, 2)
				.AddIngredient(ItemID.Silk, 5)
				.AddRecipeGroup(pfGoldBarGroup, 4)
				.AddTile(TileID.Loom)
				.Register();
		}

	}
}
