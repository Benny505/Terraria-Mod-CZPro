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
			TileObjectData.newTile.Origin = new Point16(1, 0);
			TileObjectData.newTile.CoordinateHeights = new[] { 16 };
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
		}
	}
}
