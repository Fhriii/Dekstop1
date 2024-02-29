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
    public partial class quiziz : Form
    {
        public quiziz()
        {
            InitializeComponent();
        }
        public int QuizID { get; set; }
        public String Name { get; set; }

        
        private void quiziz_Load(object sender, EventArgs e)
        {
            nameparticipant.Text = Name;
            MessageBox.Show(QuizID.ToString());
            
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
