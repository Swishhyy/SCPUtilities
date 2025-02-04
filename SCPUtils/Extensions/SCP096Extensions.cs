using Exiled.API.Features;
using Exiled.API.Features.Roles;

namespace SCPUtils.Extensions
{
    public static class Scp096Extensions
    {
        /// <summary>
        /// Dummy implementation to simulate setting a custom damage value for SCP-096.
        /// Replace with actual logic if available.
        /// </summary>
        public static void SetDamage(this Scp096Role role, int damage)
        {
            Log.Info($"[SCPUtils] (Dummy) Setting SCP-096's custom damage to {damage}");
        }

        /// <summary>
        /// Dummy implementation to simulate setting the rage threshold for SCP-096.
        /// Replace with actual logic if available.
        /// </summary>
        public static void SetRageThreshold(this Scp096Role role, int threshold)
        {
            Log.Info($"[SCPUtils] (Dummy) Setting SCP-096's rage threshold to {threshold}");
        }
    }
}
