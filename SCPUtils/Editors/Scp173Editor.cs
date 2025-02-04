using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Player;
using SCPUtils.Extensions; // Ensure your custom extension methods are available

namespace SCPUtils.Editors
{
    public class Scp173Editor : IScpEditor
    {
        public void TryEdit(VerifiedEventArgs ev, global::SCPUtils.Config config)
        {
            // Check if the player's role is SCP-173.
            if (ev.Player.Role is Scp173Role scp173)
            {
                // Set SCP-173's health using the configured value.
                ev.Player.Health = config.Scp173CustomHealth;
                Log.Info($"[SCPUtils] Set SCP-173's health to {config.Scp173CustomHealth} for {ev.Player.Nickname}");

                // Set a custom damage value for SCP-173.
                scp173.SetDamage(config.Scp173CustomDamage);

                // Set the attack cooldown for SCP-173.
                scp173.SetAttackCooldown(config.Scp173AttackCooldown);

                // Set the blink rate for SCP-173.
                scp173.SetBlinkRate(config.Scp173BlinkRate);
            }
        }
    }
}
