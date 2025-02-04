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
            // Check if the player's role is SCP-049-2.
            if (ev.Player.Role is Scp0492Role scp0492)
            {
                // Set the player's health using the configured value.
                ev.Player.Health = config.Scp0492CustomHealth;
                Log.Info($"[SCPUtils] Set SCP-049-2's health to {config.Scp0492CustomHealth} for {ev.Player.Nickname}");

                // Apply a movement speed multiplier.
                ev.Player.SetMovementSpeedMultiplier(config.Scp0492MovementSpeedMultiplier);

                // Set a custom damage value.
                scp0492.SetDamage(config.Scp0492CustomDamage);

                // Set the ability cooldown.
                ev.Player.SetAbilityCooldown(config.Scp0492AbilityCooldown);

                // Set the player's height.
                ev.Player.SetHeight(config.Scp0492Height);
            }
        }
    }
}
