using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevOne.Security.Cryptography.BCrypt;

namespace ADS_BcryptProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // create the salt of 10 bits
            string salt = BCryptHelper.GenerateSalt(10);
            txtOutput.Text = salt + "\r\n";
            //hash the password
            string passwordHash = BCryptHelper.HashPassword("Tom123", salt);
            txtOutput.Text += passwordHash + "\r\n";
            //check if passwords match
            bool value = BCryptHelper.CheckPassword("Tom123", passwordHash);
            txtOutput.Text += value;
        }
    }
}
