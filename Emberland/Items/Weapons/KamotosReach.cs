using Terraria.ID;
using Terraria.ModLoader;

namespace Emberland.Items.Weapons
{
	public class KamotosReach : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kamoto's Reach");
			Tooltip.SetDefault("Hold's the power of Kamoto.");
		}
		public override void SetDefaults()
		{
			item.damage = 32;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}
