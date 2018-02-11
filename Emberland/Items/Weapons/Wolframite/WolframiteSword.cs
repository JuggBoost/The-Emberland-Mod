using Terraria.ID;
using Terraria.ModLoader;

namespace Emberland.Items.Weapons.Wolframite
{
	public class WolframiteSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wolframite Blade");
			Tooltip.SetDefault("Looks like some blacksmith was drunk.");
		}
		public override void SetDefaults()
		{
			item.damage = 41;
			item.melee = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WolframiteBar", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
