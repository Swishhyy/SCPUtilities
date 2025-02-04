using System.Reflection;
using Exiled.API.Features;
using Exiled.API.Features.Roles;

namespace SCPUtils.Extensions
{
    public static class Scp173Extensions
    {
        /// <summary>
        /// Sets the custom damage for SCP-173 by updating its private "damage" field.
        /// </summary>
        /// <param name="role">The SCP-173 role instance.</param>
        /// <param name="damage">The new damage value.</param>
        public static void SetDamage(this Scp173Role role, int damage)
        {
            // Attempt to get the private field named "damage".
            FieldInfo? field = role.GetType().GetField("damage", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(role, damage);
                Log.Info($"[SCPUtils] Set SCP-173's custom damage to {damage}");
            }
            else
            {
                Log.Warn("[SCPUtils] Could not set SCP-173's damage; field 'damage' not found.");
            }
        }

        /// <summary>
        /// Sets the attack cooldown for SCP-173 by updating its private "attackCooldown" field.
        /// </summary>
        /// <param name="role">The SCP-173 role instance.</param>
        /// <param name="cooldown">The new attack cooldown in seconds.</param>
        public static void SetAttackCooldown(this Scp173Role role, int cooldown)
        {
            // Attempt to get the private field named "attackCooldown".
            FieldInfo? field = role.GetType().GetField("attackCooldown", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(role, cooldown);
                Log.Info($"[SCPUtils] Set SCP-173's attack cooldown to {cooldown} seconds");
            }
            else
            {
                Log.Warn("[SCPUtils] Could not set SCP-173's attack cooldown; field 'attackCooldown' not found.");
            }
        }

        /// <summary>
        /// Sets the blink rate for SCP-173 by updating its private "blinkRate" field.
        /// </summary>
        /// <param name="role">The SCP-173 role instance.</param>
        /// <param name="blinkRate">The new blink rate value.</param>
        public static void SetBlinkRate(this Scp173Role role, float blinkRate)
        {
            // Attempt to get the private field named "blinkRate".
            FieldInfo? field = role.GetType().GetField("blinkRate", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(role, blinkRate);
                Log.Info($"[SCPUtils] Set SCP-173's blink rate to {blinkRate}");
            }
            else
            {
                Log.Warn("[SCPUtils] Could not set SCP-173's blink rate; field 'blinkRate' not found.");
            }
        }
    }
}
