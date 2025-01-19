using BepInEx;
using BepInEx.Configuration;
using WeatherRegistry;
using HarmonyLib;

namespace Dusted
{
    [BepInPlugin(modGUID, modName, modVersion)]
    [BepInDependency(WeatherRegistry.Plugin.GUID, BepInDependency.DependencyFlags.HardDependency)]
    public class DustedBase : BaseUnityPlugin
    {
        private const string modGUID = "ZetaArcade.Dusted";
        private const string modName = "Dusted";
        private const string modVersion = "1.0.1";
        private readonly Harmony harmony = new Harmony(modGUID);
        private void Awake()
        {
            EventManager.SetupFinished.AddListener(OnSetupFinished);

            ConfigManager.Init(Config);

            // Plugin startup logic
            Logger.LogInfo($"Plugin is loaded!");

            harmony.PatchAll(typeof(DustedBase));
        }
        private void OnSetupFinished()
        {
            // Setup logic
            Logger.LogInfo($"Injecting weathers!");

            foreach (SelectableLevel level in ConfigManager.DustCloudsLevels.Value)
            {
                RandomWeatherWithVariables randomWeather =
                  new()
                  {
                      weatherType = LevelWeatherType.DustClouds,
                      weatherVariable = 0,
                      weatherVariable2 = 0
                  };
                Logger.LogInfo($"Injecting into " + level);
                WeatherController.AddRandomWeather(level, randomWeather);
            }
        }
    }
    public class ConfigManager
    {
        public static ConfigFile config;
        public static LevelListConfigHandler DustCloudsLevels = new("");

        public static void Init(ConfigFile configFile)
        {
            config = configFile;

            DustCloudsLevels.ConfigFile = config;
            DustCloudsLevels.SetConfigEntry(
              "DustClouds",
              "Dust Clouds Levels",
              new ConfigDescription("Levels to inject DustClouds weather into, in a semi-colon seperated list. E.g. Experimentation;Assurance;Gloom;", null)
            );
        }
    }
}
