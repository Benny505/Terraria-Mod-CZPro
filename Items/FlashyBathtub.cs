using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace CZPro.Items
{
    class FlashyBathtub : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flashy Bathtub");
			Tooltip.SetDefault("Scrub a dub dub, time to die bub.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 500;
			item.createTile = ModContent.TileType<Tiles.FlashyBathtub>();
		}
	}
}
