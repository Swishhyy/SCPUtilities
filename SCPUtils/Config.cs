using Exiled.API.Interfaces;

namespace SCPUtils
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true; // Enables or disables the plugin

        // SCP-049
        public int Scp049CustomHealth { get; set; } = 500;
        public float Scp049MovementSpeedMultiplier { get; set; } = 1.0f;
        public int Scp049CustomDamage { get; set; } = 50;
        public int Scp049AbilityCooldown { get; set; } = 10;
        public float Scp049Height { get; set; } = 2.0f;
        public int Scp049HumeShieldStart { get; set; } = 100;
        public int Scp049HumeShieldRegen { get; set; } = 5;

        // SCP-049-2
        public int Scp0492CustomHealth { get; set; } = 2300;
        public float Scp0492MovementSpeedMultiplier { get; set; } = 1.0f;
        public int Scp0492CustomDamage { get; set; } = 40;
        public int Scp0492AbilityCooldown { get; set; } = 12;
        public float Scp0492Height { get; set; } = 1.8f;
        public int Scp0492HumeShieldStart { get; set; } = 150;
        public int Scp0492HumeShieldRegen { get; set; } = 4;

        // SCP-079
        public float Scp079DamageMultiplier { get; set; } = 1.2f;
        public int Scp079AbilityCooldown { get; set; } = 15;
        public float Scp079APChargeRate { get; set; } = 1.0f;

        // SCP-096 
        public int Scp096CustomHealth { get; set; } = 550;
        public int Scp096CustomDamage { get; set; } = 70;
        public int Scp096AbilityCooldown { get; set; } = 8;
        public int Scp096RageThreshold { get; set; } = 3;
        public int Scp096HumeShieldStart { get; set; } = 200;
        public int Scp096HumeShieldRegen { get; set; } = 6;
        public float Scp096DistressCalmSpeed { get; set; } = 2.55f; 
        public float Scp096DocileSpeed { get; set; } = 3.9f;       
        public float Scp096ChargeSpeed { get; set; } = 18.5f;

        // SCP-106
        public int Scp106CustomHealth { get; set; } = 650;
        public int Scp106CustomDamage { get; set; } = 55;
        public int Scp106AbilityCooldown { get; set; } = 20;
        public int Scp106TeleportCooldown { get; set; } = 30;
        public int Scp106HumeShieldStart { get; set; } = 180;
        public int Scp106HumeShieldRegen { get; set; } = 5;

        // SCP-173
        public int Scp173CustomHealth { get; set; } = 500;
        public int Scp173CustomDamage { get; set; } = 60;
        public int Scp173AttackCooldown { get; set; } = 5;
        public float Scp173BlinkRate { get; set; } = 1.5f;
        public int Scp173HumeShieldStart { get; set; } = 120;
        public int Scp173HumeShieldRegen { get; set; } = 3;

        // SCP-939
        public int Scp939CustomHealth { get; set; } = 600;
        public int Scp939CustomDamage { get; set; } = 55;
        public int Scp939AttackCooldown { get; set; } = 7;
        public float Scp939DetectionRange { get; set; } = 15.0f;
        public int Scp939AbilityCooldown { get; set; } = 8;
        public int Scp939Stamina { get; set; } = 100;
        public int Scp939HumeShieldStart { get; set; } = 160;
        public int Scp939HumeShieldRegen { get; set; } = 4;

        public bool Debug { get; set; } = false;
    }
}
