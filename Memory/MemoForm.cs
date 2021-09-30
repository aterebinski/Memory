using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Memory
{
    public partial class MemoForm : Form
    {
        List<string> myIcons = new List<string> { "a", "a", "b", "b", "c", "c", "d", "d", "e", "e", "f", "f", "g", "g", "h", "h" };
        Random random = new Random();
        Label first;
        Label second;
        int myTime = 120;
        public MemoForm()
        {
            InitializeComponent();

            for (int i = 0; i < polePanel.Controls.Count; i++)
            {
                int pos = random.Next(myIcons.Count);
                string sign = myIcons[pos];
                polePanel.Controls[i].Text = sign.ToString();
                polePanel.Controls[i].ForeColor = polePanel.Controls[i].BackColor;
                myIcons.RemoveAt(pos);
            }

            first = null;
            second = null;
            
        }

        private void icon_click(object sender, EventArgs e)
        {
            Label label = sender as Label;

            if (timer1.Enabled)
            {
                return;
            }

            if (label.ForeColor == Color.Black)
                return; //kliknięto już odkryty kafelek

            label.ForeColor = Color.Black;

            if (first == null)
            {    
                first = label;
            }
            else
            {
                second = label;

                if (first.Text == second.Text)
                {
                    
                    bool allFound = true;
                    foreach (var item in polePanel.Controls)
                    {
                        Label l = item as Label;
                        if (l.ForeColor == l.BackColor)
                        {
                            allFound = false;
                        }
                    }

                    first = null;
                    second = null;

                    if (allFound)
                    {
                        MessageBox.Show("All icons have been found!");
                        timer2.Stop();
                    }
                }
                else
                {
                    timer1.Start();
                    
                }

                
            }
        }

        private void MemoForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            first.ForeColor = first.BackColor;
            second.ForeColor = second.BackColor;
            first = null;
            second = null;
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value>0)
            {
                myTime--;
                progressBar1.Value = myTime;
                timeLabel.Text = myTime.ToString();
            }
            else
            {
                timer2.Stop();
                MessageBox.Show("Game Over!");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
