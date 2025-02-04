using System.Reflection;
using Exiled.API.Features;

namespace SCPUtils.Extensions
{
    public static class PlayerExtensions
    {
        /// <summary>
        /// Sets the movement speed multiplier for the player.
        /// </summary>
        /// <param name="player">The player instance.</param>
        /// <param name="multiplier">The new movement speed multiplier.</param>
        public static void SetMovementSpeedMultiplier(this Player player, float multiplier)
        {
            FieldInfo? field = player.GetType().GetField("movementSpeed", BindingFlags.NonPublic | BindingFlags.Instance);

            if (field != null)
            {
                field.SetValue(player, multiplier);
                Log.Info($"[SCPUtils] Successfully set {player.Nickname}'s movement speed multiplier to {multiplier}");
            }
            else
            {
                Log.Warn($"[SCPUtils] Could not set {player.Nickname}'s movement speed multiplier; field 'movementSpeed' not found.");
            }
        }

        /// <summary>
        /// Sets the ability cooldown for the player.
        /// </summary>
        /// <param name="player">The player instance.</param>
        /// <param name="seconds">The cooldown time in seconds.</param>
        public static void SetAbilityCooldown(this Player player, int seconds)
        {
            FieldInfo? field = player.GetType().GetField("abilityCooldown", BindingFlags.NonPublic | BindingFlags.Instance);

            if (field != null)
            {
                field.SetValue(player, seconds);
                Log.Info($"[SCPUtils] Successfully set {player.Nickname}'s ability cooldown to {seconds} seconds");
            }
            else
            {
                Log.Warn($"[SCPUtils] Could not set {player.Nickname}'s ability cooldown; field 'abilityCooldown' not found.");
            }
        }

        /// <summary>
        /// Sets the player's height (scale).
        /// </summary>
        /// <param name="player">The player instance.</param>
        /// <param name="height">The new height value.</param>
        public static void SetHeight(this Player player, float height)
        {
            FieldInfo? field = player.GetType().GetField("height", BindingFlags.NonPublic | BindingFlags.Instance);

            if (field != null)
            {
                field.SetValue(player, height);
                Log.Info($"[SCPUtils] Successfully set {player.Nickname}'s height to {height}");
            }
            else
            {
                Log.Warn($"[SCPUtils] Could not set {player.Nickname}'s height; field 'height' not found.");
            }
        }
    }
}
