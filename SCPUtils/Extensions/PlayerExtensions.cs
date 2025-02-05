using System.Reflection;
using Exiled.API.Features;

namespace SCPUtils.Extensions
{
    public static class PlayerExtensions
    {
        /// <summary>
        /// Sets the movement speed multiplier for the player.
        /// </summary>
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

        /// <summary>
        /// Sets the Hume Shield value for the player.
        /// </summary>
        public static void SetHumeShield(this Player player, int shieldValue)
        {
            FieldInfo? field = player.GetType().GetField("humeShield", BindingFlags.NonPublic | BindingFlags.Instance);

            if (field != null)
            {
                field.SetValue(player, shieldValue);
                Log.Info($"[SCPUtils] Successfully set {player.Nickname}'s Hume Shield to {shieldValue}");
            }
            else
            {
                Log.Warn($"[SCPUtils] Could not set {player.Nickname}'s Hume Shield; field 'humeShield' not found.");
            }
        }

        /// <summary>
        /// Sets the Hume Shield regeneration rate for the player.
        /// </summary>
        public static void SetHumeShieldRegen(this Player player, int regenRate)
        {
            FieldInfo? field = player.GetType().GetField("humeShieldRegen", BindingFlags.NonPublic | BindingFlags.Instance);

            if (field != null)
            {
                field.SetValue(player, regenRate);
                Log.Info($"[SCPUtils] Successfully set {player.Nickname}'s Hume Shield regeneration rate to {regenRate}");
            }
            else
            {
                Log.Warn($"[SCPUtils] Could not set {player.Nickname}'s Hume Shield regen rate; field 'humeShieldRegen' not found.");
            }
        }
    }
}
