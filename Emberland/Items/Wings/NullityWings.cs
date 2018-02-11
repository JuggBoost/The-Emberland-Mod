using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Emberland.Items.Wings
{
	[AutoloadEquip(EquipType.Wings)]
	public class NullityWings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Allows Flight. While Equipped, It will give you an extra 15 Defense.");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 10000;
			item.rare = 8;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 125;
			player.statDefense += 15;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 11f;
			acceleration *= 2.5f;
		}

		public override void AddRecipes()
		{
			 ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofFlight, 20);
			recipe.AddIngredient(null, "NullityFragment", 10);
            recipe.SetResult(this);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddRecipe();
		}
	}
}