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
    public partial class QuizCodeForm : Form
    {
        private QuizinAjaEntities db = new QuizinAjaEntities();
        public QuizCodeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var quiz = db.Quiz.FirstOrDefault(x => x.Code == tCode.Text);

            if(quiz is null)
            {
                MessageBox.Show("Code tidak valid, coba lagi!");
                return;
            }

            string nama = tnickName.Text;

            if (nama.Length < 3)
            {
                MessageBox.Show("Nama tidak boleh kurang dari 3 huruf, coba lagi");
                return;
            }

            var quizF = new QuizForm(quiz, nama);
            quizF.FormClosed += (_, __) => Show();
            Hide();
            quizF.Show();
        }
    }
}
