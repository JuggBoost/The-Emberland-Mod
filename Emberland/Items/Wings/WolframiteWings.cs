using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Emberland.Items.Wings
{
	[AutoloadEquip(EquipType.Wings)]
	public class WolframiteWings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Allows Flight. While Equipped, It will give you an extra 10 Defense.");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.value = 10000;
			item.rare = 8;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 75;
			player.statDefense += 10;
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
			recipe.AddIngredient(null, "WolframiteBar", 10);
            recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
            recipe.AddRecipe();
		}
	}
}