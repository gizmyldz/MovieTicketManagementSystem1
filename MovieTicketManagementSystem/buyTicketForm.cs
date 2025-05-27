using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieTicketManagementSystem
{
    public partial class buyTicketForm : UserControl
    {
        string conn = @"Data Source=DESKTOP-QKMG9KF\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True";
        private int selectedSalonId = 0;
        private List<string> selectedSeatCodes = new List<string>();
       



        public buyTicketForm()
        {
            InitializeComponent();

            displayAvailableMovies();

        }
        private void buyTicketForm_Load(object sender, EventArgs e)
        {
           
           
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAvailableMovies();

        }



        public void displayAvailableMovies()
        {
            movieData mData = new movieData();
            List<movieData> listData = mData.movieAvailableListData();

            dataGridView1.DataSource = listData;
        }

        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                buyTicket_movieID.Text = row.Cells[1].Value.ToString();
                buyTicket_movieName.Text = row.Cells[2].Value.ToString();
                buyTicket_genre.Text = row.Cells[3].Value.ToString();
                buyTicket_regularPrice.Text = row.Cells[4].Value.ToString();


                pictureBox1.ImageLocation = row.Cells[7].Value.ToString();
                movie_id = row.Cells[1].Value.ToString().Trim();


                int parsedMovieID;
                if (int.TryParse(movie_id, out parsedMovieID))
                {
                    loadSeanslarForSelectedMovie(parsedMovieID); // ✅ Seans saatlerini yükle
                }
            }
        }

        string movie_id;
  /*      private void buyTicket_selectMovie_Click(object sender, EventArgs e)
        {
            movie_id = buyTicket_movieID.Text.Trim();

            displayAvailableSeats();
        }

  /*      public void displayAvailableSeats()
        {
            string conn = @"Data Source=LAPTOP-PM5A38PG\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True";
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectAvailableSeat = $"SELECT capacity FROM movie WHERE delete_date IS NULL AND status != 'Deleted' AND movie_id = '" + movie_id + "'";
                int setAvailable = 0;
                /*
                                using (SqlCommand cmdSelectSeat = new SqlCommand(selectAvailableSeat, connect))
                                {
                                    SqlDataReader reader = cmdSelectSeat.ExecuteReader();

                                    if (reader.Read())
                                    {
                                        setAvailable = (int)reader["capacity"];
                                    }
                                    reader.Close();
                                }

                */
   /*             using (SqlCommand cmdSelectSeat = new SqlCommand(selectAvailableSeat, connect))
                {
                    SqlDataReader reader = cmdSelectSeat.ExecuteReader();

                    if (reader.Read())
                    {
                        // capacity sütunu nvarchar olduğu için önce string olarak al, sonra int'e çevir
                        string capacityStr = reader["capacity"].ToString();

                        if (int.TryParse(capacityStr, out int capacity))
                        {
                            setAvailable = capacity;
                        }
                        else
                        {
                            setAvailable = 0; // Dönüştürülemezse varsayılan değer
                            MessageBox.Show("Capacity değeri geçersiz formatta.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    reader.Close();
                }
                if (setAvailable > 0)
                {
                    string selectBookSeats = "SELECT seat_number FROM buy_tickets WHERE movie_id = @movie_id";

                    List<int> bookSeat = new List<int>();

                    using(SqlCommand cmd = new SqlCommand(selectBookSeats, connect))
                    {
                        cmd.Parameters.AddWithValue("@movie_id", movie_id);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            bookSeat.Add((int)reader["seat_number"]);
                        }
                        reader.Close();

                        List<int> allSeats = Enumerable.Range(1, setAvailable).ToList();

                        List<int> availableSeats = allSeats.Except(bookSeat).ToList();

                        DataTable table = new DataTable();
                        table.Columns.Add("seat_number", typeof(int));
                        foreach(int seat in availableSeats)
                        {
                            table.Rows.Add(seat);
                        }

                        if(table.Rows.Count > 0)
                        {
                            buyTicket_availableChairs.DataSource = table;
                            buyTicket_availableChairs.DisplayMember = "seat_number";
                            buyTicket_availableChairs.ValueMember = "seat_number";
                        }
                        else
                        {
                            buyTicket_availableChairs.DataSource = null;
                        }
                    }
                }
                else
                {
                    buyTicket_availableChairs.DataSource = null;
                }

            }
        }*/

        double getTotal = 0;
        private void buyTicket_calculateBtn_Click(object sender, EventArgs e)

        {
            MessageBox.Show("Koltuk sayısı: " + selectedSeatCodes?.Count.ToString());
            MessageBox.Show("movie_id: [" + movie_id + "]");


            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectPrice = "SELECT movie_id, price FROM movie WHERE movie_id = '" + movie_id + "'";

                double getPrice = 0;
                using(SqlCommand cmd = new SqlCommand(selectPrice, connect))
                {
                    
                      SqlDataReader reader = cmd.ExecuteReader();
                    cmd.Parameters.AddWithValue("@movie_id", id);

                    if (reader.Read())
                    {
                        getPrice = Convert.ToDouble((reader["price"].Equals(null)) ? 0 : reader["price"]);
                    }

                    reader.Close(); 
                  

                } 
                int koltukAdedi = 0;
                if (int.TryParse(labelSeatNmbr.Text, out koltukAdedi))
                {
                    // kullanmaya devam edebilirsin
                }




                double getFoodPrice = (buyTicket_foods.SelectedIndex == -1) ? 0 : 100;
                double getDrinkPrice = (buyTicket_drinks.SelectedIndex == -1) ? 0 : 50;

               //    int seatCount = selectedSeatCodes.Count;
                int seatCount = selectedSeatCodes?.Count ?? 0;





                MessageBox.Show($"Fiyat: {getPrice}, Koltuk: {selectedSeatCodes.Count}");


                getTotal = (getPrice * seatCount) + getFoodPrice + getDrinkPrice;

           //     getTotal = (getPrice + getFoodPrice + getDrinkPrice);

                buyTicket_totalPrice.Text = "$" + getTotal.ToString("0.00");
            }
        }

        public void clearSelected()
        {
            id = 0;
            buyTicket_movieID.Text = "";
            buyTicket_movieName.Text = "";
            buyTicket_genre.Text = "";
            buyTicket_regularPrice.Text = "";

            pictureBox1.Image = null;
        }

        private void buyTicket_clear_Click(object sender, EventArgs e)
        {
            clearSelected();
        }

        /*  private void buyTicket_amount_TextChanged(object sender, EventArgs e)
          {

          }
        */

        private void buyTicket_amount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(buyTicket_amount.Text))
            {
                buyTicket_change.Text = "$0.00";
                return;
            }

            try
            {
                // Total Price içindeki "$" işaretini ve "," varsa onu "." yap
                string cleanTotal = buyTicket_totalPrice.Text.Replace("$", "").Replace(",", ".").Trim();

                if (!double.TryParse(cleanTotal, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double parsedTotal))
                {
                    buyTicket_change.Text = "$0.00";
                    return;
                }

                getTotal = parsedTotal;

                // Kullanıcının girdiği tutarı da düzgün parse et
                string enteredAmountStr = buyTicket_amount.Text.Replace(",", ".").Trim();
                if (!double.TryParse(enteredAmountStr, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double enteredAmount))
                {
                    buyTicket_change.Text = "$0.00";
                    return;
                }

                getAmount = enteredAmount;

                if (enteredAmount >= getTotal)
                {
                    getChange = enteredAmount - getTotal;
                }
                else
                {
                    getChange = 0;
                }

                buyTicket_change.Text = "$" + getChange.ToString("0.00");
            }
            catch
            {
                buyTicket_change.Text = "$0.00";
            }
        }


        private void buyTicket_amount_Enter(object sender, EventArgs e)
        {
            
        }

        private void buyTicket_amount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        double getChange = 0;
        double getAmount = 0;

        private void buyTicket_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (id == 0 && getTotal == 0)
                {
                    MessageBox.Show("Please select movie and foods first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (Convert.ToDouble(buyTicket_amount.Text) >= getTotal)
                        {
                            getChange = Convert.ToDouble(buyTicket_amount.Text) - getTotal;
                            getAmount = Convert.ToDouble(buyTicket_amount.Text);
                        }
                        else
                        {
                            MessageBox.Show("Error :3 should amount > total", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            getChange = 0;
                        }

                        buyTicket_change.Text = "$" + getChange.ToString("0.00");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please enter numbers only", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buyTicket_amount.Text = "";
                        getAmount = 0;
                    }
                }
            }
        }

        private void buyTicket_buyBtn_Click(object sender, EventArgs e)
        {
            if(movie_id == null || getTotal == 0)
            {
                MessageBox.Show("Please select movie first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string insertData = "INSERT INTO buy_tickets (movie_id, price, amount, change, status, created_at, salon_id) " +
                        "VALUES(@movieID, @price, @amount, @change, @status, @date , @salonId)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@movieID", id);
                 //       cmd.Parameters.AddWithValue("@seatNum", buyTicket_availableChairs.Text);
                        cmd.Parameters.AddWithValue("@price", getTotal);
                        cmd.Parameters.AddWithValue("@amount", getAmount);
                        cmd.Parameters.AddWithValue("@change", getChange);
                        cmd.Parameters.AddWithValue("@status", "PAID");
                        cmd.Parameters.AddWithValue("@salonId", selectedSalonId);

                        DateTime today = DateTime.Now;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();

                        //       MessageBox.Show($"Successful! occupied: {buyTicket_availableChairs.Text}"
                        //          , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //clearSelected();
                        //clearFields();





                        string filmAdi = buyTicket_movieName.Text;
                        string tarih = DateTime.Now.ToString("dd.MM.yyyy");
                        string salon = "Salon " + selectedSalonId.ToString(); // veya veritabanından salon adını çekebilirsin
                        string seans = buyTicket_seansComboBox.Text;
                        List<string> koltuklar = selectedSeatCodes;
                        Image filmResmi = pictureBox1.Image;

                        TicketDetailForm detailForm = new TicketDetailForm(filmAdi, tarih, salon, seans, koltuklar, filmResmi);
                        detailForm.ShowDialog();



                    }
                }
            }
        }

        public void clearFields()
        {
      //      buyTicket_availableChairs.SelectedIndex = -1;
            buyTicket_foods.SelectedIndex = -1;
            buyTicket_drinks.SelectedIndex = -1;
            buyTicket_totalPrice.Text = "$0.00";
            buyTicket_amount.Text = "";
            buyTicket_change.Text = "$0.00";
        }
        private void buyTicket_clearFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }



        private void buyTicket_receiptBtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private int rowIndex = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = 0;
            int count = 0;
            int colWidth = 100;
            int headerMargin = 10;
            int tableMargin = 10;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat aligncenter = new StringFormat();
            aligncenter.Alignment = StringAlignment.Center;
            aligncenter.LineAlignment = StringAlignment.Center;

            string headerText = " Cinema";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left 
                + (dataGridView1.Columns.Count / 6) * colWidth, y, aligncenter);

            count++;

            y += tableMargin;

            string[] header = {"ID","MovieID", "MovieName"};

            for(int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, aligncenter);
            }

            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while(rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                for(int q = 0; q < dataGridView1.Columns.Count-6; q++)
                {
                    object cellValue = row.Cells[q].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, aligncenter);
                }
                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                int labelMargin = (int)Math.Min(rSpace, 100);

                DateTime today = DateTime.Now;

                float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("--------------------------", labelFont).Width;

                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString("Total Price: \t$" + getTotal.ToString("0.00") + "\nAmount: \t$" + buyTicket_amount.Text
                    + "\n\t\t--------\nChange:\t" + buyTicket_change.Text, labelFont, Brushes.Black, labelX, y);

                labelMargin = (int)Math.Min(rSpace, -40);

                string labelText = today.ToString();

                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(labelText, labelFont, Brushes.Black
                    , e.MarginBounds.Right - e.Graphics.MeasureString("--------------------------", labelFont).Width, y);
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }

        /*   private void buttonSeat_Click(object sender, EventArgs e)
           {/*
               Seat window = new Seat();
               window.Show(); */

        /*     if (dataGridView1.CurrentRow != null)
              {
                  selectedSalonId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SalonID"].Value);
                  Seat window = new Seat(selectedSalonId);
                  window.Show();
              }
              else
              {
                  MessageBox.Show("Lütfen bir film seçin.");
              }
          } */
        /*      private void buttonSeat_Click(object sender, EventArgs e)
               {
                   if (dataGridView1.CurrentRow != null)
                   {
                       selectedSalonId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SalonID"].Value);

                       //  Seat seatForm = new Seat(selectedSalonId);
                       //  seatForm.Show();
                       Seat seatForm = new Seat(selectedSalonId);
                       var result = seatForm.ShowDialog(); // MODAL AÇ

                       // ✅ Seçilen koltuklar geldiyse göster ve listeye ata
                       if (seatForm.SelectedSeats.Any())
                       {
                           selectedSeatCodes = seatForm.SelectedSeats;
                           //     labelSeatNmbr.Text = $"Seçilen Koltuk: {selectedSeatCodes.Count}";
                           labelSeatNmbr.Text = $" {selectedSeatCodes.Count}";
                       }
                   }
                   else
                   {
                       MessageBox.Show("Lütfen bir film seçin.");
                   }
               }  
        */
        /*
         private void buttonSeat_Click(object sender, EventArgs e)
         {
             if (dataGridView1.CurrentRow != null)
             {
                 selectedSalonId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SalonID"].Value);

                 Seat seatForm = new Seat(selectedSalonId);
                 var result = seatForm.ShowDialog(); // MODAL AÇ

                 // ✅ Sadece kullanıcı Confirm ederse ve koltuk seçimi varsa
                 if (result == DialogResult.OK && seatForm.SelectedSeats.Any())
                 {
                     selectedSeatCodes = seatForm.SelectedSeats;

                     // ✅ label'a sayıyı yaz (sadece sayı, yazı değil)
                     labelSeatNmbr.Text = selectedSeatCodes.Count.ToString();
                 }
             }
             else
             {
                 MessageBox.Show("Lütfen bir film seçin.");
             }
         }*/



        private void buttonSeat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                selectedSalonId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SalonID"].Value);

                // ✅ Seçilen seansı al
                if (buyTicket_seansComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir seans seçin.");
                    return;
                }

                int selectedSeansId = Convert.ToInt32(buyTicket_seansComboBox.SelectedValue);

                // ✅ Seat formuna hem salon hem seans bilgisini gönder
                Seat seatForm = new Seat(selectedSalonId, selectedSeansId);
                var result = seatForm.ShowDialog();

                if (result == DialogResult.OK && seatForm.SelectedSeats.Any())
                {
                    selectedSeatCodes = seatForm.SelectedSeats;
                    labelSeatNmbr.Text = selectedSeatCodes.Count.ToString();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir film seçin.");
            }
        }



        void loadSeanslarForSelectedMovie(int movieID)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string query = "SELECT SeansID, SeansSaati FROM Seanslar WHERE MovieID = @movieID";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@movieID", movieID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                buyTicket_seansComboBox.DisplayMember = "SeansSaati";
                buyTicket_seansComboBox.ValueMember = "SeansID";
                buyTicket_seansComboBox.DataSource = dt;

            }

           
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
       

    }
}
