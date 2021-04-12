using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CZPro.Tiles
{
    class FlashyBathtub : ModTile
    {
		Player playerThatPlaced;

		public override void SetDefaults()
		{
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 1200;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileValue[Type] = 500;
			TileObjectData.newTile.UsesCustomCanPlace = true;
			TileID.Sets.HasOutlines[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
			TileObjectData.newTile.Width = 6;
			TileObjectData.newTile.Height = 3;
			TileObjectData.newTile.Origin = new Point16(1, 1);
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
			//TileObjectData.newTile.HookCheck = new PlacementHook(new Func<int, int, int, int, int, int>(Chest.FindEmptyChest), -1, 0, true);
			//TileObjectData.newTile.HookPostPlaceMyPlayer = new PlacementHook(new Func<int, int, int, int, int, int>(Chest.AfterPlacement_Hook), -1, 0, false);
			//TileObjectData.newTile.AnchorInvalidTiles = new[] { 127 };
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Flashy Bathtub");
			//AddMapEntry(new Color(200, 200, 200), name, MapChestName);
			//name = CreateMapEntryName(Name + "_Locked"); // With multiple map entries, you need unique translation keys.
			//name.SetDefault("Locked Example Chest");
			//AddMapEntry(new Color(0, 141, 63), name, MapChestName);
			disableSmartCursor = true;
			drop = ModContent.ItemType<Items.FlashyBathtub>();
			animationFrameHeight = 54;
		}

		public override void AnimateTile(ref int frame, ref int frameCounter)
		{
			if (++frameCounter >= 9)
			{
				frameCounter = 0;
				frame = ++frame % 4;
			}
		}

        public override void PlaceInWorld(int i, int j, Item item)
        {
			playerThatPlaced = Main.LocalPlayer;
		}

        public override void NearbyEffects(int i, int j, bool closer)
        {
			foreach (Player player in Main.player)
            {
				double playerVector = Math.Sqrt(Math.Pow(player.position.X / 16 - i, 2) + Math.Pow(player.position.Y / 16 - j, 2));
				if (playerVector <= 5 && player != playerThatPlaced)
					player.Hurt(PlayerDeathReason.ByCustomReason("The best dang tub."), 100, 0);
			}
        }
	}
}
