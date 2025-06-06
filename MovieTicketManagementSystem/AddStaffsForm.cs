﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MovieTicketManagementSystem
{
    public partial class AddStaffsForm : UserControl
    {
        //string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\movie.mdf;Integrated Security=True;Connect Timeout=30";
        string conn = @"Data Source=DESKTOP-QKMG9KF\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;";

        public AddStaffsForm()
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
            staffData sData = new staffData();

            List<staffData> listData = sData.staffDataListData();
            dataGridView1.DataSource = listData;
        }

        private void addStaff_addBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string selectUsername = "SELECT * FROM users WHERE username = @usern";

                    using(SqlCommand checkUsern = new SqlCommand(selectUsername, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", addStaff_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            MessageBox.Show(addStaff_username.Text.Substring(0, 1).ToUpper()
                                + addStaff_username.Text.Substring(1) + " is Existing Already"
                                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username, password, role, status, date_reg) " +
                                "VALUES(@usern, @pass, @role, @status, @date)";

                            using(SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", addStaff_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", addStaff_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "Staff");
                                cmd.Parameters.AddWithValue("@status", addStaff_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;

                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Added successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                    }
                }
            }
        }

        public bool isEmpty()
        {
            if(addStaff_username.Text == "" || addStaff_password.Text == "" || addStaff_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                addStaff_username.Text = row.Cells[1].Value.ToString();
                addStaff_password.Text = row.Cells[2].Value.ToString();
                addStaff_status.SelectedItem = row.Cells[4].Value.ToString();
            }
        }

        private void addStaff_updateBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(DialogResult.Yes == MessageBox.Show("Are you sure you want to update id: " 
                    + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string selectUsername = "SELECT * FROM users WHERE username = @usern";

                        using (SqlCommand checkUsern = new SqlCommand(selectUsername, connect))
                        {
                            checkUsern.Parameters.AddWithValue("@usern", addStaff_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count >= 2)
                            {
                                MessageBox.Show(addStaff_username.Text.Substring(0, 1).ToUpper()
                                    + addStaff_username.Text.Substring(1) + " is Existing Already"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string updatedata = "UPDATE users SET username = @usern, password = @pass, status = @status WHERE id = @id";

                                using (SqlCommand cmd = new SqlCommand(updatedata, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", addStaff_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", addStaff_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", addStaff_status.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@id", getID);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Updated successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                }
            }
        }

        public void clearFields()
        {
            addStaff_username.Text = "";
            addStaff_password.Text = "";
            addStaff_status.SelectedIndex = -1;
        }

        private void addStaff_deleteBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete id: "
                    + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();
                        
                        string updatedata = "UPDATE users SET status = @status WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updatedata, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Deleted");
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Deleted successful", "Information Message"
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                }
            }
        }

        private void addStaff_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
