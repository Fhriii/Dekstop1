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
    public partial class BuatAkun : Form
    {
        public BuatAkun()
        {
            InitializeComponent();
        }
        
  
        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc1 = new DataClasses1DataContext();
            User userBaru = new User();
            userBaru.Username=textBox1.Text;
            userBaru.FullName=textBox2.Text;
            userBaru.DateOfBirth=dateTimePicker1.Value;
            userBaru.Password = textBox3.Text;
            dc1.Users.InsertOnSubmit(userBaru);
            dc1.SubmitChanges();

            int IDuser=userBaru.ID;
            main(IDuser);

            
        }
        protected void main(int IDuser)
        {
            Main main = new Main();
            main.UserID=IDuser;
            this.Hide();
            main.ShowDialog();
        }
    }
}
