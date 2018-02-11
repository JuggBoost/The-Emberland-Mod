using Terraria.ID;
using Terraria.ModLoader;

namespace Emberland.Items.Misc
{
	public class Diode : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Electronic");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.value = 10000;
			item.rare = 8;
		}
	}
}