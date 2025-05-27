
namespace MovieTicketManagementSystem
{
    partial class RegForm
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
            this.reg_signInBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_btn = new System.Windows.Forms.Button();
            this.reg_showPass = new System.Windows.Forms.CheckBox();
            this.reg_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.reg_cPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reg_signInBtn
            // 
            this.reg_signInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.reg_signInBtn.FlatAppearance.BorderSize = 0;
            this.reg_signInBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.reg_signInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.reg_signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_signInBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_signInBtn.ForeColor = System.Drawing.Color.White;
            this.reg_signInBtn.Location = new System.Drawing.Point(40, 722);
            this.reg_signInBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reg_signInBtn.Name = "reg_signInBtn";
            this.reg_signInBtn.Size = new System.Drawing.Size(392, 53);
            this.reg_signInBtn.TabIndex = 19;
            this.reg_signInBtn.Text = "Sign in here";
            this.reg_signInBtn.UseVisualStyleBackColor = false;
            this.reg_signInBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 684);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Create an account?";
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.reg_btn.FlatAppearance.BorderSize = 0;
            this.reg_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.reg_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.ForeColor = System.Drawing.Color.White;
            this.reg_btn.Location = new System.Drawing.Point(40, 458);
            this.reg_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(392, 53);
            this.reg_btn.TabIndex = 17;
            this.reg_btn.Text = "REGISTER";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // reg_showPass
            // 
            this.reg_showPass.AutoSize = true;
            this.reg_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_showPass.Location = new System.Drawing.Point(40, 414);
            this.reg_showPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reg_showPass.Name = "reg_showPass";
            this.reg_showPass.Size = new System.Drawing.Size(151, 24);
            this.reg_showPass.TabIndex = 16;
            this.reg_showPass.Text = "Show Password";
            this.reg_showPass.UseVisualStyleBackColor = true;
            this.reg_showPass.CheckedChanged += new System.EventHandler(this.reg_showPass_CheckedChanged);
            // 
            // reg_password
            // 
            this.reg_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_password.Location = new System.Drawing.Point(40, 294);
            this.reg_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reg_password.Name = "reg_password";
            this.reg_password.PasswordChar = '*';
            this.reg_password.Size = new System.Drawing.Size(391, 30);
            this.reg_password.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // reg_username
            // 
            this.reg_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_username.Location = new System.Drawing.Point(40, 180);
            this.reg_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(391, 30);
            this.reg_username.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "REGISTRATION FORM";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(459, 12);
            this.close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 22);
            this.close.TabIndex = 10;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // reg_cPassword
            // 
            this.reg_cPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_cPassword.Location = new System.Drawing.Point(40, 374);
            this.reg_cPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reg_cPassword.Name = "reg_cPassword";
            this.reg_cPassword.PasswordChar = '*';
            this.reg_cPassword.Size = new System.Drawing.Size(391, 30);
            this.reg_cPassword.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 352);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Confirm Password";
            // 
            // reg_email
            // 
            this.reg_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_email.Location = new System.Drawing.Point(41, 238);
            this.reg_email.Margin = new System.Windows.Forms.Padding(4);
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(391, 30);
            this.reg_email.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "E-Mail";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 790);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reg_email);
            this.Controls.Add(this.reg_cPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reg_signInBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.reg_showPass);
            this.Controls.Add(this.reg_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reg_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reg_signInBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.CheckBox reg_showPass;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.TextBox reg_cPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reg_email;
        private System.Windows.Forms.Label label6;
    }
}