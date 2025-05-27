namespace MovieTicketManagementSystem
{
    partial class hall
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxHall = new System.Windows.Forms.TextBox();
            this.HallNumberlabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.textBoxHall);
            this.panel1.Controls.Add(this.HallNumberlabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(23, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 207);
            this.panel1.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(722, 98);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(152, 48);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(722, 22);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 48);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(499, 98);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(152, 48);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click_1);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(499, 22);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 48);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(209, 84);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 11;
            // 
            // textBoxHall
            // 
            this.textBoxHall.Location = new System.Drawing.Point(208, 21);
            this.textBoxHall.Name = "textBoxHall";
            this.textBoxHall.Size = new System.Drawing.Size(145, 22);
            this.textBoxHall.TabIndex = 10;
            // 
            // HallNumberlabel
            // 
            this.HallNumberlabel.AutoSize = true;
            this.HallNumberlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HallNumberlabel.ForeColor = System.Drawing.Color.Black;
            this.HallNumberlabel.Location = new System.Drawing.Point(50, 22);
            this.HallNumberlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HallNumberlabel.Name = "HallNumberlabel";
            this.HallNumberlabel.Size = new System.Drawing.Size(123, 22);
            this.HallNumberlabel.TabIndex = 9;
            this.HallNumberlabel.Text = "Hall Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(50, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Capacity";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(23, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1352, 453);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(874, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.comboBoxStatus.Location = new System.Drawing.Point(208, 148);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 20;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(50, 146);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(69, 22);
            this.StatusLabel.TabIndex = 21;
            this.StatusLabel.Text = "Status";
            // 
            // hall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "hall";
            this.Size = new System.Drawing.Size(1419, 928);
            this.Load += new System.EventHandler(this.hall_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxHall;
        private System.Windows.Forms.Label HallNumberlabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label StatusLabel;
    }
}
