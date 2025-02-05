using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Player;
using SCPUtils.Extensions;

namespace SCPUtils.Editors
{
    public class Scp049Editor : IScpEditor
    {
        public void TryEdit(VerifiedEventArgs ev, global::SCPUtils.Config config)
        {
            if (ev.Player.Role is Scp049Role scp049)
            {
                // Set the player's health
                ev.Player.Health = config.Scp049CustomHealth;
                if (config.Debug)
                    Log.Info($"[SCPUtils] Set SCP-049's health to {config.Scp049CustomHealth} for {ev.Player.Nickname}");

                // Apply custom stats
                ev.Player.SetMovementSpeedMultiplier(config.Scp049MovementSpeedMultiplier);
                scp049.SetDamage(config.Scp049CustomDamage);
                ev.Player.SetAbilityCooldown(config.Scp049AbilityCooldown);
                ev.Player.SetHeight(config.Scp049Height);

                // Apply Hume Shield (using Player Extensions)
                ev.Player.SetHumeShield(config.Scp049HumeShieldStart);
                ev.Player.SetHumeShieldRegen(config.Scp049HumeShieldRegen);
                
                if (config.Debug)
                    Log.Info($"[SCPUtils] Set Hume Shield to {config.Scp049HumeShieldStart} with regen {config.Scp049HumeShieldRegen} for {ev.Player.Nickname}");
            }
        }
    }
}
