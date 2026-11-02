namespace QuizinAja
{
    partial class QuizReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cQuiz = new System.Windows.Forms.ComboBox();
            this.quizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lAvgTime = new System.Windows.Forms.Label();
            this.lAvgCorrect = new System.Windows.Forms.Label();
            this.lPaticipant = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.participantNicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Quiz Report";
            // 
            // cQuiz
            // 
            this.cQuiz.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.quizBindingSource, "ID", true));
            this.cQuiz.DataSource = this.quizBindingSource;
            this.cQuiz.DisplayMember = "Name";
            this.cQuiz.FormattingEnabled = true;
            this.cQuiz.Location = new System.Drawing.Point(49, 45);
            this.cQuiz.Name = "cQuiz";
            this.cQuiz.Size = new System.Drawing.Size(146, 21);
            this.cQuiz.TabIndex = 1;
            this.cQuiz.ValueMember = "ID";
            this.cQuiz.SelectedIndexChanged += new System.EventHandler(this.cQuiz_SelectedIndexChanged);
            // 
            // quizBindingSource
            // 
            this.quizBindingSource.DataSource = typeof(QuizinAja.Quiz);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quiz";
            // 
            // lAvgTime
            // 
            this.lAvgTime.AutoSize = true;
            this.lAvgTime.Location = new System.Drawing.Point(331, 32);
            this.lAvgTime.Name = "lAvgTime";
            this.lAvgTime.Size = new System.Drawing.Size(113, 13);
            this.lAvgTime.TabIndex = 3;
            this.lAvgTime.Text = "Average Time Taken :";
            // 
            // lAvgCorrect
            // 
            this.lAvgCorrect.AutoSize = true;
            this.lAvgCorrect.Location = new System.Drawing.Point(331, 55);
            this.lAvgCorrect.Name = "lAvgCorrect";
            this.lAvgCorrect.Size = new System.Drawing.Size(151, 13);
            this.lAvgCorrect.TabIndex = 4;
            this.lAvgCorrect.Text = "Average Correct Precentage  :";
            // 
            // lPaticipant
            // 
            this.lPaticipant.AutoSize = true;
            this.lPaticipant.Location = new System.Drawing.Point(331, 78);
            this.lPaticipant.Name = "lPaticipant";
            this.lPaticipant.Size = new System.Drawing.Size(87, 13);
            this.lPaticipant.TabIndex = 5;
            this.lPaticipant.Text = "Total Paticipant :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 324);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.participantNicknameDataGridViewTextBoxColumn,
            this.timeTakenDataGridViewTextBoxColumn,
            this.correctPercentage});
            this.dataGridView1.DataSource = this.participantBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // participantNicknameDataGridViewTextBoxColumn
            // 
            this.participantNicknameDataGridViewTextBoxColumn.DataPropertyName = "ParticipantNickname";
            this.participantNicknameDataGridViewTextBoxColumn.HeaderText = "ParticipantNickname";
            this.participantNicknameDataGridViewTextBoxColumn.Name = "participantNicknameDataGridViewTextBoxColumn";
            // 
            // timeTakenDataGridViewTextBoxColumn
            // 
            this.timeTakenDataGridViewTextBoxColumn.DataPropertyName = "TimeTaken";
            this.timeTakenDataGridViewTextBoxColumn.HeaderText = "TimeTaken";
            this.timeTakenDataGridViewTextBoxColumn.Name = "timeTakenDataGridViewTextBoxColumn";
            // 
            // correctPercentage
            // 
            this.correctPercentage.HeaderText = "Correct Percentage";
            this.correctPercentage.Name = "correctPercentage";
            // 
            // participantBindingSource
            // 
            this.participantBindingSource.DataSource = typeof(QuizinAja.Participant);
            // 
            // QuizReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lPaticipant);
            this.Controls.Add(this.lAvgCorrect);
            this.Controls.Add(this.lAvgTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cQuiz);
            this.Controls.Add(this.label1);
            this.Name = "QuizReportForm";
            this.Text = "QuizReportForm";
            this.Load += new System.EventHandler(this.QuizReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cQuiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lAvgTime;
        private System.Windows.Forms.Label lAvgCorrect;
        private System.Windows.Forms.Label lPaticipant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn participantNicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeTakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctPercentage;
        private System.Windows.Forms.BindingSource participantBindingSource;
        private System.Windows.Forms.BindingSource quizBindingSource;
    }
}