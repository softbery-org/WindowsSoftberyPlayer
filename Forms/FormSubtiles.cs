// Version: 1.0.0.281
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSPSubtile;

namespace WindowsSoftberyPlayer.Forms
{
    public partial class FormSubtiles : Form
    {
        public FormSubtiles()
        {
            InitializeComponent();

            var manager = new WSPSubtile.SubtileManager();
            var sub = new WSPSubtile.Subtile();
        }

        private void listBoxStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = listBoxStartTime.SelectedIndex;
            listBoxEndTime.SelectedIndex = index;
        }
    }
}
