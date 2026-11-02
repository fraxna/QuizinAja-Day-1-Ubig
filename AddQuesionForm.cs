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
        private BindingList<Question> questions = new BindingList<Question>();
        public AddQuesionForm()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
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
    }
}
