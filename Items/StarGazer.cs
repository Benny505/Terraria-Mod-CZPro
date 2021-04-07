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
    class StarGazer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star Gazer"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("The most overpowered sword ever!");
        }
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 10;
			item.value = 99999;
			item.rare = ItemRarityID.Purple;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("FireKnife");
			item.shootSpeed = 8f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
			target.AddBuff(BuffID.OnFire, 300);
		}
	}
}
