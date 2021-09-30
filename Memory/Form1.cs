using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
            hideRespond();
        }

        private void hideRespond()
        {
            firstNameRespond.ForeColor = firstNameRespond.BackColor;
            lastNameRespond.ForeColor = lastNameRespond.BackColor;
            emailRespond.ForeColor = emailRespond.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            hideRespond();

            bool isCorrect = true;
            if (firstNameEdit.Text == "")
            {
                firstNameRespond.ForeColor = Color.Maroon;
                firstNameRespond.Text = "Improper First Name";
                isCorrect = false;
            }

            if (lastNameEdit.Text == "")
            {
                lastNameRespond.ForeColor = Color.Maroon;
                lastNameRespond.Text = "Improper Last Name";
                isCorrect = false;
            }

            if (emailEdit.Text == "" || !emailEdit.Text.Contains('@'))
            {
                emailRespond.Text = "Incorrect email";
                emailRespond.ForeColor = Color.Maroon;
                isCorrect = false;
            }

            if (isCorrect)
            {
                MemoForm memoForm = new MemoForm();
                memoForm.ShowDialog();
            }

            
        }

    }
}
