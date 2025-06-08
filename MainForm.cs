using AlfredAutoClick.Core;
using AlfredAutoClick.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace AlfredAutoClick
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gets or sets the clicker engine that controls automatic clicking behavior.
        /// </summary>
        private ClickerEngine clicker { get; set; }

        /// <summary>
        /// Current configuration
        /// </summary>
        private ClickerConfig config;

        /// <summary>
        /// Stores the main non-modifier key selected by the user (ex: F6, A, Space)
        /// </summary>
        private Keys currentKey = Keys.None;

        /// <summary>
        /// Indicates whether the Control key was pressed during shortcut selection
        /// </summary>
        private bool ctrlPressed;

        /// <summary>
        /// Indicates whether the Alt key was pressed during shortcut selection
        /// </summary>
        private bool altPressed;

        /// <summary>
        /// Indicates whether the Shift key was pressed during shortcut selection
        /// </summary>
        private bool shiftPressed;

        /// <summary>
        /// Global keyboard and mouse hook to detect clicks and key presses
        /// </summary>
        private IKeyboardMouseEvents globalHook;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // set icon
            this.Icon = new Icon("AlfredAutoClick.ico");
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.notifyIcon.Text = AppInfo.GetAppName();

            // set the form title to include the application name and version
            Text = AppInfo.GetAppName();

            // set enum values as data sources
            comboMouseButton.DataSource = Enum.GetValues(typeof(ClickType));
            comboClickBehavior.DataSource = Enum.GetValues(typeof(ClickMode));
            comboTriggerMode.DataSource = Enum.GetValues(typeof(TriggerMode));

            // display a readable description instead of the enum name
            comboMouseButton.Format += (s, args) => {
                if (args.ListItem is Enum val) args.Value = EnumUtils.GetDescription(val);
            };

            comboClickBehavior.Format += (s, args) => {
                if (args.ListItem is Enum val) args.Value = EnumUtils.GetDescription(val);
            };

            comboTriggerMode.Format += (s, args) => {
                if (args.ListItem is Enum val) args.Value = EnumUtils.GetDescription(val);
            };

            // set default selected values
            comboMouseButton.SelectedItem = ClickType.Left;
            comboClickBehavior.SelectedItem = ClickMode.MultiClick;
            comboTriggerMode.SelectedItem = TriggerMode.Toggle;

            // load the configuration from AppData or use defaults
            config = ClickerConfig.Load();
            ConfigLoad();

            // sets up a global hotkey listener using MouseKeyHook, 
            // this allows the user to trigger the clicker even when the application is not focused.
            globalHook = Hook.GlobalEvents();
            globalHook.KeyDown += GlobalHook_KeyDown;

            // create the clicker engine with current config
            clicker = new ClickerEngine(config);

            // apply the theme
            UITheme.Apply(this);
        }

        /// <summary>
        /// Load the configuration into the form fields.
        /// </summary>
        private void ConfigLoad()
        {
            txtClickDelayMs.Value = config.ClickDelayMs;
            comboMouseButton.SelectedItem = config.MouseButton;
            comboClickBehavior.SelectedItem = config.ClickBehavior;
            txtClickBurst.Value = config.ClickBurst;
            txtBurstClickDelay.Value = config.BurstClickDelay;
            SetActivationKeyText();
            txtStopAfter.Value = config.StopAfter;
            comboTriggerMode.SelectedItem = config.TriggerMode;
        }

        /// <summary>
        /// Save the current configuration to object
        /// </summary>
        private void ConfigSave()
        {
            config.ClickDelayMs = txtClickDelayMs.Value;
            config.MouseButton = (ClickType)comboMouseButton.SelectedItem;
            config.ClickBehavior = (ClickMode)comboClickBehavior.SelectedItem;
            config.ClickBurst = txtClickBurst.Value;
            config.BurstClickDelay = txtBurstClickDelay.Value;
            config.StopAfter = txtStopAfter.Value;
            config.TriggerMode = (TriggerMode)comboTriggerMode.SelectedItem;

            config.Save();
        }

        /// <summary>
        /// Handles global key events and toggles the clicker if the hotkey matches the one in config.
        /// </summary>
        private void GlobalHook_KeyDown(object sender, KeyEventArgs e)
        {
            // check if pressed key matches the configured key
            var isKeyMatch = e.KeyCode == config.KeyActivation;

            // check if modifier keys match what is configured
            var ctrlOk = config.KeyActivationUseCtrl == e.Control;
            var altOk = config.KeyActivationUseAlt == e.Alt;
            var shiftOk = config.KeyActivationUseShift == e.Shift;

            // determine if the full combination matches
            var isValidTrigger = isKeyMatch && ctrlOk && altOk && shiftOk;

            // toggle clicker if hotkey is valid
            if (isValidTrigger)
            {
                if (clicker.IsRunning)
                    clicker.Stop();
                else
                    clicker.Start();
            }
        }

        /// <summary>
        /// updates the activation key textbox based on the config
        /// </summary>
        private void SetActivationKeyText()
        {
            var parts = new List<string>();
            if (config.KeyActivationUseCtrl) parts.Add("Ctrl");
            if (config.KeyActivationUseAlt) parts.Add("Alt");
            if (config.KeyActivationUseShift) parts.Add("Shift");
            if (config.KeyActivation != Keys.None) parts.Add(config.KeyActivation.ToString());
            txtActivationKey.Text = string.Join(" + ", parts);
        }


        /// <summary>
        /// paints a vertical gradient background on the main form
        /// </summary>
        /// <param name="e">the paint event data</param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (ClientRectangle.Width != 0 && ClientRectangle.Height != 0)
            {
                // create a vertical gradient brush from top (dark) to bottom (less dark)
                using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(25, 40, 100),
                Color.FromArgb(10, 20, 35),
                System.Drawing.Drawing2D.LinearGradientMode.Vertical))
                {
                    // fill the entire form with the gradient
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
        }


        private void cmdSaveConfig_Click(object sender, EventArgs e)
        {
            ConfigSave();            
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            // create new config with default values
            config = new ClickerConfig();

            // apply values from config to form fields and save
            ConfigLoad();
            ConfigSave();          
            
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
                Invalidate(true);
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            BringToFront();

            // force repaint complet
            Invalidate(true);
            Refresh();
        }

        private void txtActivationKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// handles the actual key combination pressed by the user
        /// </summary>
        private void txtActivationKey_KeyDown(object sender, KeyEventArgs e)
        {
            // prevent default text input
            e.SuppressKeyPress = true;

            // detect if the user canceled with Escape
            var isCancel = e.KeyCode == Keys.Escape;

            // update modifier states
            ctrlPressed = e.Control;
            altPressed = e.Alt;
            shiftPressed = e.Shift;

            // check if the key is a modifier-only key
            var isModifierOnly =
                e.KeyCode == Keys.ControlKey ||
                e.KeyCode == Keys.ShiftKey ||
                e.KeyCode == Keys.Menu;

            if (isCancel)
            {
                // restore display from current config
                SetActivationKeyText();
            }

            if (!isCancel && !isModifierOnly)
            {
                // store new key combination
                currentKey = e.KeyCode;

                // save combination to config
                config.KeyActivation = currentKey;
                config.KeyActivationUseCtrl = ctrlPressed;
                config.KeyActivationUseAlt = altPressed;
                config.KeyActivationUseShift = shiftPressed;

                // update display
                SetActivationKeyText();
            }
        }

        private void txtActivationKey_Enter(object sender, EventArgs e)
        {
            // display placeholder while waiting for input
            txtActivationKey.Text = "Press shortcut...";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (globalHook != null) globalHook.Dispose();
        }
    }
}
