using Exiled.API.Interfaces;

namespace SCPUtils
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true; // Enables or disables the plugin

        public int Scp049CustomHealth { get; set; } = 500; // SCP-049's health
        public float Scp049MovementSpeedMultiplier { get; set; } = 1.0f; // SCP-049's speed multiplier
        public int Scp049CustomDamage { get; set; } = 50; // SCP-049's damage per hit
        public int Scp049AbilityCooldown { get; set; } = 10; // Cooldown time for SCP-049's abilities (seconds)
        public float Scp049Height { get; set; } = 2.0f; // SCP-049's height

        public int Scp0492CustomHealth { get; set; } = 2300; // SCP-049-2's health
        public float Scp0492MovementSpeedMultiplier { get; set; } = 1.0f; // SCP-049-2's speed multiplier
        public int Scp0492CustomDamage { get; set; } = 40; // SCP-049-2's damage per hit
        public int Scp0492AbilityCooldown { get; set; } = 12; // Cooldown time for SCP-049-2's abilities (seconds)
        public float Scp0492Height { get; set; } = 1.8f; // SCP-049-2's height

        public int Scp079CustomHealth { get; set; } = 600; // SCP-079's health (if applicable)
        public float Scp079DamageMultiplier { get; set; } = 1.2f; // SCP-079's damage multiplier
        public int Scp079AbilityCooldown { get; set; } = 15; // Cooldown time for SCP-079's abilities (seconds)
        public float Scp079APChargeRate { get; set; } = 1.0f; // SCP-079's AP charge rate

        public int Scp096CustomHealth { get; set; } = 550; // SCP-096's health
        public int Scp096CustomDamage { get; set; } = 70; // SCP-096's damage per hit
        public int Scp096AbilityCooldown { get; set; } = 8; // Cooldown time for SCP-096's abilities (seconds)
        public int Scp096RageThreshold { get; set; } = 3; // Number of targets needed to trigger SCP-096's rage

        public int Scp106CustomHealth { get; set; } = 650; // SCP-106's health
        public int Scp106CustomDamage { get; set; } = 55; // SCP-106's damage per hit
        public int Scp106AbilityCooldown { get; set; } = 20; // Cooldown time for SCP-106's abilities (seconds)
        public int Scp106TeleportCooldown { get; set; } = 30; // Cooldown for SCP-106's teleportation ability (seconds)

        public int Scp173CustomHealth { get; set; } = 500; // SCP-173's health
        public int Scp173CustomDamage { get; set; } = 60; // SCP-173's damage per hit
        public int Scp173AttackCooldown { get; set; } = 5; // Time between SCP-173's attacks (seconds)
        public float Scp173BlinkRate { get; set; } = 1.5f; // SCP-173's blink rate (frequency of movement opportunities)

        public int Scp939CustomHealth { get; set; } = 600; // SCP-939's health
        public int Scp939CustomDamage { get; set; } = 55; // SCP-939's damage per hit
        public int Scp939AttackCooldown { get; set; } = 7; // Time between SCP-939's attacks (seconds)
        public float Scp939DetectionRange { get; set; } = 15.0f; // SCP-939's player detection range
        public int Scp939AbilityCooldown { get; set; } = 8; // Cooldown time for SCP-939's abilities (seconds)
        public int Scp939Stamina { get; set; } = 100; // SCP-939's stamina value

        public bool Debug { get; set; } = false; // Enables verbose logging for debugging
    }
}
