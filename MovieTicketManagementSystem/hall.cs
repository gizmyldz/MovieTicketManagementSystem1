using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketManagementSystem
{
    public partial class hall : UserControl
    {
        public hall()
        {
            InitializeComponent();
        }

        string conn = @"Data Source=DESKTOP-QKMG9KF\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True";

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conn)) 
            {
                string query = "INSERT INTO Salons (SalonAdi, Kapasite) VALUES (@adi, @kapasite)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@adi", textBoxHall.Text);
                cmd.Parameters.AddWithValue("@kapasite", (int)numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@status", comboBoxStatus.SelectedItem.ToString());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Hall is added.");
            Listele(); // DataGridView güncellenir
        }


        private void Listele()
        {
            using (SqlConnection con = new SqlConnection(conn)) 
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Salons", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        int selectedID = 0;

      

       
       

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Please pick a hall.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conn))
            {
              //  string query = "UPDATE Salons SET SalonAdi = @adi, Kapasite = @kapasite WHERE SalonID = @id";
                string query = "UPDATE Salons SET SalonAdi = @adi, Kapasite = @kapasite, Status = @status WHERE SalonID = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@adi", textBoxHall.Text);
                cmd.Parameters.AddWithValue("@kapasite", (int)numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@id", selectedID);
                cmd.Parameters.AddWithValue("@status", comboBoxStatus.SelectedItem.ToString());


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Hall informations are updated.");
            Listele();
        }


        /*
        private void buttonDelete_Click_1(object sender, EventArgs e)
        {

            if (selectedID == 0)
            {
                MessageBox.Show("Please pick a hall.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this hall?", "Accept", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    string query = "DELETE FROM Salons WHERE SalonID = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", selectedID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Hall is deleted.");
                Listele();
                selectedID = 0;
                textBoxHall.Clear();
                numericUpDown1.Value = 0;
            }
        }
        */





        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("Please pick a hall.");
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to delete this hall?",
                "Accept",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            using (var con = new SqlConnection(conn))
            {
                con.Open();
                using (var tx = con.BeginTransaction())
                {
                    try
                    {
                        // 1) İlgili seanslardaki koltuk durumlarını sil (eğer bu tablonuz varsa)
                        using (var cmd = new SqlCommand(@"
                    DELETE ss
                    FROM SeatStatus ss
                    INNER JOIN Seanslar s
                      ON ss.SeansID = s.SeansID
                    WHERE s.SalonID = @id
                ", con, tx))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedID);
                            cmd.ExecuteNonQuery();
                        }

                        // 2) Seanslar tablosundan sil
                        using (var cmd = new SqlCommand(@"
                    DELETE FROM Seanslar
                    WHERE SalonID = @id
                ", con, tx))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedID);
                            cmd.ExecuteNonQuery();
                        }

                        // 3) Son olarak Salons tablosundan sil
                        using (var cmd = new SqlCommand(@"
                    DELETE FROM Salons
                    WHERE SalonID = @id
                ", con, tx))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedID);
                            cmd.ExecuteNonQuery();
                        }

                        tx.Commit();
                        MessageBox.Show("Hall and its related sessions have been deleted.");
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        MessageBox.Show("Delete failed: " + ex.Message);
                    }
                }
            }

            // Listeyi yenileyin
            Listele();
            selectedID = 0;
            textBoxHall.Clear();
            numericUpDown1.Value = 0;
        }





        private void hall_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedID = Convert.ToInt32(row.Cells[0].Value);
                textBoxHall.Text = row.Cells[1].Value.ToString();
                numericUpDown1.Value = Convert.ToInt32(row.Cells[2].Value);
                comboBoxStatus.SelectedItem = row.Cells[3].Value.ToString(); // 3. sütun = Status

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            selectedID = 0;
            textBoxHall.Clear();
            numericUpDown1.Value = 0;
            comboBoxStatus.SelectedIndex = -1;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
