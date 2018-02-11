using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Emberland.NPCs.Boss.MicroComputer
{
    [AutoloadBossHead]
    public class MicroComputerBoss : ModNPC
    {
        private Player player;
        private float speed;
		public float targetX = 0;
		public float targetY = 0;
		
		public int vMax = 0;
		public float vAccel = 0;
		public float tVel = 0;
		public float vMag = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Micro-Computer");
            Main.npcFrameCount[npc.type] = 1;
        }

        public override void SetDefaults()
        {
			vMax = 6;
			vAccel = 1.5f;
            npc.aiStyle = 2; // Will not have any AI from any existing AI styles. 
            npc.lifeMax = 10000; // The Max HP the boss has on Normal
            npc.damage = 20; // The base damage value the boss has on Normal
            npc.defense = 25; // The base defense on Normal
            npc.knockBackResist = 0f; // No knockback
            npc.width = 100;
            npc.height = 100;
            npc.value = 10000;
            npc.npcSlots = 15f; // The higher the number, the more NPC slots this NPC takes.
            npc.boss = true; // Is a boss
            npc.lavaImmune = true; // Not hurt by lava
            npc.noGravity = true; // Not affected by gravity
            npc.noTileCollide = true; // Will not collide with the tiles. 
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            music = MusicID.Boss1;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
            npc.defense = (int)(npc.defense + numPlayers);
        }
		public void Ai()
		{
			Player player = Main.player[npc.target];
			targetX = player.Center.X;
			targetY = player.Center.Y;
			
			float dist = (float)(Math.Sqrt((targetX - npc.Center.X)* (targetX - npc.Center.X) + (targetY - npc.Center.Y) * (targetY - npc.Center.Y)));
			tVel = dist / 20;
			if(vMag < vMax && vMag < tVel)
			{
				vMag += vAccel;
			}
			if(vMag > tVel)
			{
				vMag -= vAccel;
			}

			if(dist != 0)
			{
				Vector2 tPos;
				tPos.X = targetX;
				tPos.Y = targetY;
				npc.velocity = npc.DirectionTo(tPos) * vMag;
			}	
			
		}	
        public override void NPCLoot()
        {
                if (Main.rand.Next(3) == 0) // For items that you want to have a chance to drop 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Motherboard"), Main.rand.Next(1, 5));
                }
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Diode"), Main.rand.Next(5, 12)); // For Items that you want to always drop
        }

        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.5f;
            return null;
        }
        
    }
}