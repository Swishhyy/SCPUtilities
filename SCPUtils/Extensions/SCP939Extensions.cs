using System.Reflection;
using Exiled.API.Features;
using Exiled.API.Features.Roles;

namespace SCPUtils.Extensions
{
    public static class Scp939Extensions
    {
        /// <summary>
        /// Sets the custom damage for SCP-939 by updating its private "damage" field.
        /// </summary>
        /// <param name="role">The SCP-939 role instance.</param>
        /// <param name="damage">The new damage value.</param>
        public static void SetDamage(this Scp939Role role, int damage)
        {
            // Attempt to get the private field named "damage"
            FieldInfo? field = role.GetType().GetField("damage", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(role, damage);
                Log.Info($"[SCPUtils] Set SCP-939's custom damage to {damage}");
            }
            else
            {
                Log.Warn("[SCPUtils] Could not set SCP-939's damage; field 'damage' not found.");
            }
        }

        /// <summary>
        /// Sets the attack cooldown for SCP-939 by updating its private "attackCooldown" field.
        /// </summary>
        /// <param name="role">The SCP-939 role instance.</param>
        /// <param name="cooldown">The new attack cooldown in seconds.</param>
        public static void SetAttackCooldown(this Scp939Role role, int cooldown)
        {
            FieldInfo? field = role.GetType().GetField("attackCooldown", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(role, cooldown);
                Log.Info($"[SCPUtils] Set SCP-939's attack cooldown to {cooldown} seconds");
            }
            else
            {
                Log.Warn("[SCPUtils] Could not set SCP-939's attack cooldown; field 'attackCooldown' not found.");
            }
        }

        /// <summary>
        /// Sets the detection range for SCP-939 by updating its private "detectionRange" field.
        /// </summary>
        /// <param name="role">The SCP-939 role instance.</param>
        /// <param name="range">The new detection range in units.</param>
        public static void SetDetectionRange(this Scp939Role role, float range)
        {
            FieldInfo? field = role.GetType().GetField("detectionRange", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(role, range);
                Log.Info($"[SCPUtils] Set SCP-939's detection range to {range}");
            }
            else
            {
                Log.Warn("[SCPUtils] Could not set SCP-939's detection range; field 'detectionRange' not found.");
            }
        }

        /// <summary>
        /// Sets the ability cooldown for SCP-939 by updating its private "abilityCooldown" field.
        /// </summary>
        /// <param name="role">The SCP-939 role instance.</param>
        /// <param name="cooldown">The new ability cooldown in seconds.</param>
        public static void SetAbilityCooldown(this Scp939Role role, int cooldown)
        {
            FieldInfo? field = role.GetType().GetField("abilityCooldown", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(role, cooldown);
                Log.Info($"[SCPUtils] Set SCP-939's ability cooldown to {cooldown} seconds");
            }
            else
            {
                Log.Warn("[SCPUtils] Could not set SCP-939's ability cooldown; field 'abilityCooldown' not found.");
            }
        }

        /// <summary>
        /// Sets the stamina for SCP-939 by updating its private "stamina" field.
        /// </summary>
        /// <param name="role">The SCP-939 role instance.</param>
        /// <param name="stamina">The new stamina value.</param>
        public static void SetStamina(this Scp939Role role, int stamina)
        {
            FieldInfo? field = role.GetType().GetField("stamina", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(role, stamina);
                Log.Info($"[SCPUtils] Set SCP-939's stamina to {stamina}");
            }
            else
            {
                Log.Warn("[SCPUtils] Could not set SCP-939's stamina; field 'stamina' not found.");
            }
        }
    }
}
