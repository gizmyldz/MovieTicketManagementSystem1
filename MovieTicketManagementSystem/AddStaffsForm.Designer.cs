﻿
namespace MovieTicketManagementSystem
{
    partial class AddStaffsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addStaff_clearBtn = new System.Windows.Forms.Button();
            this.addStaff_deleteBtn = new System.Windows.Forms.Button();
            this.addStaff_updateBtn = new System.Windows.Forms.Button();
            this.addStaff_addBtn = new System.Windows.Forms.Button();
            this.addStaff_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addStaff_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addStaff_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(492, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 850);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(28, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(841, 753);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(24, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "All Staff";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addStaff_clearBtn);
            this.panel1.Controls.Add(this.addStaff_deleteBtn);
            this.panel1.Controls.Add(this.addStaff_updateBtn);
            this.panel1.Controls.Add(this.addStaff_addBtn);
            this.panel1.Controls.Add(this.addStaff_status);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addStaff_password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addStaff_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 850);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addStaff_clearBtn
            // 
            this.addStaff_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addStaff_clearBtn.FlatAppearance.BorderSize = 0;
            this.addStaff_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addStaff_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addStaff_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStaff_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaff_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addStaff_clearBtn.Location = new System.Drawing.Point(252, 544);
            this.addStaff_clearBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addStaff_clearBtn.Name = "addStaff_clearBtn";
            this.addStaff_clearBtn.Size = new System.Drawing.Size(152, 48);
            this.addStaff_clearBtn.TabIndex = 18;
            this.addStaff_clearBtn.Text = "CLEAR";
            this.addStaff_clearBtn.UseVisualStyleBackColor = false;
            this.addStaff_clearBtn.Click += new System.EventHandler(this.addStaff_clearBtn_Click);
            // 
            // addStaff_deleteBtn
            // 
            this.addStaff_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addStaff_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addStaff_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addStaff_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addStaff_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStaff_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaff_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.addStaff_deleteBtn.Location = new System.Drawing.Point(28, 544);
            this.addStaff_deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addStaff_deleteBtn.Name = "addStaff_deleteBtn";
            this.addStaff_deleteBtn.Size = new System.Drawing.Size(152, 48);
            this.addStaff_deleteBtn.TabIndex = 17;
            this.addStaff_deleteBtn.Text = "DELETE";
            this.addStaff_deleteBtn.UseVisualStyleBackColor = false;
            this.addStaff_deleteBtn.Click += new System.EventHandler(this.addStaff_deleteBtn_Click);
            // 
            // addStaff_updateBtn
            // 
            this.addStaff_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addStaff_updateBtn.FlatAppearance.BorderSize = 0;
            this.addStaff_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addStaff_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addStaff_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStaff_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaff_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addStaff_updateBtn.Location = new System.Drawing.Point(252, 474);
            this.addStaff_updateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addStaff_updateBtn.Name = "addStaff_updateBtn";
            this.addStaff_updateBtn.Size = new System.Drawing.Size(152, 48);
            this.addStaff_updateBtn.TabIndex = 16;
            this.addStaff_updateBtn.Text = "UPDATE";
            this.addStaff_updateBtn.UseVisualStyleBackColor = false;
            this.addStaff_updateBtn.Click += new System.EventHandler(this.addStaff_updateBtn_Click);
            // 
            // addStaff_addBtn
            // 
            this.addStaff_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.addStaff_addBtn.FlatAppearance.BorderSize = 0;
            this.addStaff_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addStaff_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.addStaff_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStaff_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaff_addBtn.ForeColor = System.Drawing.Color.White;
            this.addStaff_addBtn.Location = new System.Drawing.Point(28, 474);
            this.addStaff_addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addStaff_addBtn.Name = "addStaff_addBtn";
            this.addStaff_addBtn.Size = new System.Drawing.Size(152, 48);
            this.addStaff_addBtn.TabIndex = 15;
            this.addStaff_addBtn.Text = "ADD";
            this.addStaff_addBtn.UseVisualStyleBackColor = false;
            this.addStaff_addBtn.Click += new System.EventHandler(this.addStaff_addBtn_Click);
            // 
            // addStaff_status
            // 
            this.addStaff_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaff_status.FormattingEnabled = true;
            this.addStaff_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addStaff_status.Location = new System.Drawing.Point(28, 331);
            this.addStaff_status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addStaff_status.Name = "addStaff_status";
            this.addStaff_status.Size = new System.Drawing.Size(375, 33);
            this.addStaff_status.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Status";
            // 
            // addStaff_password
            // 
            this.addStaff_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaff_password.Location = new System.Drawing.Point(28, 241);
            this.addStaff_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addStaff_password.Name = "addStaff_password";
            this.addStaff_password.Size = new System.Drawing.Size(375, 30);
            this.addStaff_password.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // addStaff_username
            // 
            this.addStaff_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaff_username.Location = new System.Drawing.Point(28, 146);
            this.addStaff_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addStaff_username.Name = "addStaff_username";
            this.addStaff_username.Size = new System.Drawing.Size(375, 30);
            this.addStaff_username.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fill staff Information";
            // 
            // AddStaffsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddStaffsForm";
            this.Size = new System.Drawing.Size(1419, 928);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addStaff_clearBtn;
        private System.Windows.Forms.Button addStaff_deleteBtn;
        private System.Windows.Forms.Button addStaff_updateBtn;
        private System.Windows.Forms.Button addStaff_addBtn;
        private System.Windows.Forms.ComboBox addStaff_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addStaff_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addStaff_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
