using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Player;
using SCPUtils.Extensions; // Custom extension methods for Player and SCP roles

namespace SCPUtils.Editors
{
    public class Scp106Editor : IScpEditor
    {
        public void TryEdit(VerifiedEventArgs ev, global::SCPUtils.Config config)
        {
            if (ev.Player.Role is Scp106Role scp106)
            {
                // Set SCP-106's health
                ev.Player.Health = config.Scp106CustomHealth;

                if (config.Debug)
                    Log.Info($"[SCPUtils] Set SCP-106's health to {config.Scp106CustomHealth} for {ev.Player.Nickname}");

                // Apply custom stats
                scp106.SetDamage(config.Scp106CustomDamage);
                ev.Player.SetAbilityCooldown(config.Scp106AbilityCooldown);
                scp106.SetTeleportationCooldown(config.Scp106TeleportCooldown);

                // Apply Hume Shield (using Player Extensions)
                ev.Player.SetHumeShield(config.Scp106HumeShieldStart);
                ev.Player.SetHumeShieldRegen(config.Scp106HumeShieldRegen);

                if (config.Debug)
                    Log.Info($"[SCPUtils] Set Hume Shield to {config.Scp106HumeShieldStart} with regen {config.Scp106HumeShieldRegen} for {ev.Player.Nickname}");
            }
        }
    }
}
