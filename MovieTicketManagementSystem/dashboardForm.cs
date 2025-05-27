using System;
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
    public partial class dashboardForm : UserControl
    {
        
        string conn = @"Data Source=DESKTOP-QKMG9KF\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True";

        public dashboardForm()
        {
            InitializeComponent();

            displayAvailableMovies();
            displayTotalStaffs();
            displayTotalBuys();
            displayTotalIncome();

            displayAMTable();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAvailableMovies();
            displayTotalStaffs();
            displayTotalBuys();
            displayTotalIncome();
            displayAMTable();
        }

        public void displayAMTable()
        {
            movieData mData = new movieData();

            List<movieData> listData = mData.movieAvailableListData();

            dataGridView1.DataSource = listData;
        }

        public void displayAvailableMovies()
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) as avMovie FROM movie WHERE status = 'Available'";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if(reader["avMovie"] != DBNull.Value)
                        {
                            decimal totalAVMovie = Convert.ToDecimal(reader["avMovie"]);

                            dashboard_AM.Text = totalAVMovie.ToString();
                        }
                    }
                }
            }
        }

        public void displayTotalStaffs()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) as totalStaff FROM users WHERE role = 'Staff' AND status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalStaff"] != DBNull.Value)
                        {
                            decimal totalStaff = Convert.ToDecimal(reader["totalStaff"]);

                            dashboard_TS.Text = totalStaff.ToString();
                        }
                    }
                }
            }
        }

        public void displayTotalBuys()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) as totalBuys FROM buy_tickets WHERE status = 'PAID'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalBuys"] != DBNull.Value)
                        {
                            decimal totalBuys = Convert.ToDecimal(reader["totalBuys"]);

                            dashboard_TB.Text = totalBuys.ToString();
                        }
                    }
                }
            }
        }

        public void displayTotalIncome()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                
                string selectData = "SELECT SUM(price) as totalIncome FROM buy_tickets WHERE status = 'PAID'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalIncome"] != DBNull.Value)
                        {
                            decimal totalIncome = Convert.ToDecimal(reader["totalIncome"]);

                            dashboard_TI.Text = "$" + totalIncome.ToString("0.00");
                        }
                    }
                }
            }
        }
    }
}
