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
            // Check if the player's role is SCP-049.
            if (ev.Player.Role is Scp049Role scp049)
            {
                // Set the player's health using the configured value.
                ev.Player.Health = config.Scp049CustomHealth;
                Log.Info($"[SCPUtils] Set SCP-049's health to {config.Scp049CustomHealth} for {ev.Player.Nickname}");

                // Apply a movement speed multiplier.
                ev.Player.SetMovementSpeedMultiplier(config.Scp049MovementSpeedMultiplier);

                // Set a custom damage value.
                scp049.SetDamage(config.Scp049CustomDamage);

                // Set the ability cooldown.
                ev.Player.SetAbilityCooldown(config.Scp049AbilityCooldown);

                // Set the player's height.
                ev.Player.SetHeight(config.Scp049Height);
            }
        }
    }
}
