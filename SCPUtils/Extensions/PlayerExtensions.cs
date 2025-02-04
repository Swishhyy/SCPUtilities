using Exiled.API.Features;

namespace SCPUtils.Extensions
{
    public static class PlayerExtensions
    {
        public static void SetMovementSpeedMultiplier(this Player player, float multiplier)
        {
            // Dummy implementation – replace with actual logic if available.
            Log.Info($"[SCPUtils] (Dummy) Setting {player.Nickname}'s movement speed multiplier to {multiplier}");
        }

        public static void SetAbilityCooldown(this Player player, int seconds)
        {
            // Dummy implementation – replace with actual logic if available.
            Log.Info($"[SCPUtils] (Dummy) Setting {player.Nickname}'s ability cooldown to {seconds} seconds");
        }

        public static void SetHeight(this Player player, float height)
        {
            // Dummy implementation – replace with actual logic if available.
            Log.Info($"[SCPUtils] (Dummy) Setting {player.Nickname}'s height to {height}");
        }
    }
}
