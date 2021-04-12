using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace CZPro.Buffs
{
    class ChubbyMount : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("ChubbyVehicle");
            Description.SetDefault("Leather seats, 4 cup holders");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(ModContent.MountType<Mounts.ChubbyVehicle>(), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}
