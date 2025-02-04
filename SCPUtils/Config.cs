using Exiled.API.Interfaces;

namespace SCPUtils
{
    /// <summary>
    /// Global configuration for the SCPUtils plugin.
    /// These settings allow server administrators to customize various properties for each SCP type.
    /// </summary>
    public class Config : IConfig
    {
        // ------------------------------------------------------------------------------------
        // Global Settings
        // ------------------------------------------------------------------------------------

        /// <summary>
        /// Determines if the plugin is enabled. If false, the plugin will not run.
        /// </summary>
        public bool IsEnabled { get; set; } = true;

        // ------------------------------------------------------------------------------------
        // SCP-049 Configuration
        // ------------------------------------------------------------------------------------

        /// <summary>
        /// Custom health value for SCP-049. This value is applied when a player is assigned the SCP-049 role.
        /// </summary>
        public int Scp049CustomHealth { get; set; } = 500;

        /// <summary>
        /// Movement speed multiplier for SCP-049. Multiplies the base movement speed.
        /// </summary>
        public float Scp049MovementSpeedMultiplier { get; set; } = 1.0f;

        /// <summary>
        /// Custom damage value for SCP-049. Determines how much damage SCP-049 inflicts.
        /// </summary>
        public int Scp049CustomDamage { get; set; } = 50;

        /// <summary>
        /// Ability cooldown for SCP-049 in seconds. The delay between uses of SCP-049's abilities.
        /// </summary>
        public int Scp049AbilityCooldown { get; set; } = 10;  // Ability cooldown in seconds.

        /// <summary>
        /// Height for SCP-049 in units. May affect model scaling or collision properties.
        /// </summary>
        public float Scp049Height { get; set; } = 2.0f;         // Height in units.

        // ------------------------------------------------------------------------------------
        // SCP-049-2 Configuration
        // ------------------------------------------------------------------------------------

        /// <summary>
        /// Custom health value for SCP-049-2.
        /// </summary>
        public int Scp0492CustomHealth { get; set; } = 400;

        /// <summary>
        /// Movement speed multiplier for SCP-049-2.
        /// </summary>
        public float Scp0492MovementSpeedMultiplier { get; set; } = 1.0f;

        /// <summary>
        /// Custom damage value for SCP-049-2.
        /// </summary>
        public int Scp0492CustomDamage { get; set; } = 40;

        /// <summary>
        /// Ability cooldown for SCP-049-2 in seconds.
        /// </summary>
        public int Scp0492AbilityCooldown { get; set; } = 12;   // Ability cooldown in seconds.

        /// <summary>
        /// Height for SCP-049-2 in units.
        /// </summary>
        public float Scp0492Height { get; set; } = 1.8f;          // Height in units.

        // ------------------------------------------------------------------------------------
        // SCP-079 Configuration
        // ------------------------------------------------------------------------------------

        /// <summary>
        /// Custom health value for SCP-079.
        /// </summary>
        public int Scp079CustomHealth { get; set; } = 600;

        /// <summary>
        /// Damage multiplier for SCP-079. This property might be used if SCP-079’s damage is modifiable.
        /// </summary>
        public float Scp079DamageMultiplier { get; set; } = 1.2f; // (If needed; not used in this example)

        /// <summary>
        /// Ability cooldown for SCP-079 in seconds.
        /// </summary>
        public int Scp079AbilityCooldown { get; set; } = 15;      // Ability cooldown in seconds.

        /// <summary>
        /// AP (Anomalous Power) charge rate for SCP-079.
        /// </summary>
        public float Scp079APChargeRate { get; set; } = 1.0f;       // AP charge rate.

        // ------------------------------------------------------------------------------------
        // SCP-096 Configuration
        // ------------------------------------------------------------------------------------

        /// <summary>
        /// Custom health value for SCP-096.
        /// </summary>
        public int Scp096CustomHealth { get; set; } = 550;

        /// <summary>
        /// Custom damage value for SCP-096.
        /// </summary>
        public int Scp096CustomDamage { get; set; } = 70;

        /// <summary>
        /// Ability cooldown for SCP-096 in seconds.
        /// </summary>
        public int Scp096AbilityCooldown { get; set; } = 8;      // Cooldown in seconds.

        /// <summary>
        /// Rage threshold for SCP-096. For example, the number of targets needed to trigger rage.
        /// </summary>
        public int Scp096RageThreshold { get; set; } = 3;          // Example threshold value.

        // ------------------------------------------------------------------------------------
        // SCP-106 Configuration
        // ------------------------------------------------------------------------------------

        /// <summary>
        /// Custom health value for SCP-106.
        /// </summary>
        public int Scp106CustomHealth { get; set; } = 650;

        /// <summary>
        /// Custom damage value for SCP-106.
        /// </summary>
        public int Scp106CustomDamage { get; set; } = 55;

        /// <summary>
        /// Ability cooldown for SCP-106 in seconds.
        /// </summary>
        public int Scp106AbilityCooldown { get; set; } = 20;       // Cooldown in seconds.

        /// <summary>
        /// Teleportation cooldown for SCP-106 in seconds.
        /// </summary>
        public int Scp106TeleportCooldown { get; set; } = 30;       // Teleportation cooldown in seconds.

        // ------------------------------------------------------------------------------------
        // SCP-173 Configuration
        // ------------------------------------------------------------------------------------

        /// <summary>
        /// Custom health value for SCP-173.
        /// </summary>
        public int Scp173CustomHealth { get; set; } = 500;

        /// <summary>
        /// Custom damage value for SCP-173.
        /// </summary>
        public int Scp173CustomDamage { get; set; } = 60;  // Added semicolon below.

        /// <summary>
        /// Attack cooldown for SCP-173 in seconds between attacks.
        /// </summary>
        public int Scp173AttackCooldown { get; set; } = 5;    // Cooldown in seconds between attacks.

        /// <summary>
        /// Blink rate for SCP-173. Determines how frequently SCP-173 "blinks" (i.e., resets its position when unobserved).
        /// </summary>
        public float Scp173BlinkRate { get; set; } = 1.5f;      // Blink rate.

        // ------------------------------------------------------------------------------------
        // SCP-939 Configuration
        // ------------------------------------------------------------------------------------

        /// <summary>
        /// Custom health value for SCP-939.
        /// </summary>
        public int Scp939CustomHealth { get; set; } = 600;

        /// <summary>
        /// Custom damage value for SCP-939.
        /// </summary>
        public int Scp939CustomDamage { get; set; } = 55;

        /// <summary>
        /// Attack cooldown for SCP-939 in seconds.
        /// </summary>
        public int Scp939AttackCooldown { get; set; } = 7;

        /// <summary>
        /// Detection range for SCP-939 in units.
        /// </summary>
        public float Scp939DetectionRange { get; set; } = 15.0f;

        /// <summary>
        /// Ability cooldown for SCP-939 in seconds. Controls the delay between using special abilities.
        /// </summary>
        public int Scp939AbilityCooldown { get; set; } = 8;  // New ability cooldown property.

        /// <summary>
        /// Stamina for SCP-939. A configurable value that might affect how long SCP-939 can use its abilities or chase targets.
        /// </summary>
        public int Scp939Stamina { get; set; } = 100;         // New stamina property.

        // ------------------------------------------------------------------------------------
        // Debug Settings
        // ------------------------------------------------------------------------------------

        /// <summary>
        /// Debug mode flag. Set to true to enable verbose logging for troubleshooting.
        /// </summary>
        public bool Debug { get; set; } = false;

        // ------------------------------------------------------------------------------------
        // Additional SCP types
        // ------------------------------------------------------------------------------------
        // Add additional properties for other SCP types as needed.
    }
}
