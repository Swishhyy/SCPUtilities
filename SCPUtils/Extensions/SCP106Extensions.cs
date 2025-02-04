using Exiled.API.Features;
using Exiled.API.Features.Roles;

namespace SCPUtils.Extensions
{
    public static class Scp106RoleExtensions
    {
        public static void SetDamage(this Scp106Role role, int damage)
        {
            // Dummy implementation – replace with actual logic if available.
            Log.Info($"[SCPUtils] (Dummy) Setting SCP-106's custom damage to {damage}");
        }

        public static void SetTeleportationCooldown(this Scp106Role role, int cooldown)
        {
            // Dummy implementation – replace with actual logic if available.
            Log.Info($"[SCPUtils] (Dummy) Setting SCP-106's teleportation cooldown to {cooldown} seconds");
        }
    }
}
