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

        private void iconClick(object sender, EventArgs e)
        {

            if (first == null)
            {
                first = sender as Label;
            }
            else
            {

            }
        }

        private void MemoForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            iconClick(sender, e);
        }
    }
}
