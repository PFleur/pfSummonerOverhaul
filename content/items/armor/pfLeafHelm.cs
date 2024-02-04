using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace pfSOverhaul.content.items.armor
{
	[AutoloadEquip(EquipType.Head)]
	public class pfLeafHelm : ModItem
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
		public override bool IsArmorSet(Item head, Item body, Item legs){
			return body.type == ModContent.ItemType<pfLeafChest>() && legs.type == ModContent.ItemType<pfLeafLegs>();
		}
		public override void UpdateArmorSet(Player player){
			player.setBonus = "Increases defense by 2 and summon damage by 2%";
			player.GetDamage(DamageClass.Summon) += 0.02f;
			player.statDefense += 2;
		}
		public override void AddRecipes(){
			CreateRecipe()
				.AddIngredient(ItemID.WoodHelmet)
				.AddIngredient(ItemID.FallenStar, 5)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
