namespace QuizinAja
{
    partial class AddQuesionForm
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
            this.components = new System.ComponentModel.Container();
            this.lSesion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tquizName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tQuizCode = new System.Windows.Forms.TextBox();
            this.tQuizDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.rD = new System.Windows.Forms.RadioButton();
            this.tD = new System.Windows.Forms.TextBox();
            this.rC = new System.Windows.Forms.RadioButton();
            this.tC = new System.Windows.Forms.TextBox();
            this.rB = new System.Windows.Forms.RadioButton();
            this.tB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rA = new System.Windows.Forms.RadioButton();
            this.tA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rQuesion = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lSesion
            // 
            this.lSesion.AutoSize = true;
            this.lSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSesion.Location = new System.Drawing.Point(12, 16);
            this.lSesion.Name = "lSesion";
            this.lSesion.Size = new System.Drawing.Size(151, 20);
            this.lSesion.TabIndex = 3;
            this.lSesion.Text = "Add New Quesion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fil In The Quiz Detail Below";
            // 
            // tquizName
            // 
            this.tquizName.Location = new System.Drawing.Point(16, 97);
            this.tquizName.Name = "tquizName";
            this.tquizName.Size = new System.Drawing.Size(174, 20);
            this.tquizName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quiz Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quiz Code";
            // 
            // tQuizCode
            // 
            this.tQuizCode.Location = new System.Drawing.Point(19, 138);
            this.tQuizCode.Name = "tQuizCode";
            this.tQuizCode.Size = new System.Drawing.Size(174, 20);
            this.tQuizCode.TabIndex = 6;
            // 
            // tQuizDescription
            // 
            this.tQuizDescription.Location = new System.Drawing.Point(207, 99);
            this.tQuizDescription.Name = "tQuizDescription";
            this.tQuizDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tQuizDescription.Size = new System.Drawing.Size(576, 58);
            this.tQuizDescription.TabIndex = 8;
            this.tQuizDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quiz Description";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rD);
            this.groupBox1.Controls.Add(this.tD);
            this.groupBox1.Controls.Add(this.rC);
            this.groupBox1.Controls.Add(this.tC);
            this.groupBox1.Controls.Add(this.rB);
            this.groupBox1.Controls.Add(this.tB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rA);
            this.groupBox1.Controls.Add(this.tA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rQuesion);
            this.groupBox1.Location = new System.Drawing.Point(15, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 341);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "quesion Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.question1DataGridViewTextBoxColumn,
            this.optionADataGridViewTextBoxColumn,
            this.optionBDataGridViewTextBoxColumn,
            this.optionCDataGridViewTextBoxColumn,
            this.optionDDataGridViewTextBoxColumn,
            this.correctAnswerDataGridViewTextBoxColumn,
            this.delete});
            this.dataGridView1.DataSource = this.questionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 153);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add Question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rD
            // 
            this.rD.AutoSize = true;
            this.rD.Location = new System.Drawing.Point(198, 128);
            this.rD.Name = "rD";
            this.rD.Size = new System.Drawing.Size(14, 13);
            this.rD.TabIndex = 21;
            this.rD.TabStop = true;
            this.rD.UseVisualStyleBackColor = true;
            // 
            // tD
            // 
            this.tD.Location = new System.Drawing.Point(220, 124);
            this.tD.Name = "tD";
            this.tD.Size = new System.Drawing.Size(134, 20);
            this.tD.TabIndex = 20;
            // 
            // rC
            // 
            this.rC.AutoSize = true;
            this.rC.Location = new System.Drawing.Point(198, 102);
            this.rC.Name = "rC";
            this.rC.Size = new System.Drawing.Size(14, 13);
            this.rC.TabIndex = 19;
            this.rC.TabStop = true;
            this.rC.UseVisualStyleBackColor = true;
            // 
            // tC
            // 
            this.tC.Location = new System.Drawing.Point(220, 98);
            this.tC.Name = "tC";
            this.tC.Size = new System.Drawing.Size(134, 20);
            this.tC.TabIndex = 18;
            // 
            // rB
            // 
            this.rB.AutoSize = true;
            this.rB.Location = new System.Drawing.Point(198, 76);
            this.rB.Name = "rB";
            this.rB.Size = new System.Drawing.Size(14, 13);
            this.rB.TabIndex = 17;
            this.rB.TabStop = true;
            this.rB.UseVisualStyleBackColor = true;
            // 
            // tB
            // 
            this.tB.Location = new System.Drawing.Point(220, 72);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(134, 20);
            this.tB.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Answer";
            // 
            // rA
            // 
            this.rA.AutoSize = true;
            this.rA.Location = new System.Drawing.Point(198, 50);
            this.rA.Name = "rA";
            this.rA.Size = new System.Drawing.Size(14, 13);
            this.rA.TabIndex = 14;
            this.rA.TabStop = true;
            this.rA.UseVisualStyleBackColor = true;
            // 
            // tA
            // 
            this.tA.Location = new System.Drawing.Point(220, 46);
            this.tA.Name = "tA";
            this.tA.Size = new System.Drawing.Size(134, 20);
            this.tA.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Question";
            // 
            // rQuesion
            // 
            this.rQuesion.Location = new System.Drawing.Point(7, 42);
            this.rQuesion.Name = "rQuesion";
            this.rQuesion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rQuesion.Size = new System.Drawing.Size(168, 102);
            this.rQuesion.TabIndex = 11;
            this.rQuesion.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 24;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(636, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 25;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "No";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // question1DataGridViewTextBoxColumn
            // 
            this.question1DataGridViewTextBoxColumn.DataPropertyName = "Question1";
            this.question1DataGridViewTextBoxColumn.HeaderText = "Question";
            this.question1DataGridViewTextBoxColumn.Name = "question1DataGridViewTextBoxColumn";
            // 
            // optionADataGridViewTextBoxColumn
            // 
            this.optionADataGridViewTextBoxColumn.DataPropertyName = "OptionA";
            this.optionADataGridViewTextBoxColumn.HeaderText = "OptionA";
            this.optionADataGridViewTextBoxColumn.Name = "optionADataGridViewTextBoxColumn";
            // 
            // optionBDataGridViewTextBoxColumn
            // 
            this.optionBDataGridViewTextBoxColumn.DataPropertyName = "OptionB";
            this.optionBDataGridViewTextBoxColumn.HeaderText = "OptionB";
            this.optionBDataGridViewTextBoxColumn.Name = "optionBDataGridViewTextBoxColumn";
            // 
            // optionCDataGridViewTextBoxColumn
            // 
            this.optionCDataGridViewTextBoxColumn.DataPropertyName = "OptionC";
            this.optionCDataGridViewTextBoxColumn.HeaderText = "OptionC";
            this.optionCDataGridViewTextBoxColumn.Name = "optionCDataGridViewTextBoxColumn";
            // 
            // optionDDataGridViewTextBoxColumn
            // 
            this.optionDDataGridViewTextBoxColumn.DataPropertyName = "OptionD";
            this.optionDDataGridViewTextBoxColumn.HeaderText = "OptionD";
            this.optionDDataGridViewTextBoxColumn.Name = "optionDDataGridViewTextBoxColumn";
            // 
            // correctAnswerDataGridViewTextBoxColumn
            // 
            this.correctAnswerDataGridViewTextBoxColumn.DataPropertyName = "CorrectAnswer";
            this.correctAnswerDataGridViewTextBoxColumn.HeaderText = "CorrectAnswer";
            this.correctAnswerDataGridViewTextBoxColumn.Name = "correctAnswerDataGridViewTextBoxColumn";
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(QuizinAja.Question);
            // 
            // AddQuesionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tQuizDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tQuizCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tquizName);
            this.Controls.Add(this.lSesion);
            this.Controls.Add(this.label1);
            this.Name = "AddQuesionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuesionForm";
            this.Load += new System.EventHandler(this.AddQuesionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tquizName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tQuizCode;
        private System.Windows.Forms.RichTextBox tQuizDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rQuesion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rD;
        private System.Windows.Forms.TextBox tD;
        private System.Windows.Forms.RadioButton rC;
        private System.Windows.Forms.TextBox tC;
        private System.Windows.Forms.RadioButton rB;
        private System.Windows.Forms.TextBox tB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn question1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}