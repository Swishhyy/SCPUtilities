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
            if (ev.Player.Role is Scp939Role scp939)
            {
                // Set SCP-939's health
                ev.Player.Health = config.Scp939CustomHealth;

                if (config.Debug)
                    Log.Info($"[SCPUtils] Set SCP-939's health to {config.Scp939CustomHealth} for {ev.Player.Nickname}");

                // Apply custom stats
                scp939.SetDamage(config.Scp939CustomDamage);
                scp939.SetAttackCooldown(config.Scp939AttackCooldown);
                scp939.SetDetectionRange(config.Scp939DetectionRange);
                scp939.SetAbilityCooldown(config.Scp939AbilityCooldown);
                scp939.SetStamina(config.Scp939Stamina);

                // Apply Hume Shield (using Player Extensions)
                ev.Player.SetHumeShield(config.Scp939HumeShieldStart);
                ev.Player.SetHumeShieldRegen(config.Scp939HumeShieldRegen);

                if (config.Debug)
                    Log.Info($"[SCPUtils] Set Hume Shield to {config.Scp939HumeShieldStart} with regen {config.Scp939HumeShieldRegen} for {ev.Player.Nickname}");
            }
        }
    }
}
