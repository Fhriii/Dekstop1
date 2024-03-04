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
    public partial class AddQuiz : Form
    {
        string correctAnsw = "";

        public int UserID { get; set; }
        public AddQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string questionString = quest.Text;
            string option_A = answer_A.Text;
            string option_B = answer_B.Text;
            string option_C = answer_C.Text;
            string option_D = answer_D.Text;
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                correctAnsw = option_A;
            }
            else if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                correctAnsw = option_B;
            }
            else if (radioButton3.Checked)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton4.Checked = false;
                correctAnsw = option_C;
            }
            else if (radioButton4.Checked)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton2.Checked = false;
                correctAnsw = option_D;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            dataGridView1.Rows.Add("", questionString, option_A, option_B, option_C, option_D, correctAnsw);
            clearQuest();
        }
        private void clearQuest()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            answer_A.Text = "";
            answer_B.Text = "";
            answer_C.Text = "";
            answer_D.Text = "";
            quest.Text = "";

        }
        public void clearQuiz()
        {
            qname.Text = "";
            qcode.Text = "";
            desc.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc4 = new DataClasses1DataContext();
            var quizz= (from q in dc4.Quizs select q).FirstOrDefault();

            try
            {
                Quiz quiz = new Quiz()
                {
                    UserID = UserID,
                    Name = qname.Text,
                    Code = qcode.Text,
                    Description = desc.Text ,
                    CreatedAt = DateTime.Now

                };
                dc4.Quizs.InsertOnSubmit(quiz);
                dc4.SubmitChanges();
                clearQuiz();
                for (int i = 0; i < dataGridView1.Rows.Count-1;i++)
                {
                    var questString = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    var opA = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    var opB = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    var opC = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    var opD = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    var corect = dataGridView1.Rows[i].Cells[6].Value.ToString();

                    // Create a new Question object for each iteration
                    Question questt = new Question
                    {

                        QuizID = quizz.ID,
                        Question1 = questString,
                        OptionA = opA,
                        OptionB = opB,
                        OptionC = opC,
                        OptionD = opD,
                        CorrectAnswer = corect
                    };


                
                    dc4.Questions.InsertOnSubmit(questt);
                    dc4.SubmitChanges();

                }
                DataTable dt = new DataTable();
                dt.Clear();
                MessageBox.Show("Data Tersimpan");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Quizname_Enter(object sender, EventArgs e)
        {

        }
    }
}

