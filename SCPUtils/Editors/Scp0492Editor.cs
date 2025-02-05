using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Player;
using SCPUtils.Extensions; // Ensure you have extension methods defined for Scp0492Role

namespace SCPUtils.Editors
{
    public class Scp0492Editor : IScpEditor
    {
        public void TryEdit(VerifiedEventArgs ev, global::SCPUtils.Config config)
        {
            if (ev.Player.Role is Scp0492Role scp0492)
            {
                // Set the player's health
                ev.Player.Health = config.Scp0492CustomHealth;
                Log.Info($"[SCPUtils] Set SCP-049-2's health to {config.Scp0492CustomHealth} for {ev.Player.Nickname}");

                // Apply custom stats
                ev.Player.SetMovementSpeedMultiplier(config.Scp0492MovementSpeedMultiplier);
                scp0492.SetDamage(config.Scp0492CustomDamage);
                ev.Player.SetAbilityCooldown(config.Scp0492AbilityCooldown);
                ev.Player.SetHeight(config.Scp0492Height);

                // Apply Hume Shield (using Player Extensions)
                ev.Player.SetHumeShield(config.Scp0492HumeShieldStart);
                ev.Player.SetHumeShieldRegen(config.Scp0492HumeShieldRegen);

                Log.Info($"[SCPUtils] Set Hume Shield to {config.Scp0492HumeShieldStart} with regen {config.Scp0492HumeShieldRegen} for {ev.Player.Nickname}");
            }
        }
    }
}
