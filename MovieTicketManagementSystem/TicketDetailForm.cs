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
    public partial class TicketDetailForm : Form
    {
       
        
            public TicketDetailForm(string filmAdi, string tarih, string salon, string seans, List<string> koltuklar, Image filmResmi)
            {
                InitializeComponent();

                lblFilm.Text= filmAdi;
                labelFilmAdi.Text = filmAdi;
                labelTarih.Text = $"{tarih} {DateTime.Now.ToString("HH:mm")}";
                lbltrh.Text = $"{tarih} {DateTime.Now.ToString("HH:mm")}";
                lblSalon.Text = salon;
                lblsln.Text = salon;
                labelSeans.Text = seans;
                labelKoltuk.Text = string.Join(", ", koltuklar);
                lblkoltuk.Text = string.Join(", ", koltuklar);
                

        }
        


        private void TicketDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSalon_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
