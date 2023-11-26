// Version: 1.0.0.340
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
        public static ResourceManager rm = new ResourceManager("WindowsSoftberyPlayer.Languages.pl_PL", Assembly.GetExecutingAssembly());
        public FormSettings()
        {
            InitializeComponent();
            translate();
        }

        private void configs()
        {
            //var conf;
        }

        private void translate()
        {
            var lang = $"{System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToLower()}_{System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToUpper()}";
            MessageBox.Show(lang);
            //var res_man = new ResourceManager("WindowsSoftberyPlayer.Languages." + System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName, Assembly.GetExecutingAssembly());
            labelOptions.Text = rm.GetString("formSettings_labelOptions");
        }
    }
}
