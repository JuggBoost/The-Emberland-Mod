using Terraria.ID;
using Terraria.ModLoader;

namespace Emberland.Items.Weapons.Primal
{
	public class PrimalBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Primal Blade");
			Tooltip.SetDefault("Could be sharper");
		}
		public override void SetDefaults()
		{
			item.damage = 39;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 10000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PrimalSoul", 5);
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
