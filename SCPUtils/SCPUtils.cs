using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using SCPUtils.Editors;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using Player = Exiled.Events.Handlers.Player;

namespace SCPUtils
{
    public class SCPUtilsPlugin : Plugin<Config>
    {
        public override string Name => "SCPUtils";
        public override string Author => "Swishhyy";
        public override Version Version => new Version(1, 0, 0);

        private readonly List<IScpEditor> scpEditors = new List<IScpEditor>();

        private string GetConfigFilePath()
        {
            // Dynamically locate the config file within /EXILED/Configs/
            string? exiledConfigPath = Directory.GetDirectories("/", "*EXILED*", SearchOption.AllDirectories)
                                                .FirstOrDefault(path => Directory.Exists(Path.Combine(path, "Configs")));

            if (!string.IsNullOrEmpty(exiledConfigPath))
            {
                string configDir = Path.Combine(exiledConfigPath, "Configs");
                string? configFile = Directory.GetFiles(configDir, "*-config.yml").FirstOrDefault();

                // Fallback to default-config.yml if configFile is null
                return configFile ?? Path.Combine(configDir, "default-config.yml");
            }

            Log.Warn("[SCPUtils] Could not find the EXILED config directory. Using fallback path.");
            return "default-config.yml";
        }


        public override void OnEnabled()
        {
            LoadOrCreateConfig();
            InitializeEditors();
            Player.Verified += OnPlayerVerified;

            Log.Info($"{Name} v{Version} by {Author} has been enabled{(Config.Debug ? " with debug mode!" : "!")}");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.Verified -= OnPlayerVerified;
            Log.Info($"{Name} has been disabled!");
            base.OnDisabled();
        }

        private void InitializeEditors()
        {
            scpEditors.Clear();
            scpEditors.AddRange(new IScpEditor[]
            {
                new Scp049Editor(),
                new Scp0492Editor(),
                new Scp079Editor(),
                new Scp096Editor(),
                new Scp106Editor(),
                new Scp173Editor(),
                new Scp939Editor()
            });
        }

        private void OnPlayerVerified(VerifiedEventArgs ev)
        {
            foreach (var editor in scpEditors)
            {
                editor.TryEdit(ev, Config);
            }
        }

        private void LoadOrCreateConfig()
        {
            string configFilePath = GetConfigFilePath();

            if (!File.Exists(configFilePath))
            {
                Log.Warn("[SCPUtils] Config file not found. Creating a new one...");
                SaveConfig(Config, configFilePath);
            }
            else
            {
                try
                {
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();

                    var yamlContent = File.ReadAllText(configFilePath);
                    var fullConfig = deserializer.Deserialize<Dictionary<string, object>>(yamlContent);

                    if (fullConfig != null && fullConfig.ContainsKey("SCPUtils"))
                    {
                        Log.Info("[SCPUtils] Configuration loaded successfully.");
                    }
                    else
                    {
                        Log.Warn("[SCPUtils] 'SCPUtils' section missing. Adding defaults...");
                        fullConfig ??= new Dictionary<string, object>();
                        fullConfig["SCPUtils"] = Config;

                        SaveConfig(Config, configFilePath);
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"[SCPUtils] Error reading config file: {ex.Message}");
                    SaveConfig(Config, configFilePath);
                }
            }
        }

        private void SaveConfig(Config config, string configFilePath)
        {
            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            var yamlContent = File.Exists(configFilePath)
                ? File.ReadAllText(configFilePath)
                : string.Empty;

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            var fullConfig = string.IsNullOrWhiteSpace(yamlContent)
                ? new Dictionary<string, object>()
                : deserializer.Deserialize<Dictionary<string, object>>(yamlContent);

            fullConfig["SCPUtils"] = config;

            var updatedYaml = serializer.Serialize(fullConfig);
            File.WriteAllText(configFilePath, updatedYaml);

            Log.Info("[SCPUtils] Configuration saved successfully.");
        }
    }
}
