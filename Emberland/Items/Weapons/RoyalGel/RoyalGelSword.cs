using Terraria.ID;
using Terraria.ModLoader;

namespace Emberland.Items.Weapons.RoyalGel
{
	public class RoyalGelSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Royal Gel Sword");
			Tooltip.SetDefault("Why is this even a thing?");
		}
		public override void SetDefaults()
		{
			item.damage = 9;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RoyalGel", 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
