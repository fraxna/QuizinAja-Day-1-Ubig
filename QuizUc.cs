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
    public partial class QuizUc : UserControl
    {
        private Question question;
        public QuizUc(Question question)
        {
            InitializeComponent();
            this.question = question;
        }

        private void QuizUc_Load(object sender, EventArgs e)
        {
            soal.Text = question.Question1;
            rA.Text = question.OptionA;
            rB.Text = question.OptionB;
            rC.Text = question.OptionC;
            rD.Text = question.OptionD;
        }
    }
}
