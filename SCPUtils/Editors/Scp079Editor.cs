using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Player;
using SCPUtils.Extensions; // Our custom extension methods

namespace SCPUtils.Editors
{
    public class Scp079Editor : IScpEditor
    {
        public void TryEdit(VerifiedEventArgs ev, global::SCPUtils.Config config)
        {
            if (ev.Player.Role is Scp079Role scp079)
            {
                // Set SCP-079's health using the configured value.
                ev.Player.Health = config.Scp079CustomHealth;
                Log.Info($"[SCPUtils] Set SCP-079's health to {config.Scp079CustomHealth} for {ev.Player.Nickname}");

                // Set the ability cooldown for SCP-079.
                ev.Player.SetAbilityCooldown(config.Scp079AbilityCooldown);

                // Set the AP charge rate for SCP-079.
                scp079.SetAPChargeRate(config.Scp079APChargeRate);
            }
        }
    }
}
