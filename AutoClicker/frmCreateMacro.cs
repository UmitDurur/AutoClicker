using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class frmCreateMacro : Form
    {
        public frmCreateMacro()
        {
            InitializeComponent();
        }

        List<MacroEvent> MacroEvents = new List<MacroEvent>();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {   if (pnlTime.Visible)
                    pnlTime.Hide();
                pnlClick.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (pnlClick.Visible)
                    pnlClick.Hide();
                pnlTime.Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MacroEvent macro = new MacroEvent();
            if(comboBox1.SelectedIndex==0)
            {
                macro.Type = EventType.Click;
                macro.LocationX = Convert.ToInt32(txtLocationX.Text);
                macro.LocationY = Convert.ToInt32(txtLocationY.Text);
                MacroEvents.Add(macro);
                lstMacro.Items.Add("Click ("+txtLocationX.Text+","+txtLocationY.Text+")");
            }
            else if (comboBox1.SelectedIndex == 1) {
                macro.Type = EventType.Wait;
                macro.Time = Convert.ToInt32(txtMiliseconds.Text);
                MacroEvents.Add(macro);
                lstMacro.Items.Add("Wait :"+txtMiliseconds.Text+" ms");
            }
        }

        private void frmCreateMacro_Shown(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var path = "macros\\"+txtMacroName.Text+".json";
            var fs = new FileStream(path, FileMode.Open, FileAccess.Write);
            var sw = new StreamWriter(fs, Encoding.UTF8);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var serializedMacro = serializer.Serialize(MacroEvents);
            sw.WriteLine(serializedMacro);
            sw.Close();
        }
    }
}
