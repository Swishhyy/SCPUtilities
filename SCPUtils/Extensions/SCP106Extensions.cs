using System.Reflection;
using Exiled.API.Features;
using Exiled.API.Features.Roles;

namespace SCPUtils.Extensions
{
    public static class Scp106RoleExtensions
    {
        /// <summary>
        /// Sets the custom damage for SCP-106 by updating its private "damage" field.
        /// </summary>
        /// <param name="role">The SCP-106 role instance.</param>
        /// <param name="damage">The new damage value.</param>
        public static void SetDamage(this Scp106Role role, int damage)
        {
            // Try to get the private field named "damage"
            FieldInfo? field = role.GetType().GetField("damage", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(role, damage);
                Log.Info($"[SCPUtils] Set SCP-106's custom damage to {damage}");
            }
            else
            {
                Log.Warn("[SCPUtils] Could not set SCP-106's damage; field 'damage' not found.");
            }
        }

        /// <summary>
        /// Sets the teleportation cooldown for SCP-106 by updating its private "teleportationCooldown" field.
        /// </summary>
        /// <param name="role">The SCP-106 role instance.</param>
        /// <param name="cooldown">The new teleportation cooldown value in seconds.</param>
        public static void SetTeleportationCooldown(this Scp106Role role, int cooldown)
        {
            // Try to get the private field named "teleportationCooldown"
            FieldInfo? field = role.GetType().GetField("teleportationCooldown", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(role, cooldown);
                Log.Info($"[SCPUtils] Set SCP-106's teleportation cooldown to {cooldown} seconds");
            }
            else
            {
                Log.Warn("[SCPUtils] Could not set SCP-106's teleportation cooldown; field 'teleportationCooldown' not found.");
            }
        }
    }
}
