using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizinAja
{
    public partial class Form1 : Form
    {
        private QuizinAjaEntities db = new QuizinAjaEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tUsername.Text) && string.IsNullOrEmpty(tPassword.Text))
            {
                MessageBox.Show("Mohon Isi seluruh data terlebih dahulu");
                return;
            }

            var user = db.User.FirstOrDefault(x => x.Username == tUsername.Text && x.Password == tPassword.Text);

            if (user is null)
            {
                MessageBox.Show("Username Atau Password Salah!");
                return;
            }

            //Reuse.fullName = user.FullName;

            var main = new UserMainForm(user);
            main.FormClosed += (_, __) => Show();
            Hide();
            main.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cr = new CreateAccForm();
            cr.FormClosed += (_, __) => Show();

            Hide();

            cr.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var quiz = new QuizCodeForm();
            quiz.FormClosed += (_, __) => Show();
            Hide();
            quiz.Show();
        }
    }
}
