// Version: 1.0.0.120
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
        private SubtileManager _maneger;
        
        public FormSubtiles()
        {
            InitializeComponent();

            var manager = new WSPSubtile.SubtileManager();
            var sub = new WSPSubtile.Subtile();
            //00:00:03,257 --> 00:00:04,001 Test lini 1
            //00:00:06,001 --> 00:00:10,125 Test 6 sekund lini 1
            //00:00:15,012 --> 00:00:17,414 Oni my wy to
            //00:01:03,089 --> 00:01:07,189 Wyświetla
            manager.AddLinesContent("00:00:03,257", "00:00:04,001", new string[] { "Test lini 1" });
            manager.AddLinesContent("00:00:06,001", "00:00:10,125", new string[] { "Test 6 sekund lini 1" });
            manager.AddLinesContent("00:00:15,012", "00:00:17,414", new string[] { "Oni my wy to" });
            manager.AddLinesContent("00:01:03,089", "00:01:07,189", new string[] { "Wyświetla" });

            foreach (var item in manager.SubtilesDictionary)
            {
                listBoxStartTime.Items.Add(item.Key);
                listBoxEndTime.Items.Add(item.Value.VisibleDuration);
            }

            _maneger = manager;
        }

        private void listBoxStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = listBoxStartTime.SelectedIndex;
            listBoxEndTime.SelectedIndex = index;
            richTextBoxLineI.Text = _maneger.GetLinesContent(listBoxStartTime.Items[index].ToString()).LineContent[0].ToString();
        }
    }
}
