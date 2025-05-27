
namespace MovieTicketManagementSystem
{
    partial class staffForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dashboardForm1 = new MovieTicketManagementSystem.dashboardForm();
            this.buyTicketForm2 = new MovieTicketManagementSystem.buyTicketForm();
            this.buyTicketForm1 = new MovieTicketManagementSystem.buyTicketForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 798);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(255, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::MovieTicketManagementSystem.Properties.Resources.icons8_ticket_30px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "BUY TICKET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.logout_btn.Location = new System.Drawing.Point(13, 721);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(218, 46);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
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
            this.dashboard_btn.Location = new System.Drawing.Point(13, 211);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(218, 46);
            this.dashboard_btn.TabIndex = 1;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MovieTicketManagementSystem.Properties.Resources.icons8_movie_projector_100px;
            this.pictureBox1.Location = new System.Drawing.Point(66, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1038, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Ticket Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(791, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome, MarcoMan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MovieTicketManagementSystem.Properties.Resources.icons8_User_30px;
            this.pictureBox2.Location = new System.Drawing.Point(755, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(255, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 44);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dashboardForm1);
            this.panel4.Controls.Add(this.buyTicketForm2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(255, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1064, 754);
            this.panel4.TabIndex = 3;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(0, 0);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1064, 754);
            this.dashboardForm1.TabIndex = 1;
            // 
            // buyTicketForm2
            // 
            this.buyTicketForm2.Location = new System.Drawing.Point(0, 0);
            this.buyTicketForm2.Name = "buyTicketForm2";
            this.buyTicketForm2.Size = new System.Drawing.Size(1064, 754);
            this.buyTicketForm2.TabIndex = 0;
            // 
            // buyTicketForm1
            // 
            this.buyTicketForm1.Location = new System.Drawing.Point(0, 0);
            this.buyTicketForm1.Name = "buyTicketForm1";
            this.buyTicketForm1.Size = new System.Drawing.Size(1064, 754);
            this.buyTicketForm1.TabIndex = 0;
            // 
            // staffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 798);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staffForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private buyTicketForm buyTicketForm1;
        private System.Windows.Forms.Panel panel4;
        private dashboardForm dashboardForm1;
        private buyTicketForm buyTicketForm2;
    }
}