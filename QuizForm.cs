using QuizinAja;
using System;
using System.CodeDom;
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
    public partial class QuizForm : Form
    {
        private readonly Quiz quiz;
        private readonly string nickName;
        public List<QuizUc> questionsUc = new List<QuizUc>();

        private int _currentIndex = 0;

        private int currentIndex
        {
            get => _currentIndex;
            set
            {
                if (value < 0 || value >= questionsUc.Count) return;

                _currentIndex = value;

                panel2.Controls.Clear();
                var questionUc = questionsUc[value];
                panel2.Controls.Add(questionUc);
            }
        }

        public QuizForm(Quiz quiz, string nickName)
        {
            InitializeComponent();
            this.quiz = quiz;
            this.nickName = nickName;
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            lSesion.Text = nickName;

            foreach(var question in quiz.Question)
            {
                questionsUc.Add(new QuizUc(question));
            }

            int questionCount = quiz.Question.Count();
            var question1 = quiz.Question.ToList();

            for (int i = 0; i < questionCount; i++)
            {
                var button = new Button();

                int index = i;

                button.Click += (_,__) =>
                {
                    currentIndex = index;
                };

                button.Size = new Size(50,50);

                button.Text = (i + 1).ToString();

                flowLayoutPanel1.Controls.Add(button);
            }

            currentIndex = 0;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentIndex--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex++;
        }
    }
}
