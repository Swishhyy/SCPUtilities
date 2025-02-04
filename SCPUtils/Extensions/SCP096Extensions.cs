using System.Reflection;
using Exiled.API.Features;
using Exiled.API.Features.Roles;

namespace SCPUtils.Extensions
{
    public static class Scp096Extensions
    {
        /// <summary>
        /// Sets the custom damage for SCP‑096 by updating its private "damage" field.
        /// </summary>
        /// <param name="role">The SCP‑096 role instance.</param>
        /// <param name="damage">The new damage value.</param>
        public static void SetDamage(this Scp096Role role, int damage)
        {
            // Attempt to get the private field named "damage"
            FieldInfo? field = role.GetType().GetField("damage", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(role, damage);
                Log.Info($"[SCPUtils] Set SCP‑096's custom damage to {damage}");
            }
            else
            {
                Log.Warn("[SCPUtils] Could not set SCP‑096's damage; field 'damage' not found.");
            }
        }

        /// <summary>
        /// Sets the rage threshold for SCP‑096 by updating its private "rageThreshold" field.
        /// </summary>
        /// <param name="role">The SCP‑096 role instance.</param>
        /// <param name="threshold">The new rage threshold value.</param>
        public static void SetRageThreshold(this Scp096Role role, int threshold)
        {
            // Attempt to get the private field named "rageThreshold"
            FieldInfo? field = role.GetType().GetField("rageThreshold", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(role, threshold);
                Log.Info($"[SCPUtils] Set SCP‑096's rage threshold to {threshold}");
            }
            else
            {
                Log.Warn("[SCPUtils] Could not set SCP‑096's rage threshold; field 'rageThreshold' not found.");
            }
        }
    }
}
