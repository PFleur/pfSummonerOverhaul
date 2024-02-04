using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static pfSOverhaul.content.pfRecipeGroups;

namespace pfSOverhaul.content.items.armor
{
	[AutoloadEquip(EquipType.Head)]
	public class pfFlinxHat : ModItem
	{
		public override void SetStaticDefaults(){
			ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true;
		}
		public override void SetDefaults(){
			Item.width = 18;
			Item.height = 18;
			Item.value = Item.sellPrice(gold: 1);
			Item.rare = ItemRarityID.Green;
			Item.defense = 1;
		}
		public override void UpdateEquip(Player player){
			player.GetDamage(DamageClass.Summon) += 0.05f;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ItemID.FlinxFurCoat && legs.type == ModContent.ItemType<pfFlinxSkirt>();
		}
		public override void UpdateArmorSet(Player player){
			player.setBonus = "Increases summon damage by 5%";
			player.GetDamage(DamageClass.Summon) += 0.05f;
		}
		public override void AddRecipes(){
			CreateRecipe()
				.AddIngredient(ItemID.FlinxFur, 2)
				.AddRecipeGroup(pfGoldBarGroup, 5)
				.AddTile(TileID.Loom)
				.Register();
		}
	}
}
