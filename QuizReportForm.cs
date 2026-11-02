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
    public partial class QuizReportForm : Form
    {
        private QuizinAjaEntities db = new QuizinAjaEntities();

        private readonly User user;

        public QuizReportForm(User user)
        {
            InitializeComponent();
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            this.user = user;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Participant p)
            {
                //if(e.ColumnIndex == timeTakenDataGridViewTextBoxColumn.Index)e.Value = p.TimeTaken.ToString("")
            }
        }

        private void QuizReportForm_Load(object sender, EventArgs e)
        {
            quizBindingSource.DataSource = db.Quiz.Where(x => x.UserID == user.ID).ToList();
            renderData();
        }

        private void cQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderData();
        }

        private void renderData()
        {
            int id = Convert.ToInt32(cQuiz.SelectedValue);
            participantBindingSource.DataSource = db.Participant.Where(x => x.QuizID == id).ToList();
        }
    }
}
