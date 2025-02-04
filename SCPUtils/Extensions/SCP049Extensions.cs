using System.Reflection;
using Exiled.API.Features;
using Exiled.API.Features.Roles;

namespace SCPUtils.Extensions
{
    public static class SCP049Extensions
    {
        /// <summary>
        /// Sets the custom damage for SCP-049 by updating its private "damage" field.
        /// </summary>
        /// <param name="role">The SCP-049 role instance.</param>
        /// <param name="damage">The new damage value.</param>
        public static void SetDamage(this Scp049Role role, int damage)
        {
            // Attempt to retrieve the private field named "damage"
            FieldInfo? field = role.GetType().GetField("damage", BindingFlags.NonPublic | BindingFlags.Instance);

            if (field != null)
            {
                // Set the field's value to the provided damage
                field.SetValue(role, damage);
                Log.Info($"[SCPUtils] Successfully set SCP-049's custom damage to {damage}");
            }
            else
            {
                // Log a warning if the field was not found
                Log.Warn("[SCPUtils] Could not set SCP-049's damage; field 'damage' not found.");
            }
        }
    }
}
