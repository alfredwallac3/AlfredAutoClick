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
            this.cmdReset = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
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
            this.lblClickDelayMs.Location = new System.Drawing.Point(30, 138);
            this.lblClickDelayMs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClickDelayMs.Name = "lblClickDelayMs";
            this.lblClickDelayMs.Size = new System.Drawing.Size(134, 16);
            this.lblClickDelayMs.TabIndex = 4;
            this.lblClickDelayMs.Text = "Delay between clicks";
            // 
            // lblMouseButton
            // 
            this.lblMouseButton.AutoSize = true;
            this.lblMouseButton.BackColor = System.Drawing.SystemColors.Control;
            this.lblMouseButton.Location = new System.Drawing.Point(30, 71);
            this.lblMouseButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMouseButton.Name = "lblMouseButton";
            this.lblMouseButton.Size = new System.Drawing.Size(87, 16);
            this.lblMouseButton.TabIndex = 0;
            this.lblMouseButton.Text = "Mouse button";
            // 
            // lblClickBehavior
            // 
            this.lblClickBehavior.AutoSize = true;
            this.lblClickBehavior.BackColor = System.Drawing.SystemColors.Control;
            this.lblClickBehavior.Location = new System.Drawing.Point(30, 105);
            this.lblClickBehavior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClickBehavior.Name = "lblClickBehavior";
            this.lblClickBehavior.Size = new System.Drawing.Size(92, 16);
            this.lblClickBehavior.TabIndex = 2;
            this.lblClickBehavior.Text = "Click behavior";
            // 
            // lblClickBurst
            // 
            this.lblClickBurst.AutoSize = true;
            this.lblClickBurst.BackColor = System.Drawing.SystemColors.Control;
            this.lblClickBurst.Location = new System.Drawing.Point(30, 182);
            this.lblClickBurst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClickBurst.Name = "lblClickBurst";
            this.lblClickBurst.Size = new System.Drawing.Size(68, 16);
            this.lblClickBurst.TabIndex = 7;
            this.lblClickBurst.Text = "Click burst";
            // 
            // lblActivationKey
            // 
            this.lblActivationKey.AutoSize = true;
            this.lblActivationKey.BackColor = System.Drawing.SystemColors.Control;
            this.lblActivationKey.Location = new System.Drawing.Point(30, 295);
            this.lblActivationKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivationKey.Name = "lblActivationKey";
            this.lblActivationKey.Size = new System.Drawing.Size(90, 16);
            this.lblActivationKey.TabIndex = 15;
            this.lblActivationKey.Text = "Activation key";
            // 
            // lblStopAfter
            // 
            this.lblStopAfter.AutoSize = true;
            this.lblStopAfter.BackColor = System.Drawing.SystemColors.Control;
            this.lblStopAfter.Location = new System.Drawing.Point(30, 329);
            this.lblStopAfter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStopAfter.Name = "lblStopAfter";
            this.lblStopAfter.Size = new System.Drawing.Size(64, 16);
            this.lblStopAfter.TabIndex = 17;
            this.lblStopAfter.Text = "Stop after";
            // 
            // lblTriggerMode
            // 
            this.lblTriggerMode.AutoSize = true;
            this.lblTriggerMode.BackColor = System.Drawing.SystemColors.Control;
            this.lblTriggerMode.Location = new System.Drawing.Point(30, 262);
            this.lblTriggerMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTriggerMode.Name = "lblTriggerMode";
            this.lblTriggerMode.Size = new System.Drawing.Size(89, 16);
            this.lblTriggerMode.TabIndex = 13;
            this.lblTriggerMode.Text = "Trigger mode";
            // 
            // comboMouseButton
            // 
            this.comboMouseButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMouseButton.FormattingEnabled = true;
            this.comboMouseButton.Location = new System.Drawing.Point(218, 68);
            this.comboMouseButton.Margin = new System.Windows.Forms.Padding(4);
            this.comboMouseButton.Name = "comboMouseButton";
            this.comboMouseButton.Size = new System.Drawing.Size(160, 24);
            this.comboMouseButton.TabIndex = 1;
            this.comboMouseButton.Validated += new System.EventHandler(this.comboMouseButton_Validated);
            // 
            // comboClickBehavior
            // 
            this.comboClickBehavior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClickBehavior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboClickBehavior.FormattingEnabled = true;
            this.comboClickBehavior.Location = new System.Drawing.Point(218, 101);
            this.comboClickBehavior.Margin = new System.Windows.Forms.Padding(4);
            this.comboClickBehavior.Name = "comboClickBehavior";
            this.comboClickBehavior.Size = new System.Drawing.Size(160, 24);
            this.comboClickBehavior.TabIndex = 3;
            this.comboClickBehavior.Validated += new System.EventHandler(this.comboClickBehavior_Validated);
            // 
            // comboTriggerMode
            // 
            this.comboTriggerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTriggerMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTriggerMode.FormattingEnabled = true;
            this.comboTriggerMode.Location = new System.Drawing.Point(218, 258);
            this.comboTriggerMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboTriggerMode.Name = "comboTriggerMode";
            this.comboTriggerMode.Size = new System.Drawing.Size(160, 24);
            this.comboTriggerMode.TabIndex = 14;
            this.comboTriggerMode.Validating += new System.ComponentModel.CancelEventHandler(this.comboTriggerMode_Validating);
            // 
            // lblBurstClickDelay
            // 
            this.lblBurstClickDelay.AutoSize = true;
            this.lblBurstClickDelay.BackColor = System.Drawing.SystemColors.Control;
            this.lblBurstClickDelay.Location = new System.Drawing.Point(30, 218);
            this.lblBurstClickDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBurstClickDelay.Name = "lblBurstClickDelay";
            this.lblBurstClickDelay.Size = new System.Drawing.Size(104, 16);
            this.lblBurstClickDelay.TabIndex = 10;
            this.lblBurstClickDelay.Text = "Burst click delay";
            // 
            // lblms0
            // 
            this.lblms0.AutoSize = true;
            this.lblms0.Location = new System.Drawing.Point(336, 138);
            this.lblms0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblms0.Name = "lblms0";
            this.lblms0.Size = new System.Drawing.Size(25, 16);
            this.lblms0.TabIndex = 6;
            this.lblms0.Text = "ms";
            // 
            // lblms1
            // 
            this.lblms1.AutoSize = true;
            this.lblms1.Location = new System.Drawing.Point(336, 218);
            this.lblms1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblms1.Name = "lblms1";
            this.lblms1.Size = new System.Drawing.Size(25, 16);
            this.lblms1.TabIndex = 12;
            this.lblms1.Text = "ms";
            // 
            // txtActivationKey
            // 
            this.txtActivationKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtActivationKey.HideSelection = false;
            this.txtActivationKey.Location = new System.Drawing.Point(218, 292);
            this.txtActivationKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtActivationKey.Name = "txtActivationKey";
            this.txtActivationKey.ReadOnly = true;
            this.txtActivationKey.Size = new System.Drawing.Size(160, 22);
            this.txtActivationKey.TabIndex = 16;
            this.txtActivationKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtActivationKey.Enter += new System.EventHandler(this.txtActivationKey_Enter);
            this.txtActivationKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtActivationKey_KeyDown);
            this.txtActivationKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActivationKey_KeyPress);
            // 
            // lblclicks1
            // 
            this.lblclicks1.AutoSize = true;
            this.lblclicks1.Location = new System.Drawing.Point(336, 329);
            this.lblclicks1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblclicks1.Name = "lblclicks1";
            this.lblclicks1.Size = new System.Drawing.Size(41, 16);
            this.lblclicks1.TabIndex = 19;
            this.lblclicks1.Text = "clicks";
            // 
            // lblclicks0
            // 
            this.lblclicks0.AutoSize = true;
            this.lblclicks0.Location = new System.Drawing.Point(334, 186);
            this.lblclicks0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblclicks0.Name = "lblclicks0";
            this.lblclicks0.Size = new System.Drawing.Size(41, 16);
            this.lblclicks0.TabIndex = 9;
            this.lblclicks0.Text = "clicks";
            // 
            // cmdReset
            // 
            this.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReset.Location = new System.Drawing.Point(218, 367);
            this.cmdReset.Margin = new System.Windows.Forms.Padding(4);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(161, 28);
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(28, 23);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 26);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Idle";
            // 
            // txtStopAfter
            // 
            this.txtStopAfter.Location = new System.Drawing.Point(218, 325);
            this.txtStopAfter.Margin = new System.Windows.Forms.Padding(4);
            this.txtStopAfter.Name = "txtStopAfter";
            this.txtStopAfter.Size = new System.Drawing.Size(108, 22);
            this.txtStopAfter.TabIndex = 18;
            this.txtStopAfter.Text = "0";
            this.txtStopAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStopAfter.Validated += new System.EventHandler(this.txtStopAfter_Validated);
            // 
            // txtBurstClickDelay
            // 
            this.txtBurstClickDelay.Location = new System.Drawing.Point(218, 214);
            this.txtBurstClickDelay.Margin = new System.Windows.Forms.Padding(4);
            this.txtBurstClickDelay.Name = "txtBurstClickDelay";
            this.txtBurstClickDelay.Size = new System.Drawing.Size(108, 22);
            this.txtBurstClickDelay.TabIndex = 11;
            this.txtBurstClickDelay.Text = "0";
            this.txtBurstClickDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBurstClickDelay.Validated += new System.EventHandler(this.txtBurstClickDelay_Validated);
            // 
            // txtClickBurst
            // 
            this.txtClickBurst.Location = new System.Drawing.Point(218, 182);
            this.txtClickBurst.Margin = new System.Windows.Forms.Padding(4);
            this.txtClickBurst.Name = "txtClickBurst";
            this.txtClickBurst.Size = new System.Drawing.Size(108, 22);
            this.txtClickBurst.TabIndex = 8;
            this.txtClickBurst.Text = "0";
            this.txtClickBurst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClickBurst.Validated += new System.EventHandler(this.txtClickBurst_Validated);
            // 
            // txtClickDelayMs
            // 
            this.txtClickDelayMs.Location = new System.Drawing.Point(218, 134);
            this.txtClickDelayMs.Margin = new System.Windows.Forms.Padding(4);
            this.txtClickDelayMs.Name = "txtClickDelayMs";
            this.txtClickDelayMs.Size = new System.Drawing.Size(108, 22);
            this.txtClickDelayMs.TabIndex = 5;
            this.txtClickDelayMs.Text = "0";
            this.txtClickDelayMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClickDelayMs.Validated += new System.EventHandler(this.txtClickDelayMs_Validated);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 416);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmdReset);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
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
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label lblStatus;
    }
}

