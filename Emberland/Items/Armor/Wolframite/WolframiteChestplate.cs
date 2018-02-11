using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Emberland.Items.Armor.Wolframite
{
	[AutoloadEquip(EquipType.Body)]
	public class WolframiteChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Wolframite Chestplate");
			Tooltip.SetDefault("Increase max health by 50 & Increases Melee critical chance by 8%.");
		}

		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 32;
			item.value = 10000;
			item.rare = 8;
			item.defense = 10;
		}
		public override void UpdateArmorSet(Player player)
		{
			player.statLifeMax *= 50;
			player.meleeCrit += 8;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WolframiteBar", 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}