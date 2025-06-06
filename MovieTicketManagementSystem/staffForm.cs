﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketManagementSystem
{
    public partial class staffForm : BaseForm
    {
        public staffForm()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Show();
            buyTicketForm1.Hide();

            dashboardForm dForm = dashboardForm1 as dashboardForm;

            if(dForm != null)
            {
                dForm.refreshData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardForm1.Hide();
            buyTicketForm1.Show();

            buyTicketForm btForm = buyTicketForm1 as buyTicketForm;

            if(btForm != null)
            {
                btForm.refreshData();
            }
        }
    }
}


// THATS IT FOR THIS VIDEO. THANKS FOR WATCHING!! 