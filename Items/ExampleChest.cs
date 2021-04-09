using Terraria.ID;
using Terraria.ModLoader;

namespace CZPro.Items
{
	public class ExampleChest : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded chest.");
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
			item.createTile = ModContent.TileType<Tiles.ExampleChest>();
		}

		/*public override void AddRecipes() NO RECIPIE BECAUSE I HAVE CHEAT SHEET MOD
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chest);
			recipe.AddIngredient(ModContent.ItemType<ExampleBlock>(), 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
	}
}