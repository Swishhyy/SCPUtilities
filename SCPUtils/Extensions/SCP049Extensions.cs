using Exiled.API.Features.Roles;

namespace SCPUtils.Extensions
{
    public static class SCP049Extensions
    {
        /// <summary>
        /// Dummy implementation to simulate setting a custom damage value for SCP-049.
        /// Replace with actual logic if available.
        /// </summary>
        public static void SetDamage(this Scp049Role role, int damage)
        {
            // For now, simply log the intended change.
            Exiled.API.Features.Log.Info($"[SCPUtils] (Dummy) Setting SCP-049's custom damage to {damage}");
        }
    }
}
