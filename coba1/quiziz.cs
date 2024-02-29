using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coba1
{
    public partial class quiziz : Form
    {
        public quiziz()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public int QuizID { get; set; }
        public String Name { get; set; }
        public int questionid;

        private void quiziz_Load(object sender, EventArgs e)
        {
            nameparticipant.Text = Name;
            no1_Click(sender, e);
            
        }




        private void no1_Click(object sender, EventArgs e)
        {
            var data1=(from no1 in dc.Questions where no1.QuizID==QuizID  select no1 ).FirstOrDefault();
            questText.Text = data1.Question1;
            questionid = data1.ID;
            radioButton1.Text = data1.OptionA;
            radioButton2.Text = data1.OptionB;
            radioButton3.Text = data1.OptionC;
            radioButton4.Text = data1.OptionD;
            prev.Hide();
            next.Show();
            finish.Hide();
        }














        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void no2_Click(object sender, EventArgs e)
        {
            var data2 = (from no2 in dc.Questions where no2.ID == questionid+1 select no2).FirstOrDefault();
            questText.Text = data2.Question1;
            questionid = data2.ID;
            radioButton1.Text = data2.OptionA;
            radioButton2.Text = data2.OptionB;
            radioButton3.Text = data2.OptionC;
            radioButton4.Text = data2.OptionD;
            prev.Show();
            next.Show();
            finish.Hide();
        }

        private void no3_Click(object sender, EventArgs e)
        {
            var data3 = (from no3 in dc.Questions where no3.ID == questionid + 1 select no3).FirstOrDefault();
            questText.Text = data3.Question1;
            questionid = data3.ID;
            radioButton1.Text = data3.OptionA;
            radioButton2.Text = data3.OptionB;
            radioButton3.Text = data3.OptionC;
            radioButton4.Text = data3.OptionD;
            no3.BackColor = Color.MediumBlue;
            prev.Show();
            next.Show();
            finish.Hide();
        }

        private void no4_Click(object sender, EventArgs e)
        {
            var data4 = (from no4 in dc.Questions where no4.ID == questionid + 1 select no4).FirstOrDefault();
            questText.Text = data4.Question1;
            questionid = data4.ID;
            radioButton1.Text = data4.OptionA;
            radioButton2.Text = data4.OptionB;
            radioButton3.Text = data4.OptionC;
            radioButton4.Text = data4.OptionD;
            prev.Show();
            next.Show();
            finish.Hide();
        }

        private void no5_Click(object sender, EventArgs e)
        {
            var data5 = (from no5 in dc.Questions where no5.ID == questionid + 1 select no5).FirstOrDefault();
            questText.Text = data5.Question1;
            questionid = data5.ID;
            radioButton1.Text = data5.OptionA;
            radioButton2.Text = data5.OptionB;
            radioButton3.Text = data5.OptionC;
            radioButton4.Text = data5.OptionD;
            next.Hide();
            prev.Show();
            
        }

        private void finish_Click(object sender, EventArgs e)
        {

        }
    }
}
