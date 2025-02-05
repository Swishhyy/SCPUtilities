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

        // Dynamically detect the server port (fallback to 7777 if undetectable)
        private static readonly int ServerPort = Server.Port > 0 ? Server.Port : 7777;
        private static readonly string ConfigFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".config", "EXILED", "Configs", $"{ServerPort}-config.yml");

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
                Log.Warn($"[SCPUtils] Config file '{ConfigFilePath}' not found. Creating a new one...");
                SaveConfig(new Config());
            }
            else
            {
                try
                {
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();

                    var yamlContent = File.ReadAllText(ConfigFilePath);
                    var existingConfig = deserializer.Deserialize<Dictionary<string, object>>(yamlContent);

                    if (existingConfig != null && existingConfig.ContainsKey("SCPUtils"))
                    {
                        var scpUtilsConfig = deserializer.Deserialize<Config>(existingConfig["SCPUtils"].ToString());
                        UpdateConfig(scpUtilsConfig);
                        Log.Info("[SCPUtils] Configuration loaded successfully.");
                    }
                    else
                    {
                        Log.Warn("[SCPUtils] 'SCPUtils' section missing. Adding defaults...");
                        SaveConfig(new Config());
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"[SCPUtils] Error reading config file: {ex.Message}");
                    SaveConfig(new Config());
                }
            }
        }

        private void UpdateConfig(Config loadedConfig)
        {
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

            Dictionary<string, object> existingConfig;

            // Load existing YAML content
            if (File.Exists(ConfigFilePath))
            {
                var yamlContent = File.ReadAllText(ConfigFilePath);
                existingConfig = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .Build()
                    .Deserialize<Dictionary<string, object>>(yamlContent);
            }
            else
            {
                existingConfig = new Dictionary<string, object>();
            }

            // Add or update the SCPUtils section
            existingConfig["SCPUtils"] = config;

            var yamlOutput = serializer.Serialize(existingConfig);
            File.WriteAllText(ConfigFilePath, yamlOutput);

            Log.Info($"[SCPUtils] Configuration saved successfully to '{ConfigFilePath}'.");
        }
    }
}
