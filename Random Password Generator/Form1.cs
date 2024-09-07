using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Random_Password_Generator
{
    public partial class Form1 : MaterialForm
    {
        private bool DarkTheme = false;

        public Form1()
        {
            InitializeComponent();

            // Thema core
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);

            // Check checkboxes, als er geen aan staat gaat de Generated Password knop uit
            lowercaseCheckbox.CheckedChanged += new EventHandler(CheckCheckboxes);
            uppercaseCheckbox.CheckedChanged += new EventHandler(CheckCheckboxes);
            digitsCheckbox.CheckedChanged += new EventHandler(CheckCheckboxes);
            symbolsCheckbox.CheckedChanged += new EventHandler(CheckCheckboxes);

            // Copy to clipboard knop uit totdat je op Generated Password knop hebt gedrukt
            copytoclipboardBtn.Enabled = false;

            // generatedPassword Textbox Read Only Bitch
            generatedPassword.ReadOnly = true;
        }

        private void GeneratedPassword_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            if (DarkTheme)
            {
                // Licht Thema
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
                switchButton.Text = "DARK"; // Update button text to reflect current theme
                DarkTheme = false; // Update flag
                statusLabel.Text = "Status: LIGHT THEME";
            }
            else
            {
                // Donker Thema
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
                switchButton.Text = "LIGHT"; // Update button text to reflect current theme
                DarkTheme = true; // Update flag
                statusLabel.Text = "Status: DARK THEME";
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lengthLabel.Text = trackBar1.Value.ToString();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (!lowercaseCheckbox.Checked & !uppercaseCheckbox.Checked & !digitsCheckbox.Checked & !symbolsCheckbox.Checked)
            {
                // Knop is grijs als je geen checkbox aan hebt
                // MessageBox.Show("Please select at least one checkbox.");
            }
            else
            {
                GenerateConfig config = getGenerateConfig();
                generatedPassword.Text = PasswordGenHelper.GeneratePassword(config);
                statusLabel.Text = "Status: GENERATED PASSWORD";
                copytoclipboardBtn.Enabled = true; // Zet copy to clipboard btn aan
            }
        }

            private GenerateConfig getGenerateConfig()
        {
            GenerateConfig config = new GenerateConfig();
            config.Length = trackBar1.Value;
            config.IsLowerCase = lowercaseCheckbox.Checked;
            config.IsUppercase = uppercaseCheckbox.Checked;
            config.IsDigits = digitsCheckbox.Checked;
            config.IsSymbols = symbolsCheckbox.Checked;
            return config;
        }

        private void copytoclipboardBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(generatedPassword.Text);
            // MessageBox.Show("Password copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            statusLabel.Text = "Status: COPY TO CLIPBOARD";
        }

        private void CheckCheckboxes(object sender, EventArgs e)
        {
            // Check if at least one checkbox is checked
            if (lowercaseCheckbox.Checked || uppercaseCheckbox.Checked || digitsCheckbox.Checked || symbolsCheckbox.Checked)
            {
                generateBtn.Enabled = true;  // Enable the button if at least one checkbox is checked
            }
            else
            {
                generateBtn.Enabled = false;  // Disable the button if no checkbox is checked
            }
        }

        private void CheckPasswordField(object sender, EventArgs e)
        {
            // Enable the copy to clipboard button if the generatedPassword is not empty, otherwise disable it
            copytoclipboardBtn.Enabled = !string.IsNullOrWhiteSpace(copytoclipboardBtn.Text);
        }

    }
}
