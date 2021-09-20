using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using AutoClicker.Functions;

namespace AutoClicker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        KeyboardHook hooker;
        string lastMacroPath = null;

        bool isRunning = false;
        private void frmMain_Load(object sender, EventArgs e)
        {
            hooker = new KeyboardHook(this);
        }


        private void OnlyClickFunction()
        {
            int compatibilityTimer = 0;
            if (chcGamesCompatibility.Checked == true)
                compatibilityTimer = 15;
            Thread t = new Thread(() =>
            {
                while (isRunning)
                {
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                    Thread.Sleep(compatibilityTimer);
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
                    Thread.Sleep(Convert.ToInt32(txtClickTimer.Text));
                }
            });
            t.Start();
        }

        private void ClickFunction()
        {
            MouseOperations.MousePoint point = new MouseOperations.MousePoint(Convert.ToInt32(txtLocationX.Text), Convert.ToInt32(txtLocationY.Text));
            int compatibilityTimer = 0;
            if (chcGamesCompatibility.Checked == true)
                compatibilityTimer = 15;
            Thread t = new Thread(() =>
            {
                int count = 0;
                while (isRunning)
                {
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown, point);
                    Thread.Sleep(compatibilityTimer);
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp, point);
                    count++;
                    Thread.Sleep(Convert.ToInt32(txtClickTimer.Text));
                }
            });
            t.Start();
        }

        private void ClickMacroFunction()
        {
            if (string.IsNullOrWhiteSpace(lastMacroPath))
            {
                OpenFileDialog file = new OpenFileDialog();
                file.InitialDirectory = Directory.GetCurrentDirectory() + "macros\\";
                file.Filter = "JSON File |*.json";
                file.ShowDialog();
                lastMacroPath = file.FileName;
            }

            if (!string.IsNullOrWhiteSpace(lastMacroPath))
            {
                int compatibilityTimer = 0;
                if (chcGamesCompatibility.Checked == true)
                    compatibilityTimer = 15;
                var fs = new FileStream(lastMacroPath, FileMode.Open, FileAccess.Read);
                var sr = new StreamReader(fs, Encoding.UTF8);

                MacroEvent[] macro = new JavaScriptSerializer().Deserialize<MacroEvent[]>(sr.ReadToEnd());
                Thread t = new Thread(() =>
                {
                    while (isRunning)
                    {
                        foreach (MacroEvent macroEvent in macro)
                        {
                            if (isRunning)
                            {
                                if (macroEvent.Type == EventType.Click)
                                {
                                    MouseOperations.MousePoint point = new MouseOperations.MousePoint(Convert.ToInt32(macroEvent.LocationX), Convert.ToInt32(macroEvent.LocationY));

                                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown, point);
                                    Thread.Sleep(compatibilityTimer);
                                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp, point);
                                }
                                else if (macroEvent.Type == EventType.Wait)
                                    Thread.Sleep(Convert.ToInt32(macroEvent.Time));
                            }
                        }
                    }
                });
                t.Start();
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        MouseOperations.MousePoint c = MouseOperations.GetCursorPosition();
                        lblCursorLocation.BeginInvoke((Action)(() =>
                        {
                            lblCursorLocation.Text = "X= " + c.X + " Y= " + c.Y;
                        }));
                        Thread.Sleep(100);
                    }
                }
                catch { }
            });
            t.Priority = ThreadPriority.Lowest;
            t.Start();
            radioOnlyClick.Checked = true;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            ClickStarter("Button");
        }

        public void ClickStarter(string Caller)
        {
            isRunning = !isRunning;
            if (Caller == "Button")
                Thread.Sleep(2000);
            if (isRunning)
            {
                btnStartStop.Text = "Stop";
                if (radioOnlyClick.Checked)
                    OnlyClickFunction();
                else if (radioSetCursorandClick.Checked)
                    ClickFunction();
                else if (radioMacro.Checked)
                    ClickMacroFunction();
            }
            else btnStartStop.Text = "Start";
        }


        private void btnMacro_Click(object sender, EventArgs e)
        {
            frmCreateMacro mcr = new frmCreateMacro();
            mcr.ShowDialog();
        }
    }

}
