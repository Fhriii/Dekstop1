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

            // Periksa apakah UserID ada sebelum mengakses data
            var user = dc3.Users.FirstOrDefault(f => f.ID == UserID);
            if (user != null)
            {
                // Ambil fullname dan set label
                label1.Text = user.FullName;
               
                // Ambil data dari Quizs dan tambahkan ke DataGridView
                var quizData = from d in dc3.Quizs where d.UserID == UserID select new { d.Name, d.Code, d.Description };
                foreach (var quiz in quizData)
                {
                    DataGridViewRow row = new DataGridViewRow();

                 

                    DataGridViewTextBoxCell namaQuiz = new DataGridViewTextBoxCell();
                    namaQuiz.Value = quiz.Name;
                    row.Cells.Add(namaQuiz);

                    DataGridViewTextBoxCell codeQuiz = new DataGridViewTextBoxCell();
                    codeQuiz.Value = quiz.Code;
                    row.Cells.Add(codeQuiz);

                    DataGridViewTextBoxCell descQuiz = new DataGridViewTextBoxCell();
                    descQuiz.Value = quiz.Description;
                    row.Cells.Add(descQuiz);

                    var questionCount = dc3.Questions.Count(n => n.QuizID == UserID);
                    DataGridViewTextBoxCell numberQuiz = new DataGridViewTextBoxCell();
                    numberQuiz.Value = questionCount;
                    row.Cells.Add(numberQuiz);

                    
                    dataGridView1.Rows.Add(row);
                }

            }
            else
            {
 
                MessageBox.Show("UserID not found!");
            }

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
