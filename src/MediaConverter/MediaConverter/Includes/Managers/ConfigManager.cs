using System.IO;
using System.Text;
using static MediaConverter.Data.Structure.ConfigStructure;

namespace MediaConverter.Managers
{
    public static class ConfigManager
    {
        public static void WriteConfig(ConfigBase config)
        {
            var sb = new StringBuilder();
            foreach (var field in typeof(ConfigBase).GetFields())
            {
                object value = field.GetValue(config);
                if (value != null)
                    sb.Append(field.Name + "¶" + value.ToString());
                sb.Append("\n");
            }
            sb.Length--;
            File.WriteAllText("MediaConverter\\config\\config.mc", sb.ToString());
        }

        public static ConfigBase ReadConfig()
        {
            ConfigBase config = new ConfigBase();

            string configFile = File.ReadAllText("MediaConverter\\config\\config.mc");
            string[] configSetting = configFile.Split('\n');

            for (int i = 0; i < configSetting.Length; i++)
            {
                string[] configSettingPair = configSetting[i].Split('¶');

                switch (configSettingPair[0])
                {
                    case "QUEUE_ITEM_ORDER": config.QUEUE_ITEM_ORDER = configSettingPair[1]; break;
                    case "QUEUE_ITEM_SELECTIONS": config.QUEUE_ITEM_SELECTIONS = configSettingPair[1]; break;

                    case "THEME_COLOR_R": config.THEME_COLOR_R = int.Parse(configSettingPair[1]); break;
                    case "THEME_COLOR_G": config.THEME_COLOR_G = int.Parse(configSettingPair[1]); break;
                    case "THEME_COLOR_B": config.THEME_COLOR_B = int.Parse(configSettingPair[1]); break;
                }
            }

            return config;
        }
    }
}