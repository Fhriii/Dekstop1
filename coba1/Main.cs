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
    public partial class Main : Form
    {
        public int UserID { get; set; }
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserID.ToString());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dc3 = new DataClasses1DataContext();
            var fullname = (from f in dc3.Users where f.ID == UserID select f.FullName).FirstOrDefault();
            label1.Text = fullname.ToString();
            var data = from d in dc3.Quizs where d.ID== UserID select new { d.Name, d.Code ,d.Description};
            var data2 = from n in dc3.Questions where n.QuizID==UserID select n;
            int data3=data2.Count();
            var Last = new List<object> { new { RowCount = data3 } };
            dataGridView1.DataSource = data;
            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addQuiz(UserID);
        }
        private void addQuiz(int idUser)
        {
            AddQuiz addquiz = new AddQuiz();
            addquiz.UserID=idUser;
            this.Hide();
            addquiz.ShowDialog();
        }
    }
}
