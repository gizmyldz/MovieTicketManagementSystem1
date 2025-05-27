
namespace MovieTicketManagementSystem
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hall1 = new MovieTicketManagementSystem.hall();
            this.dashboardForm1 = new MovieTicketManagementSystem.dashboardForm();
            this.addStaffsForm1 = new MovieTicketManagementSystem.AddStaffsForm();
            this.addMovieForm1 = new MovieTicketManagementSystem.AddMovieForm();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonHALL = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.addMovie_btn = new System.Windows.Forms.Button();
            this.addStaff_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(340, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1419, 54);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MovieTicketManagementSystem.Properties.Resources.icons8_User_30px;
            this.pictureBox2.Location = new System.Drawing.Point(1007, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1055, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome, MarcoMan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Ticket Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1384, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboardForm1);
            this.panel3.Controls.Add(this.addStaffsForm1);
            this.panel3.Controls.Add(this.addMovieForm1);
            this.panel3.Controls.Add(this.hall1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(340, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1419, 928);
            this.panel3.TabIndex = 2;
            // 
            // hall1
            // 
            this.hall1.Location = new System.Drawing.Point(0, 0);
            this.hall1.Name = "hall1";
            this.hall1.Size = new System.Drawing.Size(1419, 928);
            this.hall1.TabIndex = 3;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(0, 0);
            this.dashboardForm1.Margin = new System.Windows.Forms.Padding(5);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1419, 817);
            this.dashboardForm1.TabIndex = 2;
            this.dashboardForm1.Load += new System.EventHandler(this.dashboardForm1_Load);
            // 
            // addStaffsForm1
            // 
            this.addStaffsForm1.Location = new System.Drawing.Point(0, 0);
            this.addStaffsForm1.Margin = new System.Windows.Forms.Padding(5);
            this.addStaffsForm1.Name = "addStaffsForm1";
            this.addStaffsForm1.Size = new System.Drawing.Size(1419, 928);
            this.addStaffsForm1.TabIndex = 1;
            this.addStaffsForm1.Load += new System.EventHandler(this.addStaffsForm1_Load);
            // 
            // addMovieForm1
            // 
            this.addMovieForm1.Location = new System.Drawing.Point(0, 0);
            this.addMovieForm1.Margin = new System.Windows.Forms.Padding(5);
            this.addMovieForm1.Name = "addMovieForm1";
            this.addMovieForm1.Size = new System.Drawing.Size(1419, 928);
            this.addMovieForm1.TabIndex = 0;
            this.addMovieForm1.Load += new System.EventHandler(this.addMovieForm1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonHALL);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.addMovie_btn);
            this.panel1.Controls.Add(this.addStaff_btn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 982);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::MovieTicketManagementSystem.Properties.Resources.icons8_movie_30px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 527);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD HALL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHALL
            // 
            this.buttonHALL.Location = new System.Drawing.Point(0, 0);
            this.buttonHALL.Name = "buttonHALL";
            this.buttonHALL.Size = new System.Drawing.Size(75, 23);
            this.buttonHALL.TabIndex = 0;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::MovieTicketManagementSystem.Properties.Resources.icons8_logout_rounded_up_30px;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(17, 887);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(291, 57);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // addMovie_btn
            // 
            this.addMovie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addMovie_btn.FlatAppearance.BorderSize = 0;
            this.addMovie_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovie_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_btn.ForeColor = System.Drawing.Color.White;
            this.addMovie_btn.Image = global::MovieTicketManagementSystem.Properties.Resources.icons8_movie_30px;
            this.addMovie_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addMovie_btn.Location = new System.Drawing.Point(17, 430);
            this.addMovie_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addMovie_btn.Name = "addMovie_btn";
            this.addMovie_btn.Size = new System.Drawing.Size(291, 57);
            this.addMovie_btn.TabIndex = 3;
            this.addMovie_btn.Text = "ADD MOVIE";
            this.addMovie_btn.UseVisualStyleBackColor = false;
            this.addMovie_btn.Click += new System.EventHandler(this.addMovie_btn_Click);
            // 
            // addStaff_btn
            // 
            this.addStaff_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addStaff_btn.FlatAppearance.BorderSize = 0;
            this.addStaff_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStaff_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaff_btn.ForeColor = System.Drawing.Color.White;
            this.addStaff_btn.Image = global::MovieTicketManagementSystem.Properties.Resources.icons8_user_filled_30px;
            this.addStaff_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStaff_btn.Location = new System.Drawing.Point(17, 346);
            this.addStaff_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addStaff_btn.Name = "addStaff_btn";
            this.addStaff_btn.Size = new System.Drawing.Size(291, 57);
            this.addStaff_btn.TabIndex = 2;
            this.addStaff_btn.Text = "ADD STAFF";
            this.addStaff_btn.UseVisualStyleBackColor = false;
            this.addStaff_btn.Click += new System.EventHandler(this.addStaff_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = global::MovieTicketManagementSystem.Properties.Resources.icons8_dashboard_30px;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(17, 260);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(291, 57);
            this.dashboard_btn.TabIndex = 1;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MovieTicketManagementSystem.Properties.Resources.icons8_movie_projector_100px;
            this.pictureBox1.Location = new System.Drawing.Point(88, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1759, 982);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button addStaff_btn;
        private System.Windows.Forms.Button addMovie_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel panel1;
        private AddStaffsForm addStaffsForm1;
        private AddMovieForm addMovieForm1;
        private dashboardForm dashboardForm1;
        private System.Windows.Forms.Button buttonHALL;
        private System.Windows.Forms.Button button1;
        private hall hall1;
    }
}