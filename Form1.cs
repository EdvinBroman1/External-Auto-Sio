using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSio860
{
    public partial class Form1 : Form
    {
        Client Tibia = new Client();
        public Form1()
        {
            InitializeComponent();

            if (!Tibia.isAttached)
            {
                Text = Tibia.ProcessStatus;
            }
            else
            {
                Text = "Auto Sio"; 
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Enter A Player Name", "Error");
                    checkBox1.Checked = false;
                }
                else
                {
                    Player Target = Game.FindPlayer(textBox1.Text);
                    if (Target != null)
                    {
                        HealTimer.Start();
                        textBox1.Enabled = false;
                    }
                    else {
                    }
                }
            }
            if (!checkBox1.Checked)
            {
                textBox1.Enabled = true;
                HealTimer.Stop();
            }

        }

        private void HealTimer_Tick(object sender, EventArgs e)
        {
            Player Target = Game.FindPlayer(textBox1.Text);
            if (Target != null && Target.GetHealthProcent < numericUpDown1.Value)
            {
                Healer.SendHeal(Target.GetName);
            }
        }
    }
}
