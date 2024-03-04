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
using System.Xml.Serialization;

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
        public String ansQuestion;
        int index;
        List<int> quizIDs = new List<int>();
        List<Panel> panels = new List<Panel>();
        private void quiziz_Load(object sender, EventArgs e)
        {
            nameparticipant.Text = Name;
            no1_Click(sender, e);
            idddd();
            panels.Add(panel1);
            panels.Add(panel2);
            panels.Add(panel3);
            panels.Add(panel4);
            panels.Add(panel5);

        }
        



        private void no1_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            
            var data1 = (from no1 in dc.Questions where no1.QuizID == QuizID select no1).FirstOrDefault();

            label.Text = data1.Question1;
            questionid = data1.ID;
            radioButton1.Text = data1.OptionA;
            radioButton2.Text = data1.OptionB;
            radioButton3.Text = data1.OptionC;
            radioButton4.Text = data1.OptionD;

            next.Show();
            
        }
        

        private void no2_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            var data2 = (from no2 in dc.Questions where no2.ID == quizIDs[1] select no2).FirstOrDefault();
            label1.Text = data2.Question1;
           
            radioButton5.Text = data2.OptionA;
            radioButton6.Text = data2.OptionB;
            radioButton7.Text = data2.OptionC;
            radioButton8.Text = data2.OptionD;

            
        }

        private void no3_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
            var data3 = (from no3 in dc.Questions where no3.ID == quizIDs[2] select no3).FirstOrDefault();
            label4.Text = data3.Question1;
            questionid = data3.ID;
            radioButton9.Text = data3.OptionA;
            radioButton10.Text = data3.OptionB;
            radioButton11.Text = data3.OptionC;
            radioButton12.Text = data3.OptionD;
      
       
        }

        private void no4_Click(object sender, EventArgs e)

        {
            panel4.BringToFront();
            var data4 = (from no4 in dc.Questions where no4.ID == quizIDs[3] select no4).FirstOrDefault();
            label5.Text = data4.Question1;
            questionid = data4.ID;
            radioButton13.Text = data4.OptionA;
            radioButton14.Text = data4.OptionB;
            radioButton15.Text = data4.OptionC;
            radioButton16.Text = data4.OptionD;
        
        }

        private void no5_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
            var data5 = (from no5 in dc.Questions where no5.ID == quizIDs[4] select no5).FirstOrDefault();
            label7.Text = data5.Question1;
            questionid = data5.ID;
            radioButton17.Text = data5.OptionA;
            radioButton18.Text = data5.OptionB;
            radioButton19.Text = data5.OptionC;
            radioButton20.Text = data5.OptionD;
          
            
        }

        private void idddd()
        {
            var data1 = (from no1 in dc.Questions where no1.ID == questionid select no1).FirstOrDefault();
            int count = (from no1 in dc.Questions where no1.QuizID == QuizID select no1).Count();
            for (int i = data1.ID; i < data1.ID + count ; i++)
            {
                quizIDs.Add(i);
            }
        }
        private void clearr()
        {
            radioButton1.Checked=false;
            radioButton2.Checked=false;
            radioButton3.Checked=false;
            radioButton4.Checked=false;
        }
        
        private void answer()
        {
            if (radioButton1.Checked)
            {
                ansQuestion = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                ansQuestion = radioButton2.Text;
            }
            else if(radioButton3.Checked)
            {
                ansQuestion = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                ansQuestion = radioButton1.Text;
            }
            else
            {
                ansQuestion = "";
            }
        }

        private void finish_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (index < panels.Count())
            {
                panels[++index].BringToFront();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void prev_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
