using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Emberland.Items.Placeable
{
    public class HemlockWood : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 22;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
			item.rare = 2;
            item.consumable = true;
            item.createTile = mod.TileType("HemlockTileBlock"); //put your CustomBlock Tile name
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DynastyWood, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}	
    }
}
