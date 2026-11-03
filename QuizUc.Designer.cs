namespace QuizinAja
{
    partial class QuizUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.soal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rA = new System.Windows.Forms.RadioButton();
            this.rB = new System.Windows.Forms.RadioButton();
            this.rC = new System.Windows.Forms.RadioButton();
            this.rD = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // soal
            // 
            this.soal.AutoSize = true;
            this.soal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soal.Location = new System.Drawing.Point(26, 24);
            this.soal.Name = "soal";
            this.soal.Size = new System.Drawing.Size(73, 20);
            this.soal.TabIndex = 0;
            this.soal.Text = "Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Answer";
            // 
            // rA
            // 
            this.rA.AutoSize = true;
            this.rA.Location = new System.Drawing.Point(45, 171);
            this.rA.Name = "rA";
            this.rA.Size = new System.Drawing.Size(85, 17);
            this.rA.TabIndex = 2;
            this.rA.TabStop = true;
            this.rA.Text = "radioButton1";
            this.rA.UseVisualStyleBackColor = true;
            // 
            // rB
            // 
            this.rB.AutoSize = true;
            this.rB.Location = new System.Drawing.Point(45, 200);
            this.rB.Name = "rB";
            this.rB.Size = new System.Drawing.Size(85, 17);
            this.rB.TabIndex = 3;
            this.rB.TabStop = true;
            this.rB.Text = "radioButton1";
            this.rB.UseVisualStyleBackColor = true;
            // 
            // rC
            // 
            this.rC.AutoSize = true;
            this.rC.Location = new System.Drawing.Point(45, 229);
            this.rC.Name = "rC";
            this.rC.Size = new System.Drawing.Size(85, 17);
            this.rC.TabIndex = 4;
            this.rC.TabStop = true;
            this.rC.Text = "radioButton1";
            this.rC.UseVisualStyleBackColor = true;
            // 
            // rD
            // 
            this.rD.AutoSize = true;
            this.rD.Location = new System.Drawing.Point(45, 258);
            this.rD.Name = "rD";
            this.rD.Size = new System.Drawing.Size(85, 17);
            this.rD.TabIndex = 5;
            this.rD.TabStop = true;
            this.rD.Text = "radioButton1";
            this.rD.UseVisualStyleBackColor = true;
            // 
            // QuizUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rD);
            this.Controls.Add(this.rC);
            this.Controls.Add(this.rB);
            this.Controls.Add(this.rA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soal);
            this.Name = "QuizUc";
            this.Size = new System.Drawing.Size(436, 326);
            this.Load += new System.EventHandler(this.QuizUc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label soal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rA;
        private System.Windows.Forms.RadioButton rB;
        private System.Windows.Forms.RadioButton rC;
        private System.Windows.Forms.RadioButton rD;
    }
}
