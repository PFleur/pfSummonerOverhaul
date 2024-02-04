using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace pfSOverhaul.content.items.armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class pfLeafLegs : ModItem
	{
		public override void SetDefaults(){
			Item.width = 18;
			Item.height = 18;
			Item.value = Item.sellPrice(copper: 50);
			Item.rare = ItemRarityID.Blue;
			Item.defense = 1;
		}
		public override void UpdateEquip(Player player){
			player.GetDamage(DamageClass.Summon) += 0.01f;
		}
		public override void AddRecipes(){
			CreateRecipe()
				.AddIngredient(ItemID.WoodGreaves)
				.AddIngredient(ItemID.FallenStar, 5)
				.AddTile(TileID.WorkBenches)
				.Register();
		
		}
	}
}
