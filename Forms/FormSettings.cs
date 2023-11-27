// Version: 1.0.0.389
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

namespace WindowsSoftberyPlayer.Forms
{
    public partial class FormSettings : Form
    {
        /// <summary>
        /// Translation
        /// </summary>
        private static ResourceManager _translation = new ResourceManager($"WindowsSoftberyPlayer.Languages.{Config.Parameters["Player"]["Language"]}", Assembly.GetExecutingAssembly());
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
        }

        private void translate()
        {
            btnSave.Text = _translation.GetString("formSettings_btnSave");
            btnCancel.Text = _translation.GetString("formSettings_btnCancel");
            this.Text = _translation.GetString("formSettings_frmText");
            labelOptions.Text = _translation.GetString("formSettings_labelOptions");
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
    }
}
