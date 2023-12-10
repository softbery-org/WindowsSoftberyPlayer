// Version: 1.0.0.657
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translator;
using WindowsSoftberyPlayer.Panels;

namespace WindowsSoftberyPlayer.Forms
{
    public partial class FormSettings : Form
    {
        /// <summary>
        /// Translation
        /// </summary>
        //private static ResourceManager _translation = new ResourceManager($"WindowsSoftberyPlayer.Languages.{Config.Parameters["Player"]["Language"]}", Assembly.GetExecutingAssembly());
        private UserControl _currentPanel;
        private Dictionary<string,string> _options = new Dictionary<string, string>() {
                { "Language", "SettingsLanguage" },
                { "Subtile", "SettingsSubtile" }
            };

        public FormSettings()
        {
            InitializeComponent();
            translate();
            createListBoxOptions();
            SettingsLanguage.OnLanguageChange += RefreshForm;
        }

        private void RefreshForm()
        {
            this.ChangeLanguage();
            translate();
        }

        private void RefreshForm(string name)
        {
            this.ChangeLanguage(name);
            translate();
        }

        private void translate()
        {
            btnSave.Text = Language.Translation.formSettings_btnSave;//_translation.GetString("formSettings_btnSave");
            btnCancel.Text = Language.Translation.formSettings_btnCancel;//_translation.GetString("formSettings_btnCancel");
            this.Text = Language.Translation.formSettings_Text;//_translation.GetString("formSettings_frmText");
            labelOptions.Text = Language.Translation.formSettings_labelOptions;//_translation.GetString("formSettings_labelOptions");

            // Opacity
            //Color newC = Color.FromArgb(c.A*(opacity/100), c.R*(opacity/100),c.G*(opacity/100),c.B*(opacity/100));
            Refresh();
        }

        private void createListBoxOptions()
        {
            foreach (var item in _options)
            {
                listBoxOptions.Items.Add(item.Key);
            }
        }

        private void activeOnClick(string panel_name)
        {
            var last_control = new UserControl();
            if (_currentPanel!=null)
                last_control = _currentPanel;

            if (_options.ContainsKey(panel_name))
            {
                var typo = Type.GetType("WindowsSoftberyPlayer.Panels." + _options[panel_name], true);
                _currentPanel = (UserControl)Activator.CreateInstance(typo);
                _currentPanel.CreateControl();

                if (panelSettings.Controls.Contains(last_control))
                    panelSettings.Controls.Remove(last_control);

                panelSettings.Controls.Add(_currentPanel);
                Refresh();
            }
        }

        private void listBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeOnClick(listBoxOptions.SelectedItem.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Config.Write();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Config.Read();
            RefreshForm();
            this.Close();
        }
    }
}
