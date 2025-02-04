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
            // Check if the player's role is SCP-096.
            if (ev.Player.Role is Scp096Role scp096)
            {
                // Set SCP-096's health using the configured value.
                ev.Player.Health = config.Scp096CustomHealth;
                Log.Info($"[SCPUtils] Set SCP-096's health to {config.Scp096CustomHealth} for {ev.Player.Nickname}");

                // Set a custom damage value for SCP-096.
                scp096.SetDamage(config.Scp096CustomDamage);

                // Set the ability cooldown for SCP-096.
                ev.Player.SetAbilityCooldown(config.Scp096AbilityCooldown);

                // Set the rage threshold for SCP-096.
                scp096.SetRageThreshold(config.Scp096RageThreshold);
            }
        }
    }
}
