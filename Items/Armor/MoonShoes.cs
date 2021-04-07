using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CZPro.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    class MoonShoes : ModItem
    {
       public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MoonShoes");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 14;
            item.value = 98475;
        }

        public override void UpdateEquip(Player player)
        {
            player.jumpBoost = true;
            player.doubleJumpCloud = true;
            player.maxRunSpeed = 100;
            player.noFallDmg = true;
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
