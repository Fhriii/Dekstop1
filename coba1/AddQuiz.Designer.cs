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
            this.qname = new System.Windows.Forms.TextBox();
            this.qcode = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.Quizname = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.answer_D = new System.Windows.Forms.TextBox();
            this.answer_C = new System.Windows.Forms.TextBox();
            this.answer_B = new System.Windows.Forms.TextBox();
            this.answer_A = new System.Windows.Forms.TextBox();
            this.quest = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Quizname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qname
            // 
            this.qname.Location = new System.Drawing.Point(55, 107);
            this.qname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qname.Name = "qname";
            this.qname.Size = new System.Drawing.Size(132, 20);
            this.qname.TabIndex = 0;
            // 
            // qcode
            // 
            this.qcode.Location = new System.Drawing.Point(54, 147);
            this.qcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qcode.Name = "qcode";
            this.qcode.Size = new System.Drawing.Size(132, 20);
            this.qcode.TabIndex = 1;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(301, 95);
            this.desc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.desc.Size = new System.Drawing.Size(243, 79);
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
            this.Quizname.Location = new System.Drawing.Point(21, 218);
            this.Quizname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Quizname.Name = "Quizname";
            this.Quizname.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Quizname.Size = new System.Drawing.Size(598, 291);
            this.Quizname.TabIndex = 3;
            this.Quizname.TabStop = false;
            this.Quizname.Text = "Question Data";
            this.Quizname.Enter += new System.EventHandler(this.Quizname_Enter);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(315, 109);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(315, 86);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(315, 65);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(315, 41);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 146);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(579, 135);
            this.dataGridView1.TabIndex = 7;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer_D
            // 
            this.answer_D.Location = new System.Drawing.Point(346, 105);
            this.answer_D.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answer_D.Name = "answer_D";
            this.answer_D.Size = new System.Drawing.Size(68, 20);
            this.answer_D.TabIndex = 5;
            // 
            // answer_C
            // 
            this.answer_C.Location = new System.Drawing.Point(346, 84);
            this.answer_C.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answer_C.Name = "answer_C";
            this.answer_C.Size = new System.Drawing.Size(68, 20);
            this.answer_C.TabIndex = 4;
            // 
            // answer_B
            // 
            this.answer_B.Location = new System.Drawing.Point(346, 63);
            this.answer_B.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answer_B.Name = "answer_B";
            this.answer_B.Size = new System.Drawing.Size(68, 20);
            this.answer_B.TabIndex = 3;
            // 
            // answer_A
            // 
            this.answer_A.Location = new System.Drawing.Point(346, 40);
            this.answer_A.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answer_A.Name = "answer_A";
            this.answer_A.Size = new System.Drawing.Size(68, 20);
            this.answer_A.TabIndex = 2;
            // 
            // quest
            // 
            this.quest.Location = new System.Drawing.Point(42, 55);
            this.quest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quest.Multiline = true;
            this.quest.Name = "quest";
            this.quest.Size = new System.Drawing.Size(211, 68);
            this.quest.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 545);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quiz Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quiz Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.label4.Location = new System.Drawing.Point(65, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Add New Quiz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fill in the quiz detail below";
            // 
            // AddQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 605);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Quizname);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.qcode);
            this.Controls.Add(this.qname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddQuiz";
            this.Text = "AddQuiz";
            this.Quizname.ResumeLayout(false);
            this.Quizname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qname;
        private System.Windows.Forms.TextBox qcode;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}