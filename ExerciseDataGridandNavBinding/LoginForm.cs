﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseDataGridandNavBinding
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "admin" && txtPass.Text == "123" && cbTnc.Checked)
            {
                MenuForm menu = new MenuForm();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your Username and Password!");
            }
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
