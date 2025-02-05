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
                // Set the ability cooldown for SCP-079
                ev.Player.SetAbilityCooldown(config.Scp079AbilityCooldown);
                if (config.Debug)
                    Log.Info($"[SCPUtils] Set SCP-079's ability cooldown to {config.Scp079AbilityCooldown} seconds for {ev.Player.Nickname}");

                // Set the AP charge rate for SCP-079
                scp079.SetAPChargeRate(config.Scp079APChargeRate);
                if (config.Debug)
                    Log.Info($"[SCPUtils] Set SCP-079's AP charge rate to {config.Scp079APChargeRate} for {ev.Player.Nickname}");
            }
        }
    }
}
