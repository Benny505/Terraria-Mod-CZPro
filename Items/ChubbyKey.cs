using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using CZPro.Mounts;

namespace CZPro.Items
{
    class ChubbyKey : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chubby Key");
            Tooltip.SetDefault("Spawn the chubby vehicle");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.value = 76432;
            item.rare = ItemRarityID.Yellow;
            item.noMelee = true;
            item.mountType = ModContent.MountType<ChubbyVehicle>();
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
