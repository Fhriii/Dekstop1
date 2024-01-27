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

        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc4 = new DataClasses1DataContext();
            Question questt = new Question();

            questt.ID = 58;
            questt.QuizID = UserID;
            questt.Question1 = quest.Text;
            questt.OptionA = answer_A.Text;
            questt.OptionB = answer_B.Text;
            questt.OptionC = answer_C.Text;
            questt.OptionD = answer_D.Text;
            questt.CorrectAnswer = correctAnsw;

            dc4.Questions.InsertOnSubmit(questt);
            dc4.SubmitChanges();
            




        }
    }
}
