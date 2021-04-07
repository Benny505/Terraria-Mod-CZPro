using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CZPro.Projectiles
{
    class FireKnife : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "FireKnife";
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.width = 10;
            projectile.height = 10;
            projectile.timeLeft = 999;
            projectile.penetrate = 3;
            projectile.light = 1f;
            projectile.extraUpdates = 1;
            projectile.damage = 3;
        }

        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X);
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 60);
        }

    }
}
