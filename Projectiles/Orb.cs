using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CZPro.Projectiles
{
    class Orb : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "Orb";
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.width = 20;
            projectile.height = 20;
            projectile.timeLeft = 10000;
            projectile.penetrate = 10;
            projectile.light = 3f;
            projectile.damage = 100;
        }

        public override void AI()
        {
            NPC target = null;
            for (int i = 0; i < Main.npc.Length; i++)
            {
                target = Main.npc[i];
                if (!target.friendly && Math.Abs(target.position.X - Main.player[0].position.X) <= 300 && Math.Abs(target.position.Y - Main.player[0].position.Y) <= 300)
                    break;
            }

            if (!target.friendly && Math.Abs(target.position.X - Main.player[0].position.X) <= 300 && Math.Abs(target.position.Y - Main.player[0].position.Y) <= 300)
            {
                Main.NewText(target, Color.Red);
                float xShoot = 2;
                float yShoot = 2;
                float xSign = (target.position.X - projectile.Center.X) / Math.Abs((target.position.X - projectile.Center.X));
                float ySign = (target.position.Y - projectile.Center.Y) / Math.Abs((target.position.Y - projectile.Center.Y));
                float slope = (target.position.Y - projectile.Center.Y) / (target.position.X - projectile.Center.X);
                yShoot *= slope;
                projectile.velocity.X = xShoot * xSign;
                projectile.velocity.Y = yShoot * ySign;
            } else
            {
                Main.NewText("No Target", Color.Red);
            }
        }
    }
}
