using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Player;
using SCPUtils.Extensions; // Custom extension methods for modifying role properties

namespace SCPUtils.Editors
{
    public class Scp096Editor : IScpEditor
    {
        public void TryEdit(VerifiedEventArgs ev, global::SCPUtils.Config config)
        {
            if (ev.Player.Role is Scp096Role scp096)
            {
                // Set SCP-096's health
                ev.Player.Health = config.Scp096CustomHealth;
                if (config.Debug)
                    Log.Info($"[SCPUtils] Set SCP-096's health to {config.Scp096CustomHealth} for {ev.Player.Nickname}");

                // Apply custom stats
                scp096.SetDamage(config.Scp096CustomDamage);
                ev.Player.SetAbilityCooldown(config.Scp096AbilityCooldown);
                scp096.SetRageThreshold(config.Scp096RageThreshold);

                // Apply Hume Shield (using Player Extensions)
                ev.Player.SetHumeShield(config.Scp096HumeShieldStart);
                ev.Player.SetHumeShieldRegen(config.Scp096HumeShieldRegen);
                
                if (config.Debug)
                    Log.Info($"[SCPUtils] Set Hume Shield to {config.Scp096HumeShieldStart} with regen {config.Scp096HumeShieldRegen} for {ev.Player.Nickname}");
            }
        }
    }
}
