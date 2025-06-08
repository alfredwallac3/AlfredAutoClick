using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace AlfredAutoClick.Core
{
    /// <summary>
    /// Contains all configuration parameters for the auto-clicker.
    /// </summary>
    public class ClickerConfig
    {
        /// <summary>Delay in milliseconds between two bursts.</summary>
        public int ClickDelayMs { get; set; }

        /// <summary>Type of mouse button to use.</summary>
        public ClickType MouseButton { get; set; }

        /// <summary>Click behavior (multi-click or hold).</summary>
        public ClickMode ClickBehavior { get; set; }

        /// <summary>Number of clicks in one burst.</summary>
        public int ClickBurst { get; set; }

        /// <summary>Delay in milliseconds between two clicks in a burst.</summary>
        public int BurstClickDelay { get; set; }

        /// <summary>Key that activates the clicker.</summary>
        public Keys KeyActivation { get; set; }

        /// <summary>True if Ctrl must be pressed.</summary>
        public bool KeyActivationUseCtrl { get; set; }

        /// <summary>True if Alt must be pressed.</summary>
        public bool KeyActivationUseAlt { get; set; }

        /// <summary>True if Shift must be pressed.</summary>
        public bool KeyActivationUseShift { get; set; }

        /// <summary>Number of bursts before stopping.</summary>
        public int StopAfter { get; set; }

        /// <summary>Trigger mode: toggle or single trigger.</summary>
        public TriggerMode TriggerMode { get; set; }

        /// <summary>Last time this configuration was saved.</summary>
        public DateTime DateSaved { get; set; }

        /// <summary>Version of the application that saved this configuration.</summary>
        public string AppVersion { get; set; }

        /// <summary>Path to the configuration file in AppData.</summary>
        public static string ConfigPath =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AlfredAutoClick", "config.json");

        /// <summary>Initializes the config with default values.</summary>
        public ClickerConfig()
        {
            ClickDelayMs = 1000;
            MouseButton = ClickType.Left;
            ClickBehavior = ClickMode.MultiClick;
            ClickBurst = 1;
            BurstClickDelay = 50;
            KeyActivation = Keys.Add;
            KeyActivationUseCtrl = false;
            KeyActivationUseAlt = false;
            KeyActivationUseShift = false;
            StopAfter = 0;
            TriggerMode = TriggerMode.Toggle;
            DateSaved = DateTime.Now;
            AppVersion = AppInfo.Version;
        }

        /// <summary>
        /// Loads configuration from disk if it exists, otherwise returns a default config.
        /// Shows an error message if the file is corrupted or cannot be read.
        /// </summary>
        public static ClickerConfig Load()
        {
            ClickerConfig result = new ClickerConfig();
            try
            {
                if (File.Exists(ConfigPath))
                {
                    var json = File.ReadAllText(ConfigPath);
                    var loaded = JsonSerializer.Deserialize<ClickerConfig>(json);
                    if (loaded != null) result = loaded;
                }
            }
            catch (Exception ex)
            {
                // show message if reading or parsing failed
                MessageBox.Show("Error while loading configuration:\n\n" + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        /// <summary>
        /// Saves configuration to disk in AppData.
        /// Shows an error message if the file cannot be written.
        /// </summary>
        public void Save()
        {
            DateSaved = DateTime.Now;
            AppVersion = AppInfo.Version;
            try
            {
                var dir = Path.GetDirectoryName(ConfigPath);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(ConfigPath, json);
            }
            catch (Exception ex)
            {
                // show message if saving failed
                MessageBox.Show("Error while saving configuration:\n\n" + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
