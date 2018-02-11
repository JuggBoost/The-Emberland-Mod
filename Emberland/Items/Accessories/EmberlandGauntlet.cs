using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Emberland.Items.Accessories
{
	public class EmberlandGauntlet : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 26;
			item.height = 26;

			item.value = 12500;
			item.rare = 11;
			item.defense = 10;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Emberland Gauntlet");
			Tooltip.SetDefault("Increases life regen, increases defense by 10, & increases melee damage by 15%");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.lifeRegen += 50;
			player.meleeDamage += 0.15f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "EmberlandBar", 5);
			recipe.AddIngredient(null, "EmptyGauntlet", 1);
			recipe.AddIngredient(ItemID.SoulofLight, 20);
			recipe.AddIngredient(ItemID.SoulofMight, 20);
			recipe.SetResult(this);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddRecipe();
		}
	}
}