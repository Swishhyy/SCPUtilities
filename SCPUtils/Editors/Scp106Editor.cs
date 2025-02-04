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
            // Check if the player's role is SCP-106.
            if (ev.Player.Role is Scp106Role scp106)
            {
                // Set SCP-106's health using the configured value.
                ev.Player.Health = config.Scp106CustomHealth;
                Log.Info($"[SCPUtils] Set SCP-106's health to {config.Scp106CustomHealth} for {ev.Player.Nickname}");

                // Set a custom damage value.
                scp106.SetDamage(config.Scp106CustomDamage);

                // Set the ability cooldown.
                ev.Player.SetAbilityCooldown(config.Scp106AbilityCooldown);

                // Set the teleportation cooldown for SCP-106.
                scp106.SetTeleportationCooldown(config.Scp106TeleportCooldown);
            }
        }
    }
}
