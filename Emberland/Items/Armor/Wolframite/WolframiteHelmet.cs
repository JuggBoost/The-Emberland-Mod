using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Emberland.Items.Armor.Wolframite
{
	[AutoloadEquip(EquipType.Head)]
	public class WolframiteHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Increases melee damage by 8%.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 24;
			item.value = 10000;
			item.rare = 8;
			item.defense = 14;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("WolframiteChestplate") && legs.type == mod.ItemType("WolframiteLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.meleeDamage *= 0.8f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WolframiteBar", 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}