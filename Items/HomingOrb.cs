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
    class HomingOrb : ModItem
    {
		public override void SetStaticDefaults()
		{
			Console.Write("Running");
			DisplayName.SetDefault("Homing Tomb"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shoots a tracking orb!");
		}

		public override void SetDefaults()
		{
			item.melee = false;
			item.width = 80;
			item.height = 80;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 10;
			item.value = 99999;
			item.rare = ItemRarityID.Purple;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("Orb");
			item.shootSpeed = 1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
