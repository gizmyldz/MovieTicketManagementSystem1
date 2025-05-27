using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MovieTicketManagementSystem
{


    public partial class Seat : Form
    {

      
        private int seansID;

        private const int Rows = 6; // A-F
        private const int Columns = 6; // 1-6
        private const int SeatWidth = 52;
        private const int SeatHeight = 47;
        private const int Padding = 12;
        private readonly char[] RowLabels = { 'F', 'E', 'D', 'C', 'B', 'A' };

        private int salonID;
        public List<string> SelectedSeats { get; private set; } = new List<string>();
        
        public Seat(int selectedSalonId, int selectedSeansId)
        {
            InitializeComponent();
            salonID = selectedSalonId;

            seansID = selectedSeansId;

            CreateSeatGrid();
            

        }

        /*     private void CreateSeatGrid()
             {
                 for (int i = 0; i < Rows; i++)
                 {
                     for (int j = 0; j < Columns; j++)
                     {
                         PictureBox seat = new PictureBox
                         {
                             Name = $"seat_{RowLabels[i]}{j + 1}",
                             Size = new Size(SeatWidth, SeatHeight),
                             Location = new Point(20 + j * (SeatWidth + Padding), 20 + i * (SeatHeight + Padding)),
                             SizeMode = PictureBoxSizeMode.Zoom,
                             BackColor = Color.Transparent,
                             Image = Properties.Resources.available, // Gri boş koltuk
                             Tag = "available",
                             Cursor = Cursors.Hand
                         };

                         seat.Click += Seat_Click;
                         this.Controls.Add(seat);
                     }
                 }

                 // Confirm button
                 Button confirmButton = new Button
                 {
                     Text = "Confirm Selection",
                     AutoSize = true,
                     Location = new Point(20, 20 + Rows * (SeatHeight + Padding) + 10)
                 };

                 confirmButton.Click += ConfirmButton_Click;
                 this.Controls.Add(confirmButton);
             }
        */

        /*
         * 
         *bu kalsın doğru hali
         private void CreateSeatGrid()
         {
             HashSet<string> bookedSeats = new HashSet<string>();

             // Veritabanından mevcut salonun booked koltuklarını al
             string connection = @"Data Source=DESKTOP-QKMG9KF\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;";
             using (SqlConnection conn = new SqlConnection(connection))
             {
                 conn.Open();

                 string query = "SELECT S.SeatCode, SS.Status\r\nFROM SeatStatus SS\r\nJOIN Seats S ON SS.SeatID = S.Id\r\nWHERE SS.SeansID = @selectedSeansID\r\n";
                 using (SqlCommand cmd = new SqlCommand(query, conn))
                 {
                     cmd.Parameters.AddWithValue("@selectedSeansID", seansID); // salonID dışarıdan alınmalı
                     SqlDataReader reader = cmd.ExecuteReader();

                     while (reader.Read())
                     {
                         bookedSeats.Add(reader["SeatCode"].ToString());
                     }
                 }
             }

             // Koltukları oluştur
             for (int i = 0; i < Rows; i++)
             {
                 for (int j = 0; j < Columns; j++)
                 {
                     string seatCode = $"{RowLabels[i]}{j + 1}";

                     PictureBox seat = new PictureBox
                     {
                         Name = $"seat_{seatCode}",
                         Size = new Size(SeatWidth, SeatHeight),
                         Location = new Point(20 + j * (SeatWidth + Padding), 20 + i * (SeatHeight + Padding)),
                         SizeMode = PictureBoxSizeMode.Zoom,
                         BackColor = Color.Transparent,
                         Cursor = Cursors.Hand
                     };

                     if (bookedSeats.Contains(seatCode))
                     {
                         // Koltuk rezerve edilmiş: kırmızı yap, devre dışı bırak
                         seat.Image = Properties.Resources.bookedd;
                         seat.Tag = "booked";
                         seat.Enabled = false;
                     }
                     else
                     {
                         // Koltuk boş: gri yap, seçilebilir
                         seat.Image = Properties.Resources.available;
                         seat.Tag = "available";
                     }

                     seat.Click += Seat_Click;
                     this.Controls.Add(seat);
                 }
             }

             // Confirm button
             Button confirmButton = new Button
             {
                 Text = "Confirm Selection",
                 AutoSize = true,
                 Location = new Point(20, 20 + Rows * (SeatHeight + Padding) + 10)
             };

             confirmButton.Click += ConfirmButton_Click;
             this.Controls.Add(confirmButton);
         }

         */

        private void CreateSeatGrid()
        {
            HashSet<string> bookedSeats = new HashSet<string>();

            string connection = @"Data Source=DESKTOP-QKMG9KF\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                // ✅ Sadece 'Dolu' koltukları çekiyoruz
                string query = @"
            SELECT S.SeatCode
            FROM SeatStatus SS
            JOIN Seats S ON SS.SeatID = S.Id
            WHERE SS.SeansID = @selectedSeansID AND SS.Status = 'Dolu'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@selectedSeansID", seansID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        bookedSeats.Add(reader["SeatCode"].ToString());
                    }
                }
            }

            // Koltukları oluştur
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    string seatCode = $"{RowLabels[i]}{j + 1}";

                    PictureBox seat = new PictureBox
                    {
                        Name = $"seat_{seatCode}",
                        Size = new Size(SeatWidth, SeatHeight),
                        Location = new Point(20 + j * (SeatWidth + Padding), 20 + i * (SeatHeight + Padding)),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        BackColor = Color.Transparent,
                        Cursor = Cursors.Hand
                    };

                    if (bookedSeats.Contains(seatCode))
                    {
                        seat.Image = Properties.Resources.bookedd;
                        seat.Tag = "booked";
                        seat.Enabled = false;
                    }
                    else
                    {
                        seat.Image = Properties.Resources.available;
                        seat.Tag = "available";
                    }

                    seat.Click += Seat_Click;
                    this.Controls.Add(seat);
                }
            }

            // Confirm button
            Button confirmButton = new Button
            {
                Text = "Confirm Selection",
                AutoSize = true,
                Location = new Point(20, 20 + Rows * (SeatHeight + Padding) + 10)
            };

            confirmButton.Click += ConfirmButton_Click;
            this.Controls.Add(confirmButton);
        }






        private void Seat_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox seat)
            {
                //  string status = seat.Tag.ToString();
                string seatCode = seat.Name.Replace("seat_", "");
                string status = seat.Tag.ToString();


                if (status == "available")
                {
                    seat.Image = Properties.Resources.provisional; // Yeşil koltuk
                    seat.Tag = "provisional";
                    SelectedSeats.Add(seatCode);
                }
                else if (status == "provisional")
                {
                    seat.Image = Properties.Resources.available; // Griye geri dön
                    seat.Tag = "available";
                    SelectedSeats.Remove(seatCode);
                }
               
            }
        }


        /*
                private void ConfirmButton_Click(object sender, EventArgs e)
                {
                    string connection = @"Data Source=LAPTOP-PM5A38PG\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;";


                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();

                        foreach (Control ctrl in this.Controls)
                        {
                            if (ctrl is PictureBox seat && seat.Name.StartsWith("seat_"))
                            {
                                string seatCode = seat.Name.Replace("seat_", ""); // Örn: A1, B3
                                string status = seat.Tag?.ToString();             // available, provisional, booked

                                // Sadece provisional koltukları veritabanına booked olarak ekleyelim
                                if (status == "provisional")
                                {

                                //    string insertQuery = "INSERT INTO Seats (SeatCode, Status) VALUES (@SeatCode, @Status)";
                                    string insertQuery = "INSERT INTO Seats (SeatCode, Status, SalonId) VALUES (@SeatCode, @Status, @SalonId)";


                                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@SeatCode", seatCode);
                                        cmd.Parameters.AddWithValue("@Status", "booked"); // booked olarak kaydediyoruz
                                        cmd.Parameters.AddWithValue("@SalonId", salonID);

                                        cmd.ExecuteNonQuery();
                                    }


                                    seat.Image = Properties.Resources.bookedd;
                                    seat.Tag = "booked";
                                }
                            }
                        }

                        MessageBox.Show("Koltuklar başarıyla rezerve edildi ve veritabanına kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } */

        //eski doğru hali
        /*
       private void ConfirmButton_Click(object sender, EventArgs e)
       {
           string connection = @"Data Source=DESKTOP-QKMG9KF\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;";

           using (SqlConnection conn = new SqlConnection(connection))
           {
               conn.Open();

               foreach (Control ctrl in this.Controls)
               {
                   if (ctrl is PictureBox seat && seat.Name.StartsWith("seat_"))
                   {
                       string seatCode = seat.Name.Replace("seat_", ""); // Örn: A1, B3
                       string status = seat.Tag?.ToString();             // available, provisional, booked

                       if (status == "provisional")
                       {
                           // 1. Bu koltuk bu salonda zaten booked mu?
                           string checkQuery = "SELECT COUNT(*) FROM Seats WHERE SeatCode = @SeatCode AND SalonId = @SalonId AND Status = 'booked'";

                           using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                           {
                               checkCmd.Parameters.AddWithValue("@SeatCode", seatCode);
                               checkCmd.Parameters.AddWithValue("@SalonId", salonID);

                               int existingCount = (int)checkCmd.ExecuteScalar();

                               if (existingCount > 0)
                               {
                                   // Koltuk zaten rezerve edilmiş
                                   MessageBox.Show($"Koltuk {seatCode} bu salonda zaten rezerve edilmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                   continue;
                               }
                           }

                           // 2. Koltuk boşsa insert et
                           string insertQuery = "INSERT INTO Seats (SeatCode, Status, SalonId) VALUES (@SeatCode, @Status, @SalonId)";
                           using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                           {
                               cmd.Parameters.AddWithValue("@SeatCode", seatCode);
                               cmd.Parameters.AddWithValue("@Status", "booked");
                               cmd.Parameters.AddWithValue("@SalonId", salonID);
                               cmd.ExecuteNonQuery();
                           }

                           // Arayüzü güncelle
                           seat.Image = Properties.Resources.bookedd;
                           seat.Tag = "booked";
                       }
                   }
               }
               label13.Text = $"Selected Seat Number: {SelectedSeats.Count}";


               MessageBox.Show("Koltuklar başarıyla rezerve edildi ve veritabanına kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.DialogResult = DialogResult.OK;
               this.Close();

           }
       }
        */



        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=DESKTOP-QKMG9KF\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is PictureBox seat && seat.Name.StartsWith("seat_"))
                    {
                        string seatCode = seat.Name.Replace("seat_", ""); // Örn: A6
                        string status = seat.Tag?.ToString();

                        if (status == "provisional")
                        {
                            // SeatID'yi Seats tablosundan al
                            string getSeatIdQuery = "SELECT Id FROM Seats WHERE SeatCode = @SeatCode AND SalonId = @SalonId";
                            int seatId = -1;

                            using (SqlCommand getSeatCmd = new SqlCommand(getSeatIdQuery, conn))
                            {
                                getSeatCmd.Parameters.AddWithValue("@SeatCode", seatCode);
                                getSeatCmd.Parameters.AddWithValue("@SalonId", salonID);

                                object result = getSeatCmd.ExecuteScalar();
                                if (result != null)
                                {
                                    seatId = Convert.ToInt32(result);
                                }
                                else
                                {
                                    MessageBox.Show($"Koltuk {seatCode} bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    continue;
                                }
                            }

                            // SeatStatus tablosunda kayıt var mı kontrol et
                            string checkExistQuery = @"
                        SELECT COUNT(*) FROM SeatStatus
                        WHERE SeansID = @SeansID AND SeatID = @SeatID";

                            using (SqlCommand checkCmd = new SqlCommand(checkExistQuery, conn))
                            {
                                checkCmd.Parameters.AddWithValue("@SeansID", seansID);
                                checkCmd.Parameters.AddWithValue("@SeatID", seatId);

                                int exists = (int)checkCmd.ExecuteScalar();

                                if (exists > 0)
                                {
                                    // Varsa güncelle
                                    string updateStatusQuery = @"
                                UPDATE SeatStatus
                                SET Status = 'Dolu'
                                WHERE SeansID = @SeansID AND SeatID = @SeatID";

                                    using (SqlCommand updateCmd = new SqlCommand(updateStatusQuery, conn))
                                    {
                                        updateCmd.Parameters.AddWithValue("@SeansID", seansID);
                                        updateCmd.Parameters.AddWithValue("@SeatID", seatId);
                                        updateCmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    // Yoksa ekle
                                    string insertQuery = @"
                                INSERT INTO SeatStatus (SeansID, SeatID, Status)
                                VALUES (@SeansID, @SeatID, 'Dolu')";

                                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                                    {
                                        insertCmd.Parameters.AddWithValue("@SeansID", seansID);
                                        insertCmd.Parameters.AddWithValue("@SeatID", seatId);
                                        insertCmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            // Arayüzü güncelle
                            seat.Image = Properties.Resources.bookedd;
                            seat.Tag = "booked";
                        }
                    }
                }

                label13.Text = $"Selected Seat Number: {SelectedSeats.Count}";
                MessageBox.Show("Koltuk(lar) başarıyla rezerve edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }





        private void label11_Click(object sender, EventArgs e)
        {

        }
       

    }
}
