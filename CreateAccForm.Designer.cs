namespace QuizinAja
{
    partial class CreateAccForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tFullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tConfirmPassword = new System.Windows.Forms.TextBox();
            this.dDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fill In Below Information To Complete Your Registration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Create Account";
            // 
            // tUsername
            // 
            this.tUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Username", true));
            this.tUsername.Location = new System.Drawing.Point(25, 98);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(225, 20);
            this.tUsername.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fullname";
            // 
            // tFullname
            // 
            this.tFullname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "FullName", true));
            this.tFullname.Location = new System.Drawing.Point(27, 165);
            this.tFullname.Name = "tFullname";
            this.tFullname.Size = new System.Drawing.Size(225, 20);
            this.tFullname.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password";
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(279, 98);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(225, 20);
            this.tPassword.TabIndex = 18;
            this.tPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Retype Password";
            // 
            // tConfirmPassword
            // 
            this.tConfirmPassword.Location = new System.Drawing.Point(279, 165);
            this.tConfirmPassword.Name = "tConfirmPassword";
            this.tConfirmPassword.Size = new System.Drawing.Size(225, 20);
            this.tConfirmPassword.TabIndex = 20;
            this.tConfirmPassword.UseSystemPasswordChar = true;
            // 
            // dDateOfBirth
            // 
            this.dDateOfBirth.Location = new System.Drawing.Point(27, 239);
            this.dDateOfBirth.Name = "dDateOfBirth";
            this.dDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dDateOfBirth.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Date Of Birth";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(479, 43);
            this.button1.TabIndex = 24;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(288, 358);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 13);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Already Have Account ?";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(QuizinAja.User);
            // 
            // CreateAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dDateOfBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tFullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccForm";
            this.Text = "CreateAccForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tFullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tConfirmPassword;
        private System.Windows.Forms.DateTimePicker dDateOfBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}