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
    public partial class AddQuesionForm : Form
    {
        private QuizinAjaEntities db = new QuizinAjaEntities();
        private BindingList<Question> questions = new BindingList<Question>();
        private readonly User user;
        public AddQuesionForm(User user)
        {
            InitializeComponent();
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            this.user = user;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == delete.Index) e.Value = "Delete";
        }

        private void AddQuesionForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = questions;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(rQuesion.Text) || 
                string.IsNullOrEmpty(tA.Text) ||
                string.IsNullOrEmpty(tB.Text) ||
                string.IsNullOrEmpty(tC.Text) ||
                string.IsNullOrEmpty(tD.Text))
            {
                MessageBox.Show("Mohon isi seluruh data terlebih dahulu");
                return;
            }
            string corectQuest;

            if(rA.Checked)
            {
                corectQuest = tA.Text;
            }
            else if(rB.Checked)
            {
                corectQuest = tB.Text;
            }
            else if(rC.Checked)
            {
                corectQuest = tC.Text;
            }
            else
            {
                corectQuest = tD.Text;
            }

            questions.Add(new Question()
            {
                Question1 = rQuesion.Text,
                CorrectAnswer = corectQuest,
                OptionA = tA.Text,
                OptionB = tB.Text,
                OptionC = tC.Text,
                OptionD = tD.Text,
            });

            OnLoad(EventArgs.Empty);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Question q)
            {
                questions.Remove(q);
                OnLoad(EventArgs.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string quizName = tquizName.Text;
            string quizCode = tQuizCode.Text;
            string quizDesc = tquizName.Text;

            if(questions.Count < 1)
            {
                MessageBox.Show("Minimal ada 1 soal sebelum membuat quiz");
                return;
            }

            if(!tQuizCode.Text.Any(x => char.IsDigit(x) ||
                tQuizCode.Text.Any(y => char.IsLower(y))))
            {
                MessageBox.Show("Code harus menggunakan huruf besar dengan kombinasi angka");
                return;
            }

            if(db.Quiz.Any(x => x.Code == quizCode))
            {
                MessageBox.Show("Code duplikat, coba lagi");
                return;
            }

            var quiz = db.Quiz.Add(new Quiz()
            {
                UserID = user.ID,
                Name = quizName,
                Code = quizCode,
                Description = quizDesc,
                CreatedAt = DateTime.Now
            });

            db.Quiz.Add(quiz);

            foreach(var quest in questions)
            {
                quest.QuizID = quiz.ID;
                db.Question.Add(quest);
            }

            db.SaveChanges();

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
