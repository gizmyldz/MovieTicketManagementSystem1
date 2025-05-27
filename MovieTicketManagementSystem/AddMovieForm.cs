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
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;

namespace MovieTicketManagementSystem
{
    public partial class AddMovieForm : UserControl
    {
        string conn = @"Data Source=DESKTOP-QKMG9KF\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;";
       
        private List<TimeSpan> seansSaatleri = new List<TimeSpan>();

        public AddMovieForm()
        {
            InitializeComponent();

            displayData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayData();

        }

        public void displayData()
        {
            movieData mData = new movieData();

            List<movieData> listData = mData.movieListData();

            dataGridView1.DataSource = listData;

            if (dataGridView1.Columns.Contains("SalonAdi"))
            {
                dataGridView1.Columns["SalonAdi"].HeaderText = "Hall";
            }

        }

        private void addMovie_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                string imagePath = "";

                file.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if(file.ShowDialog() == DialogResult.OK)
                {
                    imagePath = file.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
        private void addMovie_addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string checkID = "SELECT movie_id FROM movie WHERE movie_id = @movieID";

                    using(SqlCommand cID = new SqlCommand(checkID, connect))
                    {
                        cID.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cID);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            MessageBox.Show($"Movie ID: " + addMovie_movieID.Text.Trim() + " is taken already.", "Error Message"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            string checkHall = "SELECT COUNT(*) FROM movie WHERE salon_id = @salonID AND status != 'Deleted'";
                            using (SqlCommand checkCmd = new SqlCommand(checkHall, connect))
                            {
                                checkCmd.Parameters.AddWithValue("@salonID", comboBoxSalon.SelectedValue);
                                int count = (int)checkCmd.ExecuteScalar();

                                if (count > 0)
                                {
                                    MessageBox.Show("This hall is already assigned to another movie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                            string insertData = "INSERT INTO movie (movie_id, movie_name, genre, price, capacity, movie_image, status, created_at,salon_id) " +
                                "VALUES(@movieID, @movieName, @genre, @price, @capacity, @movieImage, @status, @date, @salonID)";

                            //  string path = Path.Combine(@"C:\Users\USER\source\repos\MovieTicketManagementSystem\MovieTicketManagementSystem\Movie_Directory\" 
                            //      + addMovie_movieID.Text.Trim() + ".jpg");

                            //  string directoryPath = Path.GetDirectoryName(path);

                            string directoryPath = Path.Combine(
                                                   Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                                    "Movie_Directory");

                            string path = Path.Combine(directoryPath, addMovie_movieID.Text.Trim() + ".jpg");



                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(pictureBox1.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                                cmd.Parameters.AddWithValue("@movieName", addMovie_movieName.Text.Trim());
                                cmd.Parameters.AddWithValue("@genre", addMovie_genre.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@price", addMovie_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@capacity", addMovie_capacity.Text.Trim());
                                cmd.Parameters.AddWithValue("@movieImage", path);
                                cmd.Parameters.AddWithValue("@status", addMovie_status.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@salonID", comboBoxSalon.SelectedValue);

                            


                                SqlCommand updateHall = new SqlCommand("UPDATE Salons SET Status = 'Unavailable' WHERE SalonID = @id", connect);
                                updateHall.Parameters.AddWithValue("@id", comboBoxSalon.SelectedValue);
                                //      updateHall.ExecuteNonQuery();
                                int affected = updateHall.ExecuteNonQuery();
                                MessageBox.Show("Salon güncellenen satır sayısı: " + affected);


                                DateTime today = DateTime.Now;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                displayData();
                                clearFields();
                                LoadAvailableHalls();


                                MessageBox.Show("Added successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } */

        private void addMovie_addBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxSalon.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir salon seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (seansSaatleri.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir seans saati ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    MessageBox.Show("1 - Bağlantı açıldı.");

                    // 1. Movie ID zaten var mı kontrolü
                    string checkID = "SELECT movie_id FROM movie WHERE movie_id = @movieID";
                    using (SqlCommand cID = new SqlCommand(checkID, connect))
                    {
                        cID.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cID);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("2 - Movie ID zaten var.");
                            return;
                        }
                    }

                    // 2. Aynı salonda başka film var mı kontrolü
                    string checkHall = "SELECT COUNT(*) FROM movie WHERE salon_id = @salonID AND status != 'Deleted'";
                    using (SqlCommand checkCmd = new SqlCommand(checkHall, connect))
                    {
                        checkCmd.Parameters.AddWithValue("@salonID", comboBoxSalon.SelectedValue);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("3 - Bu salonda başka film var.");
                            return;
                        }
                    }

                    MessageBox.Show("4 - Film eklenebilir, salonda film yok.");

                    // 3. Resim kopyalama
                    string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Movie_Directory");
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    string imagePath = Path.Combine(directoryPath, addMovie_movieID.Text.Trim() + ".jpg");
                    File.Copy(pictureBox1.ImageLocation, imagePath, true);

                    // 4. Film ekleme ve ID alma (OUTPUT INSERTED.id)
                    string insertData = "INSERT INTO movie (movie_id, movie_name, genre, price, capacity, movie_image, status, created_at, salon_id) " +
                                        "OUTPUT INSERTED.id " +
                                        "VALUES(@movieID, @movieName, @genre, @price, @capacity, @movieImage, @status, @date, @salonID)";

                    int movieId = 0;

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                        cmd.Parameters.AddWithValue("@movieName", addMovie_movieName.Text.Trim());
                        cmd.Parameters.AddWithValue("@genre", addMovie_genre.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@price", addMovie_price.Text.Trim());
                        cmd.Parameters.AddWithValue("@capacity", addMovie_capacity.Text.Trim());
                        cmd.Parameters.AddWithValue("@movieImage", imagePath);
                        cmd.Parameters.AddWithValue("@status", addMovie_status.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@salonID", comboBoxSalon.SelectedValue);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            movieId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Movie ID alınamadı.");
                            return;
                        }
                    }

                    // 5. SalonID güvenli şekilde alınır
                    int salonID;
                    if (comboBoxSalon.SelectedValue == null || !int.TryParse(comboBoxSalon.SelectedValue.ToString(), out salonID))
                    {
                        MessageBox.Show("Salon bilgisi geçersiz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 6. Seans saatlerini Seanslar tablosuna ekle
                    foreach (var saat in seansSaatleri)
                    {
                        if (saat == null) continue;

                        try
                        {
                            string insertSeans = "INSERT INTO Seanslar (MovieID, SalonID, SeansSaati) VALUES (@movieID, @salonID, @seansSaati)";
                            using (SqlCommand seansCmd = new SqlCommand(insertSeans, connect))
                            {
                                seansCmd.Parameters.AddWithValue("@movieID", movieId);
                                seansCmd.Parameters.AddWithValue("@salonID", salonID);
                                seansCmd.Parameters.AddWithValue("@seansSaati", saat);
                                seansCmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Seans eklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    MessageBox.Show("5 - Film ve seanslar başarıyla eklendi.");

                    // 7. Salon durumu güncelle
                    SqlCommand updateHall = new SqlCommand("UPDATE Salons SET Status = 'Unavailable' WHERE SalonID = @id", connect);
                    updateHall.Parameters.AddWithValue("@id", salonID);
                    int affected = updateHall.ExecuteNonQuery();
                    MessageBox.Show("6 - Salon durumu güncellendi, etkilenen satır sayısı: " + affected);

                    // 8. UI güncelle
                    displayData();
                    clearFields();
                    LoadAvailableHalls();

                    MessageBox.Show("7 - İşlem tamamlandı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void clearFields()
        {
            addMovie_movieID.Text = "";
            addMovie_movieName.Text = "";
            addMovie_genre.SelectedIndex = -1;
            addMovie_price.Text = "";
            addMovie_capacity.Text = "";
            pictureBox1.Image = null;
            addMovie_status.SelectedIndex = -1;
            comboBoxSalon.SelectedIndex = -1;
        }

        private void addMovie_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                addMovie_movieID.Text = row.Cells[1].Value.ToString();
                addMovie_movieName.Text = row.Cells[2].Value.ToString();
                addMovie_genre.Text = row.Cells[3].Value.ToString();
                addMovie_price.Text = row.Cells[4].Value.ToString();
                addMovie_capacity.Text = row.Cells[5].Value.ToString();
                addMovie_status.Text = row.Cells[6].Value.ToString();

                pictureBox1.ImageLocation = row.Cells[7].Value.ToString();
     //           comboBoxSalon.SelectedValue = row.Cells[8].Value // 8 → salon_id sütunuysa


            }
        }
        /*
                private void addMovie_updateBtn_Click(object sender, EventArgs e)
                {
                    try
                    {
                        if(MessageBox.Show("Are you sure you want to Update ID:" + addMovie_movieID.Text 
                            + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (SqlConnection connect = new SqlConnection(conn))
                            {
                                connect.Open();

                                string checkID = "SELECT COUNT(id) FROM movie WHERE movie_id = @movieID";

                                using (SqlCommand cID = new SqlCommand(checkID, connect))
                                {
                                    cID.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());

                                    SqlDataAdapter adapter = new SqlDataAdapter(cID);
                                    DataTable table = new DataTable();

                                    adapter.Fill(table);

                                    if (table.Rows.Count >= 2)
                                    {
                                        MessageBox.Show($"Movie ID: " + addMovie_movieID.Text.Trim() + " is taken already.", "Error Message"
                                            , MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                    else
                                    {
                                        string updateData = "UPDATE movie SET movie_id = @movieID, movie_name = @movieName, genre = @genre" +
                                            ", price = @price, capacity = @capacity, status = @status, update_date = @updateDate,  salon_id = @salonID WHERE id = @id";


                                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                        {
                                            cmd.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                                            cmd.Parameters.AddWithValue("@movieName", addMovie_movieName.Text.Trim());
                                            cmd.Parameters.AddWithValue("@genre", addMovie_genre.SelectedItem.ToString());
                                            cmd.Parameters.AddWithValue("@price", addMovie_price.Text.Trim());
                                            cmd.Parameters.AddWithValue("@capacity", addMovie_capacity.Text.Trim());
                                            cmd.Parameters.AddWithValue("@status", addMovie_status.SelectedItem.ToString());
                                            cmd.Parameters.AddWithValue("@salonID", comboBoxSalon.SelectedValue);


                                            DateTime today = DateTime.Today;
                                            cmd.Parameters.AddWithValue("@updateDate", today);
                                            cmd.Parameters.AddWithValue("@id", id);


                                            cmd.ExecuteNonQuery();

                                            displayData();
                                            clearFields();
                                            LoadAvailableHalls();


                                            MessageBox.Show("Updated successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } */

        private void addMovie_updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Update ID: " + addMovie_movieID.Text + "?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string checkID = "SELECT COUNT(id) FROM movie WHERE movie_id = @movieID AND id != @id";

                        using (SqlCommand cID = new SqlCommand(checkID, connect))
                        {
                            cID.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                            cID.Parameters.AddWithValue("@id", id);

                            int existingCount = (int)cID.ExecuteScalar();

                            if (existingCount >= 1)
                            {
                                MessageBox.Show("Movie ID: " + addMovie_movieID.Text.Trim() + " is taken already.",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Yeni salon ID
                        int newSalonID = Convert.ToInt32(comboBoxSalon.SelectedValue);

                        // Eski salon ID'yi al
                        int oldSalonID = 0;
                        string oldSalonQuery = "SELECT salon_id FROM movie WHERE id = @id";
                        using (SqlCommand oldSalonCmd = new SqlCommand(oldSalonQuery, connect))
                        {
                            oldSalonCmd.Parameters.AddWithValue("@id", id);
                            object result = oldSalonCmd.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                oldSalonID = Convert.ToInt32(result);
                            }
                        }

                        // Salon değişmişse eskiyi Available, yeniyi Unavailable yap
                        if (oldSalonID != newSalonID)
                        {
                            string makeOldSalonAvailable = "UPDATE Salons SET Status = 'Available' WHERE SalonID = @oldID";
                            using (SqlCommand cmd1 = new SqlCommand(makeOldSalonAvailable, connect))
                            {
                                cmd1.Parameters.AddWithValue("@oldID", oldSalonID);
                                cmd1.ExecuteNonQuery();
                            }

                            string makeNewSalonUnavailable = "UPDATE Salons SET Status = 'Unavailable' WHERE SalonID = @newID";
                            using (SqlCommand cmd2 = new SqlCommand(makeNewSalonUnavailable, connect))
                            {
                                cmd2.Parameters.AddWithValue("@newID", newSalonID);
                                cmd2.ExecuteNonQuery();
                            }
                        }

                        // Film bilgilerini güncelle
                        string updateData = "UPDATE movie SET movie_id = @movieID, movie_name = @movieName, genre = @genre, " +
                                            "price = @price, capacity = @capacity, status = @status, update_date = @updateDate, " +
                                            "salon_id = @salonID WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                            cmd.Parameters.AddWithValue("@movieName", addMovie_movieName.Text.Trim());
                            cmd.Parameters.AddWithValue("@genre", addMovie_genre.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@price", addMovie_price.Text.Trim());
                            cmd.Parameters.AddWithValue("@capacity", addMovie_capacity.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", addMovie_status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@salonID", newSalonID);
                            cmd.Parameters.AddWithValue("@updateDate", DateTime.Today);
                            cmd.Parameters.AddWithValue("@id", id);

                            cmd.ExecuteNonQuery();


                        }





                        // UI güncelle
                        displayData();
                        clearFields();
                        LoadAvailableHalls();

                        MessageBox.Show("Update successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* delete değiştirmeden önce
                private void addMovie_deleteBtn_Click(object sender, EventArgs e)
                {
                    try
                    {
                        if (MessageBox.Show("Are you sure you want to Delete ID:" + addMovie_movieID.Text
                            + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (SqlConnection connect = new SqlConnection(conn))
                            {
                                connect.Open();

                                string updateData = "UPDATE movie SET delete_date = @deleteDate, status = @status WHERE id = @id";


                                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                {

                                    DateTime today = DateTime.Today;
                                    cmd.Parameters.AddWithValue("@deleteDate", today);
                                    cmd.Parameters.AddWithValue("@status", "Deleted");
                                    cmd.Parameters.AddWithValue("@id", id);


                                    cmd.ExecuteNonQuery();

                                    displayData();
                                    clearFields();

                                    MessageBox.Show("Updated successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }


                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } */
        private void addMovie_deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Delete ID: " + addMovie_movieID.Text
                    + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        // 1. İlişkili salon_id’yi bul
                        int salonID = 0;
                        string getSalonQuery = "SELECT salon_id FROM movie WHERE id = @id";
                        using (SqlCommand getSalon = new SqlCommand(getSalonQuery, connect))
                        {
                            getSalon.Parameters.AddWithValue("@id", id);
                            object result = getSalon.ExecuteScalar();

                            if (result != null && result != DBNull.Value)
                            {
                                salonID = Convert.ToInt32(result);
                            }
                        }

                        // 2. Filmi "Deleted" yap
                        string updateData = "UPDATE movie SET delete_date = @deleteDate, status = @status WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@status", "Deleted");
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }

                        // 3. Salonu tekrar "Available" yap
                        if (salonID != 0)
                        {
                            string updateHall = "UPDATE Salons SET Status = 'Available' WHERE SalonID = @sid";
                            using (SqlCommand hallCmd = new SqlCommand(updateHall, connect))
                            {
                                hallCmd.Parameters.AddWithValue("@sid", salonID);
                                hallCmd.ExecuteNonQuery();
                            }
                        }

                        // 4. UI güncelle
                        displayData();
                        clearFields();
                        LoadAvailableHalls();


                        MessageBox.Show("Movie deleted and hall released.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadAvailableHalls()
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT SalonID, SalonAdi FROM Salons WHERE Status = 'Available'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxSalon.DisplayMember = "SalonAdi";
                comboBoxSalon.ValueMember = "SalonID";
                comboBoxSalon.DataSource = dt;
            }
        }

        private void AddMovieForm_Load(object sender, EventArgs e)
        {
            LoadAvailableHalls();
        }

        private void comboBoxSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSalon.SelectedValue != null)
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();
                        string query = "SELECT Kapasite FROM Salons WHERE SalonID = @salonID";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@salonID", comboBoxSalon.SelectedValue);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            addMovie_capacity.Text = result.ToString(); // kapasiteyi yaz
                        }
                        else
                        {
                            addMovie_capacity.Text = "0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kapasite alınamadı: " + ex.Message);
                }
            }
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            TimeSpan saat = dtpSeansSaati.Value.TimeOfDay;

            if (!seansSaatleri.Contains(saat))
            {
                seansSaatleri.Add(saat);
                MessageBox.Show($"Seans saati {saat:hh\\:mm} başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu saat zaten eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
