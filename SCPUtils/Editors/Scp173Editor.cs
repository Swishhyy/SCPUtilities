using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Player;
using SCPUtils.Extensions; // Ensure your custom extension methods are available

namespace SCPUtils.Editors
{
    public class Scp173Editor : IScpEditor
    {
        public void TryEdit(VerifiedEventArgs ev, global::SCPUtils.Config config)
        {
            if (ev.Player.Role is Scp173Role scp173)
            {
                // Set SCP-173's health
                ev.Player.Health = config.Scp173CustomHealth;

                if (config.Debug)
                    Log.Info($"[SCPUtils] Set SCP-173's health to {config.Scp173CustomHealth} for {ev.Player.Nickname}");

                // Apply custom stats
                scp173.SetDamage(config.Scp173CustomDamage);
                scp173.SetAttackCooldown(config.Scp173AttackCooldown);
                scp173.SetBlinkRate(config.Scp173BlinkRate);

                // Apply Hume Shield (using Player Extensions)
                ev.Player.SetHumeShield(config.Scp173HumeShieldStart);
                ev.Player.SetHumeShieldRegen(config.Scp173HumeShieldRegen);

                if (config.Debug)
                    Log.Info($"[SCPUtils] Set Hume Shield to {config.Scp173HumeShieldStart} with regen {config.Scp173HumeShieldRegen} for {ev.Player.Nickname}");
            }
        }
    }
}
