namespace AlfredAutoClick
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblClickDelayMs = new System.Windows.Forms.Label();
            this.lblMouseButton = new System.Windows.Forms.Label();
            this.lblClickBehavior = new System.Windows.Forms.Label();
            this.lblClickBurst = new System.Windows.Forms.Label();
            this.lblActivationKey = new System.Windows.Forms.Label();
            this.lblStopAfter = new System.Windows.Forms.Label();
            this.lblTriggerMode = new System.Windows.Forms.Label();
            this.comboMouseButton = new System.Windows.Forms.ComboBox();
            this.comboClickBehavior = new System.Windows.Forms.ComboBox();
            this.comboTriggerMode = new System.Windows.Forms.ComboBox();
            this.lblBurstClickDelay = new System.Windows.Forms.Label();
            this.lblms0 = new System.Windows.Forms.Label();
            this.lblms1 = new System.Windows.Forms.Label();
            this.txtActivationKey = new System.Windows.Forms.TextBox();
            this.lblclicks1 = new System.Windows.Forms.Label();
            this.lblclicks0 = new System.Windows.Forms.Label();
            this.cmdSaveConfig = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtStopAfter = new AlfredAutoClick.UI.NumericTextBox();
            this.txtBurstClickDelay = new AlfredAutoClick.UI.NumericTextBox();
            this.txtClickBurst = new AlfredAutoClick.UI.NumericTextBox();
            this.txtClickDelayMs = new AlfredAutoClick.UI.NumericTextBox();
            this.SuspendLayout();
            // 
            // lblClickDelayMs
            // 
            this.lblClickDelayMs.AutoSize = true;
            this.lblClickDelayMs.BackColor = System.Drawing.SystemColors.Control;
            this.lblClickDelayMs.Location = new System.Drawing.Point(22, 73);
            this.lblClickDelayMs.Name = "lblClickDelayMs";
            this.lblClickDelayMs.Size = new System.Drawing.Size(108, 13);
            this.lblClickDelayMs.TabIndex = 4;
            this.lblClickDelayMs.Text = "Delay between clicks";
            // 
            // lblMouseButton
            // 
            this.lblMouseButton.AutoSize = true;
            this.lblMouseButton.BackColor = System.Drawing.SystemColors.Control;
            this.lblMouseButton.Location = new System.Drawing.Point(22, 19);
            this.lblMouseButton.Name = "lblMouseButton";
            this.lblMouseButton.Size = new System.Drawing.Size(72, 13);
            this.lblMouseButton.TabIndex = 0;
            this.lblMouseButton.Text = "Mouse button";
            // 
            // lblClickBehavior
            // 
            this.lblClickBehavior.AutoSize = true;
            this.lblClickBehavior.BackColor = System.Drawing.SystemColors.Control;
            this.lblClickBehavior.Location = new System.Drawing.Point(22, 46);
            this.lblClickBehavior.Name = "lblClickBehavior";
            this.lblClickBehavior.Size = new System.Drawing.Size(74, 13);
            this.lblClickBehavior.TabIndex = 2;
            this.lblClickBehavior.Text = "Click behavior";
            // 
            // lblClickBurst
            // 
            this.lblClickBurst.AutoSize = true;
            this.lblClickBurst.BackColor = System.Drawing.SystemColors.Control;
            this.lblClickBurst.Location = new System.Drawing.Point(22, 109);
            this.lblClickBurst.Name = "lblClickBurst";
            this.lblClickBurst.Size = new System.Drawing.Size(56, 13);
            this.lblClickBurst.TabIndex = 7;
            this.lblClickBurst.Text = "Click burst";
            // 
            // lblActivationKey
            // 
            this.lblActivationKey.AutoSize = true;
            this.lblActivationKey.BackColor = System.Drawing.SystemColors.Control;
            this.lblActivationKey.Location = new System.Drawing.Point(22, 201);
            this.lblActivationKey.Name = "lblActivationKey";
            this.lblActivationKey.Size = new System.Drawing.Size(74, 13);
            this.lblActivationKey.TabIndex = 15;
            this.lblActivationKey.Text = "Activation key";
            // 
            // lblStopAfter
            // 
            this.lblStopAfter.AutoSize = true;
            this.lblStopAfter.BackColor = System.Drawing.SystemColors.Control;
            this.lblStopAfter.Location = new System.Drawing.Point(22, 228);
            this.lblStopAfter.Name = "lblStopAfter";
            this.lblStopAfter.Size = new System.Drawing.Size(53, 13);
            this.lblStopAfter.TabIndex = 17;
            this.lblStopAfter.Text = "Stop after";
            // 
            // lblTriggerMode
            // 
            this.lblTriggerMode.AutoSize = true;
            this.lblTriggerMode.BackColor = System.Drawing.SystemColors.Control;
            this.lblTriggerMode.Location = new System.Drawing.Point(22, 174);
            this.lblTriggerMode.Name = "lblTriggerMode";
            this.lblTriggerMode.Size = new System.Drawing.Size(69, 13);
            this.lblTriggerMode.TabIndex = 13;
            this.lblTriggerMode.Text = "Trigger mode";
            // 
            // comboMouseButton
            // 
            this.comboMouseButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMouseButton.FormattingEnabled = true;
            this.comboMouseButton.Location = new System.Drawing.Point(163, 16);
            this.comboMouseButton.Name = "comboMouseButton";
            this.comboMouseButton.Size = new System.Drawing.Size(121, 21);
            this.comboMouseButton.TabIndex = 1;
            // 
            // comboClickBehavior
            // 
            this.comboClickBehavior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClickBehavior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboClickBehavior.FormattingEnabled = true;
            this.comboClickBehavior.Location = new System.Drawing.Point(163, 43);
            this.comboClickBehavior.Name = "comboClickBehavior";
            this.comboClickBehavior.Size = new System.Drawing.Size(121, 21);
            this.comboClickBehavior.TabIndex = 3;
            // 
            // comboTriggerMode
            // 
            this.comboTriggerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTriggerMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTriggerMode.FormattingEnabled = true;
            this.comboTriggerMode.Location = new System.Drawing.Point(163, 171);
            this.comboTriggerMode.Name = "comboTriggerMode";
            this.comboTriggerMode.Size = new System.Drawing.Size(121, 21);
            this.comboTriggerMode.TabIndex = 14;
            // 
            // lblBurstClickDelay
            // 
            this.lblBurstClickDelay.AutoSize = true;
            this.lblBurstClickDelay.BackColor = System.Drawing.SystemColors.Control;
            this.lblBurstClickDelay.Location = new System.Drawing.Point(22, 138);
            this.lblBurstClickDelay.Name = "lblBurstClickDelay";
            this.lblBurstClickDelay.Size = new System.Drawing.Size(84, 13);
            this.lblBurstClickDelay.TabIndex = 10;
            this.lblBurstClickDelay.Text = "Burst click delay";
            // 
            // lblms0
            // 
            this.lblms0.AutoSize = true;
            this.lblms0.Location = new System.Drawing.Point(251, 73);
            this.lblms0.Name = "lblms0";
            this.lblms0.Size = new System.Drawing.Size(20, 13);
            this.lblms0.TabIndex = 6;
            this.lblms0.Text = "ms";
            // 
            // lblms1
            // 
            this.lblms1.AutoSize = true;
            this.lblms1.Location = new System.Drawing.Point(251, 138);
            this.lblms1.Name = "lblms1";
            this.lblms1.Size = new System.Drawing.Size(20, 13);
            this.lblms1.TabIndex = 12;
            this.lblms1.Text = "ms";
            // 
            // txtActivationKey
            // 
            this.txtActivationKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtActivationKey.HideSelection = false;
            this.txtActivationKey.Location = new System.Drawing.Point(163, 198);
            this.txtActivationKey.Name = "txtActivationKey";
            this.txtActivationKey.ReadOnly = true;
            this.txtActivationKey.Size = new System.Drawing.Size(121, 20);
            this.txtActivationKey.TabIndex = 16;
            this.txtActivationKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtActivationKey.Enter += new System.EventHandler(this.txtActivationKey_Enter);
            this.txtActivationKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtActivationKey_KeyDown);
            this.txtActivationKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActivationKey_KeyPress);
            // 
            // lblclicks1
            // 
            this.lblclicks1.AutoSize = true;
            this.lblclicks1.Location = new System.Drawing.Point(251, 228);
            this.lblclicks1.Name = "lblclicks1";
            this.lblclicks1.Size = new System.Drawing.Size(34, 13);
            this.lblclicks1.TabIndex = 19;
            this.lblclicks1.Text = "clicks";
            // 
            // lblclicks0
            // 
            this.lblclicks0.AutoSize = true;
            this.lblclicks0.Location = new System.Drawing.Point(250, 112);
            this.lblclicks0.Name = "lblclicks0";
            this.lblclicks0.Size = new System.Drawing.Size(34, 13);
            this.lblclicks0.TabIndex = 9;
            this.lblclicks0.Text = "clicks";
            // 
            // cmdSaveConfig
            // 
            this.cmdSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaveConfig.Location = new System.Drawing.Point(25, 259);
            this.cmdSaveConfig.Name = "cmdSaveConfig";
            this.cmdSaveConfig.Size = new System.Drawing.Size(121, 23);
            this.cmdSaveConfig.TabIndex = 20;
            this.cmdSaveConfig.Text = "&Save config";
            this.cmdSaveConfig.UseVisualStyleBackColor = true;
            this.cmdSaveConfig.Click += new System.EventHandler(this.cmdSaveConfig_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReset.Location = new System.Drawing.Point(163, 259);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(121, 23);
            this.cmdReset.TabIndex = 21;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // txtStopAfter
            // 
            this.txtStopAfter.Location = new System.Drawing.Point(163, 225);
            this.txtStopAfter.Name = "txtStopAfter";
            this.txtStopAfter.Size = new System.Drawing.Size(82, 20);
            this.txtStopAfter.TabIndex = 18;
            this.txtStopAfter.Text = "0";
            this.txtStopAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBurstClickDelay
            // 
            this.txtBurstClickDelay.Location = new System.Drawing.Point(163, 135);
            this.txtBurstClickDelay.Name = "txtBurstClickDelay";
            this.txtBurstClickDelay.Size = new System.Drawing.Size(82, 20);
            this.txtBurstClickDelay.TabIndex = 11;
            this.txtBurstClickDelay.Text = "0";
            this.txtBurstClickDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtClickBurst
            // 
            this.txtClickBurst.Location = new System.Drawing.Point(163, 109);
            this.txtClickBurst.Name = "txtClickBurst";
            this.txtClickBurst.Size = new System.Drawing.Size(82, 20);
            this.txtClickBurst.TabIndex = 8;
            this.txtClickBurst.Text = "0";
            this.txtClickBurst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtClickDelayMs
            // 
            this.txtClickDelayMs.Location = new System.Drawing.Point(163, 70);
            this.txtClickDelayMs.Name = "txtClickDelayMs";
            this.txtClickDelayMs.Size = new System.Drawing.Size(82, 20);
            this.txtClickDelayMs.TabIndex = 5;
            this.txtClickDelayMs.Text = "0";
            this.txtClickDelayMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 301);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdSaveConfig);
            this.Controls.Add(this.lblclicks0);
            this.Controls.Add(this.lblclicks1);
            this.Controls.Add(this.txtStopAfter);
            this.Controls.Add(this.txtActivationKey);
            this.Controls.Add(this.lblms1);
            this.Controls.Add(this.txtBurstClickDelay);
            this.Controls.Add(this.txtClickBurst);
            this.Controls.Add(this.lblms0);
            this.Controls.Add(this.txtClickDelayMs);
            this.Controls.Add(this.lblBurstClickDelay);
            this.Controls.Add(this.comboTriggerMode);
            this.Controls.Add(this.comboClickBehavior);
            this.Controls.Add(this.comboMouseButton);
            this.Controls.Add(this.lblTriggerMode);
            this.Controls.Add(this.lblStopAfter);
            this.Controls.Add(this.lblActivationKey);
            this.Controls.Add(this.lblClickBurst);
            this.Controls.Add(this.lblClickBehavior);
            this.Controls.Add(this.lblMouseButton);
            this.Controls.Add(this.lblClickDelayMs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClickDelayMs;
        private System.Windows.Forms.Label lblMouseButton;
        private System.Windows.Forms.Label lblClickBehavior;
        private System.Windows.Forms.Label lblClickBurst;
        private System.Windows.Forms.Label lblActivationKey;
        private System.Windows.Forms.Label lblStopAfter;
        private System.Windows.Forms.Label lblTriggerMode;
        private System.Windows.Forms.ComboBox comboMouseButton;
        private System.Windows.Forms.ComboBox comboClickBehavior;
        private System.Windows.Forms.ComboBox comboTriggerMode;
        private System.Windows.Forms.Label lblBurstClickDelay;
        private UI.NumericTextBox txtClickDelayMs;
        private System.Windows.Forms.Label lblms0;
        private UI.NumericTextBox txtClickBurst;
        private System.Windows.Forms.Label lblms1;
        private UI.NumericTextBox txtBurstClickDelay;
        private System.Windows.Forms.TextBox txtActivationKey;
        private UI.NumericTextBox txtStopAfter;
        private System.Windows.Forms.Label lblclicks1;
        private System.Windows.Forms.Label lblclicks0;
        private System.Windows.Forms.Button cmdSaveConfig;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

