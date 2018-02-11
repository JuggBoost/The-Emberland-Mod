using Terraria.ID;
using Terraria.ModLoader;

namespace Emberland.Items.Greek
{
	public class HarpeSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Harpe Sword");
			Tooltip.SetDefault("Wielded by the Greatest.");
		}
		public override void SetDefaults()
		{
			item.damage = 60;
			item.melee = true;
			item.width = 74;
			item.height = 74;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BarofUnknown", 10);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddIngredient(ItemID.Diamond, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
