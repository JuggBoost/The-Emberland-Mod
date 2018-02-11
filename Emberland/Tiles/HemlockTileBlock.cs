using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Emberland.Tiles
{
    public class HemlockTileBlock : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;  //true for block to emit light
            Main.tileLighted[Type] = false;
            drop = mod.ItemType("HemlockWood");   //put your CustomBlock name
            AddMapEntry(new Color(200, 200, 200));
        }
    }
}