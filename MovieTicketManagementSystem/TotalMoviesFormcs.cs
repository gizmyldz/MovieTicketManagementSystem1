using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MovieTicketManagementSystem
{
    public partial class TotalMoviesFormcs : Form
    {
        public TotalMoviesFormcs()
        {
            InitializeComponent();
            Load += TotalMoviesForm_Load;
        }

        private void TotalMoviesFormcs_Load(object sender, EventArgs e)
        {
            // Designer tarafından eklenen stub
        }

        private void TotalMoviesForm_Load(object sender, EventArgs e)
        {
            // 1) DataGrid doldurma
            using (var conn = new sqlconName().connection())
            {
                var dt = new DataTable();
                string sqlMovies = @"
                    SELECT 
                        m.id            AS ID,
                        m.movie_id      AS MovieID,
                        m.movie_name    AS MovieName,
                        m.genre         AS Genre,
                        m.price         AS Price,
                        m.capacity      AS Capacity,
                        m.status        AS Status,
                        ISNULL(bt.TotalSeatsSold, 0) AS TotalSeatsSold,
                        ISNULL(bt.TotalRevenue,   0) AS TotalRevenue
                    FROM dbo.movie m
                    LEFT JOIN (
                        SELECT 
                            movie_id,
                            COUNT(*)       AS TotalSeatsSold,
                            SUM(price)     AS TotalRevenue
                        FROM dbo.buy_tickets
                        WHERE status = 'PAID'
                        GROUP BY movie_id
                    ) bt ON m.movie_id = bt.movie_id
                    WHERE m.status = 'Available'
                    ORDER BY m.movie_id;
                ";
                using (var da = new SqlDataAdapter(sqlMovies, conn))
                    da.Fill(dt);

                dataGridViewTotals.DataSource = dt;
            }

            // 2) Çubuk Grafik – film başına satılan bilet sayısı
            chartBar.Series.Clear();
            var seriesBar = chartBar.Series.Add("SeatsSold");
            seriesBar.ChartType = SeriesChartType.Column;
            seriesBar.IsValueShownAsLabel = true;

            var dtMovies = (DataTable)dataGridViewTotals.DataSource;
            foreach (DataRow r in dtMovies.Rows)
            {
                string name = r["MovieName"].ToString();
                int sold = Convert.ToInt32(r["TotalSeatsSold"]);
                seriesBar.Points.AddXY(name, sold);
            }

            chartBar.ChartAreas[0].AxisX.Interval = 1;
            chartBar.ChartAreas[0].AxisX.Title = "Movie";
            chartBar.ChartAreas[0].AxisY.Title = "Tickets Sold";

            // 3) Pasta Grafik – salonlara göre satış adedi dağılımı
            var dtHall = new DataTable();
            using (var conn = new sqlconName().connection())
            {
                string sqlHall = @"
                    SELECT 
                        s.SalonID,
                        s.SalonAdi,
                        SUM(CASE WHEN bt.status = 'PAID' THEN 1 ELSE 0 END) AS TotalSold
                    FROM dbo.Salons s
                    INNER JOIN dbo.movie m
                      ON s.SalonID = m.salon_id
                      AND m.status = 'Available'
                    LEFT JOIN dbo.buy_tickets bt
                      ON m.movie_id = bt.movie_id
                      AND bt.status = 'PAID'
                    GROUP BY s.SalonID, s.SalonAdi
                    HAVING SUM(CASE WHEN bt.status = 'PAID' THEN 1 ELSE 0 END) > 0;
                ";
                using (var daHall = new SqlDataAdapter(sqlHall, conn))
                    daHall.Fill(dtHall);
            }

            chartPie.Series.Clear();
            chartPie.Legends.Clear();
            chartPie.Titles.Clear();

            var legend = chartPie.Legends.Add("Legend");
            legend.Docking = Docking.Right;

            var seriesPie = chartPie.Series.Add("SalesShare");
            seriesPie.ChartType = SeriesChartType.Pie;
            seriesPie.Label = "#PERCENT{P0}";
            seriesPie.LegendText = "#AXISLABEL (#VALY)";

            foreach (DataRow r in dtHall.Rows)
            {
                int sold = Convert.ToInt32(r["TotalSold"]);
                if (sold <= 0)
                    continue;

                int idx = seriesPie.Points.AddY(sold);
                seriesPie.Points[idx].AxisLabel = r["SalonAdi"].ToString();
            }
        }

        // Designer tarafından eklenen boş event handler’lar
        private void dataGridViewTotals_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e) { }
        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e) { }
        private void chartBar_Click(object sender, EventArgs e) { }
        private void chartPie_Click(object sender, EventArgs e) { }
    }
}
