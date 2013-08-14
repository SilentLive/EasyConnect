﻿namespace EasyConnect.Protocols.Vnc
{
    partial class VncOptionsForm
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
			System.Security.SecureString secureString1 = new System.Security.SecureString();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VncOptionsForm));
			this._displayLabel = new System.Windows.Forms.Label();
			this._displayNumberLabel = new System.Windows.Forms.Label();
			this._flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this._generalPanel = new System.Windows.Forms.Panel();
			this._authenticationTypeLabel = new System.Windows.Forms.Label();
			this._authenticationTypeDropdown = new System.Windows.Forms.ComboBox();
			this._inheritedPasswordLabel = new System.Windows.Forms.Label();
			this._inheritedUsernameLabel = new System.Windows.Forms.Label();
			this._passwordTextBox = new SecurePasswordTextBox.SecureTextBox();
			this._userNameLabel = new System.Windows.Forms.Label();
			this._userNameTextBox = new System.Windows.Forms.TextBox();
			this._passwordLabel = new System.Windows.Forms.Label();
			this._generalLabel = new System.Windows.Forms.Label();
			this._hostPanel = new System.Windows.Forms.Panel();
			this._keyFileBrowseButton = new System.Windows.Forms.Button();
			this._keyFileLabel = new System.Windows.Forms.Label();
			this._keyFileTextBox = new System.Windows.Forms.TextBox();
			this._encryptionTypeLabel = new System.Windows.Forms.Label();
			this._encryptionTypeDropdown = new System.Windows.Forms.ComboBox();
			this._portUpDown = new System.Windows.Forms.NumericUpDown();
			this._portLabel = new System.Windows.Forms.Label();
			this._hostNameLabel = new System.Windows.Forms.Label();
			this._hostNameTextBox = new System.Windows.Forms.TextBox();
			this._hostLabel = new System.Windows.Forms.Label();
			this._displayPanel = new System.Windows.Forms.Panel();
			this._colorDepthLabel = new System.Windows.Forms.Label();
			this._colorDepthDropdown = new System.Windows.Forms.ComboBox();
			this._encodingTypeLabel = new System.Windows.Forms.Label();
			this._encodingTypeDropdown = new System.Windows.Forms.ComboBox();
			this._viewOnlyCheckbox = new System.Windows.Forms.CheckBox();
			this._viewOnlyLabel = new System.Windows.Forms.Label();
			this._scaleCheckbox = new System.Windows.Forms.CheckBox();
			this._displayUpDown = new System.Windows.Forms.NumericUpDown();
			this._scaleLabel = new System.Windows.Forms.Label();
			this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._titleLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this._flowLayoutPanel.SuspendLayout();
			this._generalPanel.SuspendLayout();
			this._hostPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._portUpDown)).BeginInit();
			this._displayPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._displayUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// _displayLabel
			// 
			this._displayLabel.AutoSize = true;
			this._displayLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this._displayLabel.Location = new System.Drawing.Point(8, 11);
			this._displayLabel.Name = "_displayLabel";
			this._displayLabel.Size = new System.Drawing.Size(50, 17);
			this._displayLabel.TabIndex = 55;
			this._displayLabel.Text = "Display";
			// 
			// _displayNumberLabel
			// 
			this._displayNumberLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._displayNumberLabel.Location = new System.Drawing.Point(31, 38);
			this._displayNumberLabel.Name = "_displayNumberLabel";
			this._displayNumberLabel.Size = new System.Drawing.Size(122, 20);
			this._displayNumberLabel.TabIndex = 53;
			this._displayNumberLabel.Text = "Display:";
			this._displayNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _flowLayoutPanel
			// 
			this._flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._flowLayoutPanel.Controls.Add(this._generalPanel);
			this._flowLayoutPanel.Controls.Add(this._hostPanel);
			this._flowLayoutPanel.Controls.Add(this._displayPanel);
			this._flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this._flowLayoutPanel.Location = new System.Drawing.Point(0, 61);
			this._flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this._flowLayoutPanel.Name = "_flowLayoutPanel";
			this._flowLayoutPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
			this._flowLayoutPanel.Size = new System.Drawing.Size(719, 623);
			this._flowLayoutPanel.TabIndex = 83;
			this._flowLayoutPanel.WrapContents = false;
			// 
			// _generalPanel
			// 
			this._generalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._generalPanel.Controls.Add(this._authenticationTypeLabel);
			this._generalPanel.Controls.Add(this._authenticationTypeDropdown);
			this._generalPanel.Controls.Add(this._inheritedPasswordLabel);
			this._generalPanel.Controls.Add(this._inheritedUsernameLabel);
			this._generalPanel.Controls.Add(this._passwordTextBox);
			this._generalPanel.Controls.Add(this._userNameLabel);
			this._generalPanel.Controls.Add(this._userNameTextBox);
			this._generalPanel.Controls.Add(this._passwordLabel);
			this._generalPanel.Controls.Add(this._generalLabel);
			this._generalPanel.Location = new System.Drawing.Point(18, 3);
			this._generalPanel.Name = "_generalPanel";
			this._generalPanel.Size = new System.Drawing.Size(684, 122);
			this._generalPanel.TabIndex = 86;
			// 
			// _authenticationTypeLabel
			// 
			this._authenticationTypeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._authenticationTypeLabel.Location = new System.Drawing.Point(31, 38);
			this._authenticationTypeLabel.Name = "_authenticationTypeLabel";
			this._authenticationTypeLabel.Size = new System.Drawing.Size(122, 18);
			this._authenticationTypeLabel.TabIndex = 96;
			this._authenticationTypeLabel.Text = "Authentication type:";
			this._authenticationTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _authenticationTypeDropdown
			// 
			this._authenticationTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._authenticationTypeDropdown.FormattingEnabled = true;
			this._authenticationTypeDropdown.Items.AddRange(new object[] {
            "Basic",
            "NTLM"});
			this._authenticationTypeDropdown.Location = new System.Drawing.Point(159, 38);
			this._authenticationTypeDropdown.Name = "_authenticationTypeDropdown";
			this._authenticationTypeDropdown.Size = new System.Drawing.Size(121, 21);
			this._authenticationTypeDropdown.TabIndex = 95;
			// 
			// _inheritedPasswordLabel
			// 
			this._inheritedPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._inheritedPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._inheritedPasswordLabel.Location = new System.Drawing.Point(319, 89);
			this._inheritedPasswordLabel.Name = "_inheritedPasswordLabel";
			this._inheritedPasswordLabel.Size = new System.Drawing.Size(263, 16);
			this._inheritedPasswordLabel.TabIndex = 94;
			// 
			// _inheritedUsernameLabel
			// 
			this._inheritedUsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._inheritedUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._inheritedUsernameLabel.Location = new System.Drawing.Point(319, 66);
			this._inheritedUsernameLabel.Name = "_inheritedUsernameLabel";
			this._inheritedUsernameLabel.Size = new System.Drawing.Size(263, 16);
			this._inheritedUsernameLabel.TabIndex = 93;
			// 
			// _passwordTextBox
			// 
			this._passwordTextBox.Location = new System.Drawing.Point(159, 86);
			this._passwordTextBox.Name = "_passwordTextBox";
			this._passwordTextBox.PasswordChar = '*';
			this._passwordTextBox.SecureText = secureString1;
			this._passwordTextBox.Size = new System.Drawing.Size(154, 20);
			this._passwordTextBox.TabIndex = 82;
			this._passwordTextBox.TextChanged += new System.EventHandler(this._passwordTextBox_TextChanged);
			// 
			// _userNameLabel
			// 
			this._userNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._userNameLabel.Location = new System.Drawing.Point(31, 62);
			this._userNameLabel.Name = "_userNameLabel";
			this._userNameLabel.Size = new System.Drawing.Size(122, 20);
			this._userNameLabel.TabIndex = 49;
			this._userNameLabel.Text = "User name:";
			this._userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _userNameTextBox
			// 
			this._userNameTextBox.Location = new System.Drawing.Point(159, 63);
			this._userNameTextBox.Name = "_userNameTextBox";
			this._userNameTextBox.Size = new System.Drawing.Size(154, 20);
			this._userNameTextBox.TabIndex = 48;
			this._userNameTextBox.TextChanged += new System.EventHandler(this._userNameTextBox_TextChanged);
			// 
			// _passwordLabel
			// 
			this._passwordLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._passwordLabel.Location = new System.Drawing.Point(31, 86);
			this._passwordLabel.Name = "_passwordLabel";
			this._passwordLabel.Size = new System.Drawing.Size(125, 20);
			this._passwordLabel.TabIndex = 50;
			this._passwordLabel.Text = "Password:";
			this._passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _generalLabel
			// 
			this._generalLabel.AutoSize = true;
			this._generalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this._generalLabel.Location = new System.Drawing.Point(8, 11);
			this._generalLabel.Name = "_generalLabel";
			this._generalLabel.Size = new System.Drawing.Size(53, 17);
			this._generalLabel.TabIndex = 51;
			this._generalLabel.Text = "General";
			// 
			// _hostPanel
			// 
			this._hostPanel.Controls.Add(this._keyFileBrowseButton);
			this._hostPanel.Controls.Add(this._keyFileLabel);
			this._hostPanel.Controls.Add(this._keyFileTextBox);
			this._hostPanel.Controls.Add(this._encryptionTypeLabel);
			this._hostPanel.Controls.Add(this._encryptionTypeDropdown);
			this._hostPanel.Controls.Add(this._portUpDown);
			this._hostPanel.Controls.Add(this._portLabel);
			this._hostPanel.Controls.Add(this._hostNameLabel);
			this._hostPanel.Controls.Add(this._hostNameTextBox);
			this._hostPanel.Controls.Add(this._hostLabel);
			this._hostPanel.Location = new System.Drawing.Point(18, 131);
			this._hostPanel.Name = "_hostPanel";
			this._hostPanel.Size = new System.Drawing.Size(684, 149);
			this._hostPanel.TabIndex = 84;
			// 
			// _keyFileBrowseButton
			// 
			this._keyFileBrowseButton.Location = new System.Drawing.Point(319, 112);
			this._keyFileBrowseButton.Name = "_keyFileBrowseButton";
			this._keyFileBrowseButton.Size = new System.Drawing.Size(25, 23);
			this._keyFileBrowseButton.TabIndex = 88;
			this._keyFileBrowseButton.Text = "...";
			this._keyFileBrowseButton.UseVisualStyleBackColor = true;
			this._keyFileBrowseButton.Click += new System.EventHandler(this._keyFileBrowseButton_Click);
			// 
			// _keyFileLabel
			// 
			this._keyFileLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._keyFileLabel.Location = new System.Drawing.Point(31, 112);
			this._keyFileLabel.Name = "_keyFileLabel";
			this._keyFileLabel.Size = new System.Drawing.Size(122, 20);
			this._keyFileLabel.TabIndex = 60;
			this._keyFileLabel.Text = "Key file:";
			this._keyFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _keyFileTextBox
			// 
			this._keyFileTextBox.Location = new System.Drawing.Point(159, 114);
			this._keyFileTextBox.Name = "_keyFileTextBox";
			this._keyFileTextBox.Size = new System.Drawing.Size(154, 20);
			this._keyFileTextBox.TabIndex = 59;
			// 
			// _encryptionTypeLabel
			// 
			this._encryptionTypeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._encryptionTypeLabel.Location = new System.Drawing.Point(31, 87);
			this._encryptionTypeLabel.Name = "_encryptionTypeLabel";
			this._encryptionTypeLabel.Size = new System.Drawing.Size(122, 18);
			this._encryptionTypeLabel.TabIndex = 58;
			this._encryptionTypeLabel.Text = "Encryption type:";
			this._encryptionTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _encryptionTypeDropdown
			// 
			this._encryptionTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._encryptionTypeDropdown.FormattingEnabled = true;
			this._encryptionTypeDropdown.Items.AddRange(new object[] {
            "None",
            "MSRC4",
            "SecureVNC"});
			this._encryptionTypeDropdown.Location = new System.Drawing.Point(159, 87);
			this._encryptionTypeDropdown.Name = "_encryptionTypeDropdown";
			this._encryptionTypeDropdown.Size = new System.Drawing.Size(121, 21);
			this._encryptionTypeDropdown.TabIndex = 57;
			this._encryptionTypeDropdown.SelectedIndexChanged += new System.EventHandler(this._encryptionTypeDropdown_SelectedIndexChanged);
			// 
			// _portUpDown
			// 
			this._portUpDown.Location = new System.Drawing.Point(159, 63);
			this._portUpDown.Maximum = new decimal(new int[] {
            32167,
            0,
            0,
            0});
			this._portUpDown.Name = "_portUpDown";
			this._portUpDown.Size = new System.Drawing.Size(61, 20);
			this._portUpDown.TabIndex = 56;
			this._portUpDown.Value = new decimal(new int[] {
            5900,
            0,
            0,
            0});
			// 
			// _portLabel
			// 
			this._portLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._portLabel.Location = new System.Drawing.Point(31, 61);
			this._portLabel.Name = "_portLabel";
			this._portLabel.Size = new System.Drawing.Size(122, 20);
			this._portLabel.TabIndex = 55;
			this._portLabel.Text = "Port:";
			this._portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _hostNameLabel
			// 
			this._hostNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._hostNameLabel.Location = new System.Drawing.Point(31, 38);
			this._hostNameLabel.Name = "_hostNameLabel";
			this._hostNameLabel.Size = new System.Drawing.Size(122, 20);
			this._hostNameLabel.TabIndex = 53;
			this._hostNameLabel.Text = "Host name:";
			this._hostNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _hostNameTextBox
			// 
			this._hostNameTextBox.Location = new System.Drawing.Point(159, 39);
			this._hostNameTextBox.Name = "_hostNameTextBox";
			this._hostNameTextBox.Size = new System.Drawing.Size(154, 20);
			this._hostNameTextBox.TabIndex = 52;
			// 
			// _hostLabel
			// 
			this._hostLabel.AutoSize = true;
			this._hostLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this._hostLabel.Location = new System.Drawing.Point(8, 11);
			this._hostLabel.Name = "_hostLabel";
			this._hostLabel.Size = new System.Drawing.Size(35, 17);
			this._hostLabel.TabIndex = 54;
			this._hostLabel.Text = "Host";
			// 
			// _displayPanel
			// 
			this._displayPanel.Controls.Add(this._colorDepthLabel);
			this._displayPanel.Controls.Add(this._colorDepthDropdown);
			this._displayPanel.Controls.Add(this._encodingTypeLabel);
			this._displayPanel.Controls.Add(this._encodingTypeDropdown);
			this._displayPanel.Controls.Add(this._viewOnlyCheckbox);
			this._displayPanel.Controls.Add(this._viewOnlyLabel);
			this._displayPanel.Controls.Add(this._scaleCheckbox);
			this._displayPanel.Controls.Add(this._displayUpDown);
			this._displayPanel.Controls.Add(this._displayLabel);
			this._displayPanel.Controls.Add(this._displayNumberLabel);
			this._displayPanel.Controls.Add(this._scaleLabel);
			this._displayPanel.Location = new System.Drawing.Point(18, 286);
			this._displayPanel.Name = "_displayPanel";
			this._displayPanel.Size = new System.Drawing.Size(684, 166);
			this._displayPanel.TabIndex = 83;
			// 
			// _colorDepthLabel
			// 
			this._colorDepthLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._colorDepthLabel.Location = new System.Drawing.Point(31, 131);
			this._colorDepthLabel.Name = "_colorDepthLabel";
			this._colorDepthLabel.Size = new System.Drawing.Size(100, 18);
			this._colorDepthLabel.TabIndex = 88;
			this._colorDepthLabel.Text = "Color depth:";
			this._colorDepthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _colorDepthDropdown
			// 
			this._colorDepthDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._colorDepthDropdown.FormattingEnabled = true;
			this._colorDepthDropdown.Items.AddRange(new object[] {
            "Full",
            "256 colors",
            "64 colors",
            "8 colors"});
			this._colorDepthDropdown.Location = new System.Drawing.Point(159, 131);
			this._colorDepthDropdown.Name = "_colorDepthDropdown";
			this._colorDepthDropdown.Size = new System.Drawing.Size(121, 21);
			this._colorDepthDropdown.TabIndex = 87;
			// 
			// _encodingTypeLabel
			// 
			this._encodingTypeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._encodingTypeLabel.Location = new System.Drawing.Point(31, 107);
			this._encodingTypeLabel.Name = "_encodingTypeLabel";
			this._encodingTypeLabel.Size = new System.Drawing.Size(100, 18);
			this._encodingTypeLabel.TabIndex = 86;
			this._encodingTypeLabel.Text = "Encoding type:";
			this._encodingTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _encodingTypeDropdown
			// 
			this._encodingTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._encodingTypeDropdown.FormattingEnabled = true;
			this._encodingTypeDropdown.Items.AddRange(new object[] {
            "RAW",
            "RRE",
            "CORRE",
            "HEXTILE",
            "ZLIB",
            "TIGHT",
            "ZLIBHEX",
            "ULTRA",
            "ZRLE",
            "ZYWRLE"});
			this._encodingTypeDropdown.Location = new System.Drawing.Point(159, 104);
			this._encodingTypeDropdown.Name = "_encodingTypeDropdown";
			this._encodingTypeDropdown.Size = new System.Drawing.Size(121, 21);
			this._encodingTypeDropdown.TabIndex = 85;
			// 
			// _viewOnlyCheckbox
			// 
			this._viewOnlyCheckbox.AutoSize = true;
			this._viewOnlyCheckbox.Location = new System.Drawing.Point(159, 83);
			this._viewOnlyCheckbox.Name = "_viewOnlyCheckbox";
			this._viewOnlyCheckbox.Size = new System.Drawing.Size(15, 14);
			this._viewOnlyCheckbox.TabIndex = 84;
			this._viewOnlyCheckbox.UseVisualStyleBackColor = true;
			// 
			// _viewOnlyLabel
			// 
			this._viewOnlyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._viewOnlyLabel.Location = new System.Drawing.Point(31, 83);
			this._viewOnlyLabel.Name = "_viewOnlyLabel";
			this._viewOnlyLabel.Size = new System.Drawing.Size(125, 20);
			this._viewOnlyLabel.TabIndex = 83;
			this._viewOnlyLabel.Text = "View only?:";
			this._viewOnlyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _scaleCheckbox
			// 
			this._scaleCheckbox.AutoSize = true;
			this._scaleCheckbox.Location = new System.Drawing.Point(159, 64);
			this._scaleCheckbox.Name = "_scaleCheckbox";
			this._scaleCheckbox.Size = new System.Drawing.Size(15, 14);
			this._scaleCheckbox.TabIndex = 82;
			this._scaleCheckbox.UseVisualStyleBackColor = true;
			// 
			// _displayUpDown
			// 
			this._displayUpDown.Location = new System.Drawing.Point(159, 37);
			this._displayUpDown.Name = "_displayUpDown";
			this._displayUpDown.Size = new System.Drawing.Size(61, 20);
			this._displayUpDown.TabIndex = 81;
			// 
			// _scaleLabel
			// 
			this._scaleLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this._scaleLabel.Location = new System.Drawing.Point(31, 60);
			this._scaleLabel.Name = "_scaleLabel";
			this._scaleLabel.Size = new System.Drawing.Size(125, 20);
			this._scaleLabel.TabIndex = 54;
			this._scaleLabel.Text = "Scale?:";
			this._scaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _titleLabel
			// 
			this._titleLabel.AutoSize = true;
			this._titleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(97)))), ((int)(((byte)(102)))));
			this._titleLabel.Location = new System.Drawing.Point(24, 19);
			this._titleLabel.Name = "_titleLabel";
			this._titleLabel.Size = new System.Drawing.Size(134, 30);
			this._titleLabel.TabIndex = 89;
			this._titleLabel.Text = "VNC Options";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Location = new System.Drawing.Point(29, 62);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(667, 1);
			this.panel1.TabIndex = 90;
			// 
			// VncOptionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(719, 683);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this._titleLabel);
			this.Controls.Add(this._flowLayoutPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "VncOptionsForm";
			this.Text = "VNC Options";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VncOptionsForm_FormClosing);
			this.Load += new System.EventHandler(this.VncOptionsForm_Load);
			this._flowLayoutPanel.ResumeLayout(false);
			this._generalPanel.ResumeLayout(false);
			this._generalPanel.PerformLayout();
			this._hostPanel.ResumeLayout(false);
			this._hostPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._portUpDown)).EndInit();
			this._displayPanel.ResumeLayout(false);
			this._displayPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._displayUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _displayLabel;
        private System.Windows.Forms.Label _displayNumberLabel;
        private System.Windows.Forms.FlowLayoutPanel _flowLayoutPanel;
        private System.Windows.Forms.Panel _hostPanel;
        private System.Windows.Forms.Label _portLabel;
        private System.Windows.Forms.Label _hostNameLabel;
        private System.Windows.Forms.TextBox _hostNameTextBox;
		private System.Windows.Forms.Label _hostLabel;
        private System.Windows.Forms.Panel _displayPanel;
        private System.Windows.Forms.Label _scaleLabel;
        private System.Windows.Forms.NumericUpDown _portUpDown;
        private System.Windows.Forms.NumericUpDown _displayUpDown;
        private System.Windows.Forms.CheckBox _scaleCheckbox;
        private System.Windows.Forms.CheckBox _viewOnlyCheckbox;
        private System.Windows.Forms.Label _viewOnlyLabel;
        private System.Windows.Forms.Panel _generalPanel;
        private System.Windows.Forms.Label _userNameLabel;
        private System.Windows.Forms.TextBox _userNameTextBox;
        private System.Windows.Forms.Label _passwordLabel;
		private System.Windows.Forms.Label _generalLabel;
        private SecurePasswordTextBox.SecureTextBox _passwordTextBox;
        private System.Windows.Forms.Label _inheritedPasswordLabel;
        private System.Windows.Forms.Label _inheritedUsernameLabel;
        private System.Windows.Forms.Label _authenticationTypeLabel;
        private System.Windows.Forms.ComboBox _authenticationTypeDropdown;
        private System.Windows.Forms.Label _encryptionTypeLabel;
        private System.Windows.Forms.ComboBox _encryptionTypeDropdown;
		private System.Windows.Forms.Label _keyFileLabel;
		private System.Windows.Forms.TextBox _keyFileTextBox;
		private System.Windows.Forms.Button _keyFileBrowseButton;
		private System.Windows.Forms.OpenFileDialog _openFileDialog;
		private System.Windows.Forms.Label _colorDepthLabel;
		private System.Windows.Forms.ComboBox _colorDepthDropdown;
		private System.Windows.Forms.Label _encodingTypeLabel;
		private System.Windows.Forms.ComboBox _encodingTypeDropdown;
		private System.Windows.Forms.Label _titleLabel;
		private System.Windows.Forms.Panel panel1;
    }
}