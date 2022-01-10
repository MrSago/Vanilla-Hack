
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Memory;

namespace Vanilla_Hack
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public const string AoBstr = "?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 4? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 3F 78 ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 ?? 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 4? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00";
        public Mem MemLib = new Mem();
        public int pID = 0;
        public long AoBadr = 0;
        public bool comp = false;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pID != 0)
            {
                comp = false;

                MemLib.WriteMemory("0x" + (AoBadr + 0x8c).ToString("x8"), "float", "7");    //speedHack
                MemLib.WriteMemory("0x0087D894", "float", "60,14800262");                   //fallingSpeed
                MemLib.WriteMemory("0x0080DFFC", "float", "0,6427876353");                  //wallClimbing
                MemLib.WriteMemory("0x007C63DA", "bytes", "0x8B 0x4F 0x78");                //noFallingDamage
                MemLib.WriteMemory("base+0x3C620D", "bytes", "0x20 0x00");                  //flyHack
                MemLib.WriteMemory("base+0x2163DB", "bytes", "0x8A 0x47");                  //antiRoot
                MemLib.WriteMemory("0x00615BA7", "bytes", "0xF4 0x01 0x00 0x00");           //heartbit
                MemLib.WriteMemory("0x006CA1B5", "byte", "0x74");                           //disableWarden
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pID = MemLib.GetProcIdFromName("WoW");

            if (pID == 0)
            {
                AoBadr = 0;
                comp = false;

                procID_label.Text = "####";

                procStatus_label.Text = "CLOSED";
                procStatus_label.ForeColor = Color.Crimson;

                gameVersion_label.Text = "XXXX";

                compatibility_label.Text = "Unknown";
                compatibility_label.ForeColor = Color.Black;

                playerBase_label.Text = "0x00000000";
                findBase_button.Text = "Find Player Base";

                return;
            }

            procID_label.Text = pID.ToString();

            if (!MemLib.OpenProcess(pID))
            {
                AoBadr = 0;
                comp = false;

                procStatus_label.Text = "CLOSED";
                procStatus_label.ForeColor = Color.Crimson;

                return;
            }

            procStatus_label.Text = "OPEN";
            procStatus_label.ForeColor = Color.Green;

            gameVersion_label.Text = MemLib.ReadString("0x00837C04");

            if (gameVersion_label.Text == "1.12.1")
            {
                comp = true;
                compatibility_label.Text = "YES";
                compatibility_label.ForeColor = Color.Green;
            }
            else
            {
                comp = false;
                gameVersion_label.Text = "Unknown";
                compatibility_label.Text = "NO";
                compatibility_label.ForeColor = Color.Crimson;
                return;
            }

            if (AoBadr == 0)
            {
                playerBase_label.Text = "0x00000000";
                return;
            }

            if (disableWarden_checkBox.Checked)
            {
                MemLib.WriteMemory("0x006CA1B5", "byte", "0xEB");
            }
            else
            {
                MemLib.WriteMemory("0x006CA1B5", "byte", "0x74");
            }

            if (speedHack_checkBox.Checked)
            {
                if (!string.IsNullOrEmpty(movementSpeed_box.Text) &&
                    int.TryParse(movementSpeed_box.Text, out int speed))
                {
                    if (speed < 0) speed = 0;
                    else if (speed > 15) speed = 15;
                    MemLib.WriteMemory("0x" + (AoBadr + 0x8c).ToString("x8"), "float", speed.ToString());
                }
            }
            else
            {
                MemLib.WriteMemory("0x" + (AoBadr + 0x8c).ToString("x8"), "float", "7");
            }

            if (fallingHack_checkBox.Checked)
            {
                if (!string.IsNullOrEmpty(fallingSpeed_box.Text) &&
                    int.TryParse(fallingSpeed_box.Text, out int speed))
                {
                    if (speed < 0) speed = 0;
                    MemLib.WriteMemory("0x0087D894", "float", speed.ToString());
                }
            }
            else
            {
                MemLib.WriteMemory("0x0087D894", "float", "60,14800262");
            }

            if (wallClimbing_checkBox.Checked)
            {
                MemLib.WriteMemory("0x0080DFFC", "bytes", "0x00 0x00 0x00 0x00");
            }
            else
            {
                MemLib.WriteMemory("0x0080DFFC", "bytes", "0xBB 0x8D 0x24 0x3F");
            }

            if (noFallingDamage_checkBox.Checked)
            {
                MemLib.WriteMemory("0x007C63DA", "bytes", "0x31 0xC9 0x90");
            }
            else
            {
                MemLib.WriteMemory("0x007C63DA", "bytes", "0x8B 0x4F 0x78");
            }

            if (flyHack_checkBox.Checked)
            {
                MemLib.WriteMemory("base+0x3C620D", "bytes", "0x00 0x20");
            }
            else
            {
                MemLib.WriteMemory("base+0x3C620D", "bytes", "0x20 0x00");
            }

            if (antiRoot_checkbox.Checked)
            {
                MemLib.WriteMemory("base+0x2163DB", "bytes", "0xEB 0xF9");
            }
            else
            {
                MemLib.WriteMemory("base+0x2163DB", "bytes", "0x8A 0x47");
            }

            if (heartBeat_checkBox.Checked)
            {
                MemLib.WriteMemory("0x00615BA7", "bytes", "0x01 0x00 0x00 0x00");
            }
            else
            {
                MemLib.WriteMemory("0x00615BA7", "bytes", "0xF4 0x01 0x00 0x00");
            }
        }

        private async void Button1_ClickAsync(object sender, EventArgs e)
        {
            if (pID != 0 && comp == true)
            {
                findBase_button.Text = "Please Wait!";
                findBase_button.Enabled = false;
                Cursor = Cursors.WaitCursor;
                Enabled = false;

                try
                {
                    AoBadr = (await MemLib.AoBScan(AoBstr, true, true)).FirstOrDefault();
                }
                finally
                {
                    Enabled = true;
                    Cursor = Cursors.Default;
                    findBase_button.Enabled = true;
                }

                if (AoBadr != 0)
                {
                    findBase_button.Text = "Found!";
                    playerBase_label.Text = "0x" + AoBadr.ToString("x8");
                }
                else
                {
                    findBase_button.Text = "Not Found!";
                }
            }
        }

        private void CheckBoxHacks_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (!cb.Checked)
            {
                return;
            }

            if (AoBadr == 0)
            {
                cb.Checked = false;
                MessageBox.Show("Find player base first!", "Player Base", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!disableWarden_checkBox.Checked)
            {
                cb.Checked = false;
                MessageBox.Show("Warden is enabled!\nYou may be banned!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb.Checked = true;
            }
        }
    }
}

