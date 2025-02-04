using Exiled.API.Features;
using Exiled.API.Features.Roles;

namespace SCPUtils.Extensions
{
    public static class Scp173Extensions
    {
        /// <summary>
        /// Dummy implementation to simulate setting a custom damage value for SCP-173.
        /// Replace with actual logic if available.
        /// </summary>
        public static void SetDamage(this Scp173Role role, int damage)
        {
            Log.Info($"[SCPUtils] (Dummy) Setting SCP-173's custom damage to {damage}");
        }

        /// <summary>
        /// Dummy implementation to simulate setting the attack cooldown for SCP-173.
        /// Replace with actual logic if available.
        /// </summary>
        public static void SetAttackCooldown(this Scp173Role role, int cooldown)
        {
            Log.Info($"[SCPUtils] (Dummy) Setting SCP-173's attack cooldown to {cooldown} seconds");
        }

        /// <summary>
        /// Dummy implementation to simulate setting the blink rate for SCP-173.
        /// Replace with actual logic if available.
        /// </summary>
        public static void SetBlinkRate(this Scp173Role role, float blinkRate)
        {
            Log.Info($"[SCPUtils] (Dummy) Setting SCP-173's blink rate to {blinkRate}");
        }
    }
}
