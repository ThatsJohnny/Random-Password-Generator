namespace Random_Password_Generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.switchButton = new MaterialSkin.Controls.MaterialButton();
            this.copytoclipboardBtn = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lengthLabel = new MaterialSkin.Controls.MaterialLabel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.symbolsCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.digitsCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.uppercaseCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.lowercaseCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.generateBtn = new MaterialSkin.Controls.MaterialButton();
            this.generatedPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.statusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // switchButton
            // 
            this.switchButton.AutoSize = false;
            this.switchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.switchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.switchButton.Depth = 0;
            this.switchButton.HighEmphasis = true;
            this.switchButton.Icon = null;
            this.switchButton.Location = new System.Drawing.Point(633, 220);
            this.switchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.switchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchButton.Name = "switchButton";
            this.switchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.switchButton.Size = new System.Drawing.Size(64, 36);
            this.switchButton.TabIndex = 1;
            this.switchButton.Text = "DARK";
            this.switchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.switchButton.UseAccentColor = false;
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // copytoclipboardBtn
            // 
            this.copytoclipboardBtn.AutoSize = false;
            this.copytoclipboardBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.copytoclipboardBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.copytoclipboardBtn.Depth = 0;
            this.copytoclipboardBtn.HighEmphasis = true;
            this.copytoclipboardBtn.Icon = null;
            this.copytoclipboardBtn.Location = new System.Drawing.Point(463, 220);
            this.copytoclipboardBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.copytoclipboardBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.copytoclipboardBtn.Name = "copytoclipboardBtn";
            this.copytoclipboardBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.copytoclipboardBtn.Size = new System.Drawing.Size(162, 36);
            this.copytoclipboardBtn.TabIndex = 4;
            this.copytoclipboardBtn.Text = "COPY TO CLIPBOARD";
            this.copytoclipboardBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.copytoclipboardBtn.UseAccentColor = false;
            this.copytoclipboardBtn.UseVisualStyleBackColor = true;
            this.copytoclipboardBtn.Click += new System.EventHandler(this.copytoclipboardBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lengthLabel);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.symbolsCheckbox);
            this.groupBox1.Controls.Add(this.digitsCheckbox);
            this.groupBox1.Controls.Add(this.uppercaseCheckbox);
            this.groupBox1.Controls.Add(this.lowercaseCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(6, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 97);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.lengthLabel.Depth = 0;
            this.lengthLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lengthLabel.Location = new System.Drawing.Point(410, 20);
            this.lengthLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(10, 19);
            this.lengthLabel.TabIndex = 7;
            this.lengthLabel.Text = "8";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 19);
            this.trackBar1.Maximum = 128;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(404, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // symbolsCheckbox
            // 
            this.symbolsCheckbox.AutoSize = true;
            this.symbolsCheckbox.Depth = 0;
            this.symbolsCheckbox.Location = new System.Drawing.Point(338, 56);
            this.symbolsCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.symbolsCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.symbolsCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.symbolsCheckbox.Name = "symbolsCheckbox";
            this.symbolsCheckbox.ReadOnly = false;
            this.symbolsCheckbox.Ripple = true;
            this.symbolsCheckbox.Size = new System.Drawing.Size(97, 37);
            this.symbolsCheckbox.TabIndex = 0;
            this.symbolsCheckbox.Text = "Symbols";
            this.symbolsCheckbox.UseVisualStyleBackColor = true;
            // 
            // digitsCheckbox
            // 
            this.digitsCheckbox.AutoSize = true;
            this.digitsCheckbox.Depth = 0;
            this.digitsCheckbox.Location = new System.Drawing.Point(252, 56);
            this.digitsCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.digitsCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.digitsCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.digitsCheckbox.Name = "digitsCheckbox";
            this.digitsCheckbox.ReadOnly = false;
            this.digitsCheckbox.Ripple = true;
            this.digitsCheckbox.Size = new System.Drawing.Size(76, 37);
            this.digitsCheckbox.TabIndex = 0;
            this.digitsCheckbox.Text = "Digits";
            this.digitsCheckbox.UseVisualStyleBackColor = true;
            // 
            // uppercaseCheckbox
            // 
            this.uppercaseCheckbox.AutoSize = true;
            this.uppercaseCheckbox.Depth = 0;
            this.uppercaseCheckbox.Location = new System.Drawing.Point(133, 56);
            this.uppercaseCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.uppercaseCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.uppercaseCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.uppercaseCheckbox.Name = "uppercaseCheckbox";
            this.uppercaseCheckbox.ReadOnly = false;
            this.uppercaseCheckbox.Ripple = true;
            this.uppercaseCheckbox.Size = new System.Drawing.Size(109, 37);
            this.uppercaseCheckbox.TabIndex = 0;
            this.uppercaseCheckbox.Text = "Uppercase";
            this.uppercaseCheckbox.UseVisualStyleBackColor = true;
            // 
            // lowercaseCheckbox
            // 
            this.lowercaseCheckbox.AutoSize = true;
            this.lowercaseCheckbox.Checked = true;
            this.lowercaseCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowercaseCheckbox.Depth = 0;
            this.lowercaseCheckbox.Location = new System.Drawing.Point(12, 56);
            this.lowercaseCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.lowercaseCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lowercaseCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.lowercaseCheckbox.Name = "lowercaseCheckbox";
            this.lowercaseCheckbox.ReadOnly = false;
            this.lowercaseCheckbox.Ripple = true;
            this.lowercaseCheckbox.Size = new System.Drawing.Size(111, 37);
            this.lowercaseCheckbox.TabIndex = 0;
            this.lowercaseCheckbox.Text = "Lowercase";
            this.lowercaseCheckbox.UseVisualStyleBackColor = true;
            // 
            // generateBtn
            // 
            this.generateBtn.AutoSize = false;
            this.generateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.generateBtn.Depth = 0;
            this.generateBtn.HighEmphasis = true;
            this.generateBtn.Icon = null;
            this.generateBtn.Location = new System.Drawing.Point(463, 142);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.generateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.generateBtn.Size = new System.Drawing.Size(234, 66);
            this.generateBtn.TabIndex = 6;
            this.generateBtn.Text = "Generate";
            this.generateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.generateBtn.UseAccentColor = false;
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // generatedPassword
            // 
            this.generatedPassword.AnimateReadOnly = false;
            this.generatedPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.generatedPassword.Depth = 0;
            this.generatedPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.generatedPassword.LeadingIcon = null;
            this.generatedPassword.Location = new System.Drawing.Point(6, 83);
            this.generatedPassword.MaxLength = 50;
            this.generatedPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.generatedPassword.Multiline = false;
            this.generatedPassword.Name = "generatedPassword";
            this.generatedPassword.Size = new System.Drawing.Size(691, 50);
            this.generatedPassword.TabIndex = 7;
            this.generatedPassword.Text = "";
            this.generatedPassword.TrailingIcon = null;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Depth = 0;
            this.statusLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statusLabel.Location = new System.Drawing.Point(6, 239);
            this.statusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(59, 19);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status: -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 265);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.generatedPassword);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.copytoclipboardBtn);
            this.Controls.Add(this.switchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(706, 265);
            this.MinimumSize = new System.Drawing.Size(706, 265);
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Random Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton switchButton;
        private MaterialSkin.Controls.MaterialButton copytoclipboardBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialCheckbox symbolsCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox digitsCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox uppercaseCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox lowercaseCheckbox;
        private System.Windows.Forms.TrackBar trackBar1;
        private MaterialSkin.Controls.MaterialButton generateBtn;
        private MaterialSkin.Controls.MaterialLabel lengthLabel;
        private MaterialSkin.Controls.MaterialTextBox generatedPassword;
        private MaterialSkin.Controls.MaterialLabel statusLabel;
    }
}

