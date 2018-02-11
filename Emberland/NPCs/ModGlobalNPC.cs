using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Emberland.NPCs
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {

            if (Main.rand.Next(4) == 0)   //item rarity
			
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifeShard")); //Item spawn
            }
			
			if (npc.type == NPCID.DungeonSpirit)   
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("NullityFragment")); //Item spawn
            }
			if (Main.rand.Next(2) == 0);
			if (npc.type == NPCID.BlueSlime);			//item rarity
			
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("R")); //Item spawn
            }
        }
    }
}