namespace coba1
{
    partial class AddQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Quizcode = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.Quizname = new System.Windows.Forms.GroupBox();
            this.quest = new System.Windows.Forms.TextBox();
            this.answer_A = new System.Windows.Forms.TextBox();
            this.answer_B = new System.Windows.Forms.TextBox();
            this.answer_C = new System.Windows.Forms.TextBox();
            this.answer_D = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quizname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 0;
            // 
            // Quizcode
            // 
            this.Quizcode.Location = new System.Drawing.Point(167, 125);
            this.Quizcode.Name = "Quizcode";
            this.Quizcode.Size = new System.Drawing.Size(150, 26);
            this.Quizcode.TabIndex = 1;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(452, 31);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.desc.Size = new System.Drawing.Size(362, 120);
            this.desc.TabIndex = 2;
            // 
            // Quizname
            // 
            this.Quizname.Controls.Add(this.radioButton4);
            this.Quizname.Controls.Add(this.radioButton3);
            this.Quizname.Controls.Add(this.radioButton2);
            this.Quizname.Controls.Add(this.radioButton1);
            this.Quizname.Controls.Add(this.dataGridView1);
            this.Quizname.Controls.Add(this.button1);
            this.Quizname.Controls.Add(this.answer_D);
            this.Quizname.Controls.Add(this.answer_C);
            this.Quizname.Controls.Add(this.answer_B);
            this.Quizname.Controls.Add(this.answer_A);
            this.Quizname.Controls.Add(this.quest);
            this.Quizname.Location = new System.Drawing.Point(34, 179);
            this.Quizname.Name = "Quizname";
            this.Quizname.Size = new System.Drawing.Size(894, 457);
            this.Quizname.TabIndex = 3;
            this.Quizname.TabStop = false;
            this.Quizname.Text = "groupBox1";
            // 
            // quest
            // 
            this.quest.Location = new System.Drawing.Point(63, 85);
            this.quest.Multiline = true;
            this.quest.Name = "quest";
            this.quest.Size = new System.Drawing.Size(315, 102);
            this.quest.TabIndex = 1;
            // 
            // answer_A
            // 
            this.answer_A.Location = new System.Drawing.Point(519, 62);
            this.answer_A.Name = "answer_A";
            this.answer_A.Size = new System.Drawing.Size(100, 26);
            this.answer_A.TabIndex = 2;
            // 
            // answer_B
            // 
            this.answer_B.Location = new System.Drawing.Point(519, 97);
            this.answer_B.Name = "answer_B";
            this.answer_B.Size = new System.Drawing.Size(100, 26);
            this.answer_B.TabIndex = 3;
            // 
            // answer_C
            // 
            this.answer_C.Location = new System.Drawing.Point(519, 129);
            this.answer_C.Name = "answer_C";
            this.answer_C.Size = new System.Drawing.Size(100, 26);
            this.answer_C.TabIndex = 4;
            // 
            // answer_D
            // 
            this.answer_D.Location = new System.Drawing.Point(519, 161);
            this.answer_D.Name = "answer_D";
            this.answer_D.Size = new System.Drawing.Size(100, 26);
            this.answer_D.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Question,
            this.option_A,
            this.option_B,
            this.option_C,
            this.option_D,
            this.correctAns});
            this.dataGridView1.Location = new System.Drawing.Point(19, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(869, 207);
            this.dataGridView1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(706, 682);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(473, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(21, 20);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(473, 100);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(21, 20);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(473, 132);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(21, 20);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(473, 167);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(21, 20);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 8;
            this.No.Name = "No";
            // 
            // Question
            // 
            this.Question.HeaderText = "Question";
            this.Question.MinimumWidth = 8;
            this.Question.Name = "Question";
            // 
            // option_A
            // 
            this.option_A.HeaderText = "option_A";
            this.option_A.MinimumWidth = 8;
            this.option_A.Name = "option_A";
            // 
            // option_B
            // 
            this.option_B.HeaderText = "option_B";
            this.option_B.MinimumWidth = 8;
            this.option_B.Name = "option_B";
            // 
            // option_C
            // 
            this.option_C.HeaderText = "option_C";
            this.option_C.MinimumWidth = 8;
            this.option_C.Name = "option_C";
            // 
            // option_D
            // 
            this.option_D.HeaderText = "option_D";
            this.option_D.MinimumWidth = 8;
            this.option_D.Name = "option_D";
            // 
            // correctAns
            // 
            this.correctAns.HeaderText = "Correct_Answer";
            this.correctAns.MinimumWidth = 8;
            this.correctAns.Name = "correctAns";
            // 
            // AddQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 743);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Quizname);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.Quizcode);
            this.Controls.Add(this.textBox1);
            this.Name = "AddQuiz";
            this.Text = "AddQuiz";
            this.Quizname.ResumeLayout(false);
            this.Quizname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Quizcode;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.GroupBox Quizname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox answer_D;
        private System.Windows.Forms.TextBox answer_C;
        private System.Windows.Forms.TextBox answer_B;
        private System.Windows.Forms.TextBox answer_A;
        private System.Windows.Forms.TextBox quest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn option_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn option_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn option_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn option_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctAns;
    }
}