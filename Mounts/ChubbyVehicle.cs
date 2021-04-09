using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using CZPro.Buffs;
using Microsoft.Xna.Framework;

namespace CZPro.Mounts
{
	class ChubbyVehicle : ModMountData
	{
		public override void SetDefaults()
		{
			//basic data
			mountData.buff = ModContent.BuffType<ChubbyMount>();
			mountData.spawnDust = 16;
			mountData.heightBoost = 20;
			mountData.fallDamage = 0;
			mountData.runSpeed = 30f;
			mountData.dashSpeed = 10f;
			mountData.flightTimeMax = 0;
			mountData.fatigueMax = 0;
			mountData.jumpHeight = 1;
			mountData.acceleration = 0.3f;
			mountData.jumpSpeed = 6f;
			mountData.blockExtraJumps = true;
			mountData.constantJump = true;

			//how many frames are in the animation
			mountData.totalFrames = 4;

			//tells the game how to position the player in referance to the entire texture
			int[] array = new int[mountData.totalFrames];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = 20;
			}
			mountData.playerYOffsets = array;
			mountData.xOffset = 13;
			mountData.bodyFrame = 3;
			mountData.yOffset = -12;
			mountData.playerHeadOffset = 22;

			//////animation data///////
			//animation when still
			mountData.standingFrameCount = 1;
			//animation when moving
			mountData.runningFrameCount = 4;
			mountData.runningFrameDelay = 30;
			mountData.runningFrameStart = 0;
			//animation when in the air
			mountData.inAirFrameCount = 1;
			mountData.inAirFrameDelay = 40;
			mountData.inAirFrameStart = 0;
			//animation when swimming
			mountData.swimFrameCount = 4;
			mountData.swimFrameDelay = 70;
			mountData.swimFrameStart = 0;

			//specifying the texture size for animations
			mountData.textureWidth = mountData.backTexture.Width + 20;
			mountData.textureHeight = mountData.backTexture.Height;
		}

    }
}
