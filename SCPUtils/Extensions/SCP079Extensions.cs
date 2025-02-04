using System.Reflection;
using Exiled.API.Features;
using Exiled.API.Features.Roles;

namespace SCPUtils.Extensions
{
    public static class Scp079Extensions
    {
        /// <summary>
        /// Sets the AP charge rate for SCP‑079 by updating its private "apChargeRate" field.
        /// </summary>
        /// <param name="role">The SCP‑079 role instance.</param>
        /// <param name="chargeRate">The new AP charge rate value.</param>
        public static void SetAPChargeRate(this Scp079Role role, float chargeRate)
        {
            // Attempt to retrieve the private field "apChargeRate" using reflection.
            FieldInfo? field = role.GetType().GetField("apChargeRate", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                // If found, set its value to the provided chargeRate.
                field.SetValue(role, chargeRate);
                Log.Info($"[SCPUtils] Set SCP‑079's AP charge rate to {chargeRate}");
            }
            else
            {
                // Log a warning if the field cannot be found.
                Log.Warn("[SCPUtils] Could not set SCP‑079's AP charge rate; field 'apChargeRate' not found.");
            }
        }
    }
}
