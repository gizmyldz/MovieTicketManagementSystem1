using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Security.Policy;


namespace MovieTicketManagementSystem
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sqlconName con = new sqlconName();
            SqlConnection connection = con.connection();

            
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username = @username AND email = @email", connection);
            cmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@email", textBox2.Text.Trim());

            SqlDataReader oku = cmd.ExecuteReader();

            if (oku.Read())
            {
                try
                {
                    // Mail bilgileri
                    string date = DateTime.Now.ToLongDateString();
                    string mailadress = "movieticket.sender@gmail.com";        // Gönderici mail
                    string password = "zzjavuvgtrzcvvxp";                      // Gmail uygulama şifresi
                    string smtpsrvr = "smtp.gmail.com";
                    string toWho = oku["email"].ToString();
                    string adSoyad = oku["username"].ToString();
                    string sifre = oku["password"].ToString();

                    string konu = "Şifre Hatırlatma Maili";
                    string yaz = $"Sayın {adSoyad},\n\n" +
                                 $"{date} tarihinde şifre hatırlatma talebinde bulundunuz.\n\n" +
                                 $"Parolanız: {sifre}\n\nİyi Günler.";

                    // SMTP ayarları
                    SmtpClient smtpserver = new SmtpClient(smtpsrvr, 587);
                    smtpserver.Credentials = new NetworkCredential(mailadress, password);
                    smtpserver.EnableSsl = true;

                    // Mail oluştur
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(mailadress);
                    mail.To.Add(toWho);
                    mail.Subject = konu;
                    mail.Body = yaz;

                    // Mail gönder
                    smtpserver.Send(mail);

                    MessageBox.Show("Girmiş olduğunuz bilgiler doğru. Şifreniz e-posta adresinize gönderildi.");
                    this.Hide();
                }
                catch (Exception Hata)
                {
                    MessageBox.Show("Mail Gönderme Hatası: " + Hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya e-posta yanlış.");
            }

            connection.Close(); // Bağlantıyı kapatmayı unutma



        }






    }
    }

