using System;
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
    public partial class AdminForm : BaseForm
    {
        private hall hallForm = new hall();
        public AdminForm()
        {
            InitializeComponent();

           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?", "Confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to logout?", "Confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Show();
            addStaffsForm1.Hide();
            addMovieForm1.Hide();
            hallForm.Hide();

            dashboardForm dForm = dashboardForm1 as dashboardForm;

            if(dForm != null)
            {
                dForm.refreshData();
            }

        }

        private void addStaff_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Hide();
            addStaffsForm1.Show();
            addMovieForm1.Hide();
            hallForm.Hide();

            AddStaffsForm asForm = addStaffsForm1 as AddStaffsForm;

            if(asForm != null)
            {
                asForm.refreshData();
            }
        }

        private void addMovie_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Hide();
            addStaffsForm1.Hide();
            hallForm.Hide();
            addMovieForm1.Show();

            AddMovieForm amForm = addMovieForm1 as AddMovieForm;

            if(amForm != null)
            {
                amForm.refreshData();
            }
        }

        


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dashboardForm1.Hide();
            addStaffsForm1.Hide();
            addMovieForm1.Hide();
         //   hall hallForm = new hall();
            hallForm.Show();
        }

        private void addMovieForm1_Load(object sender, EventArgs e)
        {

        }

        private void addStaffsForm1_Load(object sender, EventArgs e)
        {

        }

        private void dashboardForm1_Load(object sender, EventArgs e)
        {

        }

        private void btnTotalMovies_Click(object sender, EventArgs e)
        {
            var totalForm = new TotalMoviesFormcs();
            totalForm.ShowDialog();
        }
    }
}
