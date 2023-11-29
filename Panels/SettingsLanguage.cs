// Version: 1.0.0.80
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSoftberyPlayer.Panels
{
    public partial class SettingsLanguage : UserControl
    {
        public SettingsLanguage()
        {
            InitializeComponent();
            getLanguageList();
        }

        private void getLanguageList()
        {
            comboBoxLangList.Items.Clear();
            var l = Language.LanguagesList;
            foreach (var language in l)
            {
                comboBoxLangList.Items.Add(language.Name);
                if (language.Name == Language.Translation.Name)
                {
                    comboBoxLangList.SelectedItem = language.Name;
                }
            }
        }

        private void comboBoxLangList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Language.ChangeLanguage(comboBoxLangList.SelectedItem.ToString());
        }
    }
}
