using System.Reflection;
using Exiled.API.Features;
using Exiled.API.Features.Roles;

namespace SCPUtils.Extensions
{
    public static class Scp0492Extensions
    {
        /// <summary>
        /// Sets the custom damage for SCP-049-2 by updating its private "damage" field.
        /// </summary>
        /// <param name="role">The SCP-049-2 role instance.</param>
        /// <param name="damage">The new damage value.</param>
        public static void SetDamage(this Scp0492Role role, int damage)
        {
            // Attempt to retrieve the private field named "damage"
            FieldInfo? field = role.GetType().GetField("damage", BindingFlags.NonPublic | BindingFlags.Instance);

            if (field != null)
            {
                // Set the field's value to the provided damage
                field.SetValue(role, damage);
                Log.Info($"[SCPUtils] Successfully set SCP-049-2's custom damage to {damage}");
            }
            else
            {
                // Log a warning if the field was not found
                Log.Warn("[SCPUtils] Could not set SCP-049-2's damage; field 'damage' not found.");
            }
        }
    }
}
