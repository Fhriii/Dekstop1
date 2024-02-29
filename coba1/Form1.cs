using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dc = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            var user = (from u in dc.Users where u.Username==textBox1.Text select u).FirstOrDefault();
            
            
            if (!(user is null))
            {
                // Periksa apakah password sesuai
                if (user.Password == textBox2.Text)
                {
                    main(user.ID);
                  
                    // Tambahkan logika lanjutan di sini setelah login berhasil
                }
                else
                {
                    MessageBox.Show("Password salah");
                }
            }
            else
            {
                MessageBox.Show("User tidak ditemukan");
            }
        }
        public void main(int IDuser)
        {
            Main main = new Main();
            main.UserID = IDuser;
            this.Hide();
            main.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buatakun();
        }
        protected void buatakun()
        {
            BuatAkun akun = new BuatAkun();

            this.Hide();
            akun.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnterQuiz eq = new EnterQuiz();
            this.Hide();
            eq.ShowDialog();

        }

    }
}
