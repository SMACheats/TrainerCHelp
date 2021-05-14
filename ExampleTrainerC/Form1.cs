using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

//
//
//  ____          ____  __  __    _    ____ _                _       
// | __ ) _   _  / ___||  \/  |  / \  / ___| |__   ___  __ _| |_ ___ 
// |  _ \| | | | \___ \| |\/| | / _ \| |   | '_ \ / _ \/ _` | __/ __|
// | |_) | |_| |  ___) | |  | |/ ___ \ |___| | | |  __/ (_| | |_\__ \
// |____/ \__, | |____/|_|  |_/_/   \_\____|_| |_|\___|\__,_|\__|___/
//        |___/                                                      
//
//

namespace ExampleTrainerC
{
    public partial class Form1 : Form
    {
        private string TeleportX = "server.dll+0083BB7C,30C";
        private string TeleportY = "server.dll+0083BB7C,308";
        private string TeleportZ = "server.dll+0083BB7C,310";

        private string AmmoAdd = "server.dll+0084269C,4D4";
        private string AmmoFrezze = "server.dll+0084269C,4D4";
        private string AmmoScript = "server.dll+48BDCB";

        Mem m = new Mem();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName("bms"); // Type "Your Game .exe"
            if (PID > 0)
            {
                m.OpenProcess(PID);
                MessageBox.Show("Found Game");
                BackgroundCheats.RunWorkerAsync(); // for background timer
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }

        private void BackgroundCheats_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                float CoordsX = m.ReadFloat(TeleportX);
                label1.Text = "X: " + CoordsX.ToString();

                float CoordsY = m.ReadFloat(TeleportY);
                label2.Text = "Y: " + CoordsY.ToString();

                float CoordsZ = m.ReadFloat(TeleportZ);
                label3.Text = "Z: " + CoordsZ.ToString();

                if (XModifer.Checked)
                {
                    m.WriteMemory(TeleportX, "float", XTrackbar.Value.ToString());
                }
                if (YModifer.Checked)
                {
                    m.WriteMemory(TeleportY, "float", YTrackbar.Value.ToString());
                }
                if (ZModifer.Checked)
                {
                    m.WriteMemory(TeleportZ, "float", ZTrackbar.Value.ToString());
                }
            }
        }

        private void AddAmmo_Click(object sender, EventArgs e)
        {
            m.WriteMemory(AmmoAdd, "int", "99");
        }

        private void FrezzeAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (FrezzeAmmo.Checked)
            {
                m.FreezeValue(AmmoFrezze, "int", "99");
            }
            else
            {
                m.UnfreezeValue(AmmoFrezze);
            }
        }

        private void AllAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (AllAmmo.Checked)
            {
                m.WriteMemory(AmmoScript, "bytes", "90 90 EB 37 89 02");
            }
            else
            {
                m.WriteMemory(AmmoScript, "bytes", "89 02 EB 37 89 02");
            }
        }
    }
}
