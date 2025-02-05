using System;
using System.Collections.Generic;
using System.IO;
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
        private const string ConfigFilePath = "config.yml"; // Default Exiled config file

        public override void OnEnabled()
        {
            LoadOrCreateConfig();
            InitializeEditors();
            Player.Verified += OnPlayerVerified;

            if (Config.Debug)
                Log.Info($"{Name} v{Version} by {Author} has been enabled with debug mode!");
            else
                Log.Info($"{Name} v{Version} by {Author} has been enabled!");

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
            if (!File.Exists(ConfigFilePath))
            {
                Log.Warn("[SCPUtils] Config file not found. Creating a new one...");
                SaveConfig(Config); // Save the default config
            }
            else
            {
                try
                {
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();

                    var yamlContent = File.ReadAllText(ConfigFilePath);
                    var fullConfig = deserializer.Deserialize<Dictionary<string, Config>>(yamlContent);

                    if (fullConfig != null && fullConfig.ContainsKey("SCPUtils"))
                    {
                        var loadedConfig = fullConfig["SCPUtils"];

                        // Update properties of the existing Config object
                        UpdateConfig(loadedConfig);

                        Log.Info("[SCPUtils] Configuration loaded successfully.");
                    }
                    else
                    {
                        Log.Warn("[SCPUtils] 'SCPUtils' section missing. Adding defaults...");
                        SaveConfig(Config); // Save current default config
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"[SCPUtils] Error reading config file: {ex.Message}");
                    SaveConfig(Config); // Backup strategy in case of errors
                }
            }
        }

        private void UpdateConfig(Config loadedConfig)
        {
            // Use reflection to copy all properties from the loaded config
            foreach (var property in typeof(Config).GetProperties())
            {
                if (property.CanWrite)
                {
                    var value = property.GetValue(loadedConfig);
                    property.SetValue(Config, value);
                }
            }
        }

        private void SaveConfig(Config config)
        {
            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            var fullConfig = new Dictionary<string, Config>
            {
                { "SCPUtils", config }
            };

            var yamlContent = serializer.Serialize(fullConfig);
            File.WriteAllText(ConfigFilePath, yamlContent);

            Log.Info("[SCPUtils] Default configuration saved successfully.");
        }
    }
}
