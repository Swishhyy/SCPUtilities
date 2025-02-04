using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Player;
using SCPUtils.Extensions; // Custom extension methods for modifying SCP role properties

namespace SCPUtils.Editors
{
    public class Scp939Editor : IScpEditor
    {
        public void TryEdit(VerifiedEventArgs ev, global::SCPUtils.Config config)
        {
            // Check if the player's role is SCP-939.
            if (ev.Player.Role is Scp939Role scp939)
            {
                // Set SCP-939's health using the configured value.
                ev.Player.Health = config.Scp939CustomHealth;
                Log.Info($"[SCPUtils] Set SCP-939's health to {config.Scp939CustomHealth} for {ev.Player.Nickname}");

                // Set a custom damage value.
                scp939.SetDamage(config.Scp939CustomDamage);

                // Set the attack cooldown (between regular attacks).
                scp939.SetAttackCooldown(config.Scp939AttackCooldown);

                // Set the detection range.
                scp939.SetDetectionRange(config.Scp939DetectionRange);

                // Set the ability cooldown.
                scp939.SetAbilityCooldown(config.Scp939AbilityCooldown);

                // Set the stamina.
                scp939.SetStamina(config.Scp939Stamina);
            }
        }
    }
}
