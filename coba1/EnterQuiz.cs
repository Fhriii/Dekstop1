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
    public partial class EnterQuiz : Form
    {
        public EnterQuiz()
        {
            InitializeComponent();
        }

        DataClasses1DataContext dc=new DataClasses1DataContext();
        public int quizID;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var codeQuiz=(from c in dc.Quizs where textBox1.Text==c.Code select c.ID).FirstOrDefault();
                if (codeQuiz.ToString() =="0")
                {
                    MessageBox.Show("Masukkan kode yang cocok");
                }
                else
                {
                    
                    quizID = codeQuiz;
                    quizz(quizID,textBox2.Text);
                }
            }
            catch {

                MessageBox.Show("Eror");
            }
            
        }
        public void quizz(int quizIID,String participanName)
        {
            quiziz qz = new quiziz();
            qz.QuizID = quizIID;
            qz.Name= participanName;
            this.Hide();
            qz.ShowDialog();
            

        }
    }
}
