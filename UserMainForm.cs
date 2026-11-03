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
    public partial class UserMainForm : Form
    {
        private QuizinAjaEntities db = new QuizinAjaEntities();
        private readonly User user;
        public UserMainForm(User user)
        {
            InitializeComponent();

            dataGridView1.CellFormatting += DataGridView1_CellFormatting;

            this.user = user;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Quiz q)
            {
                if (e.ColumnIndex == delete.Index) e.Value = "Delete";

                if (e.ColumnIndex == Question.Index) e.Value = q.Question.Count().ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var report = new QuizReportForm(user);
            report.FormClosed += (_, __) => Show();
            Hide();
            report.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addQ = new AddQuesionForm(user);
            addQ.FormClosed += (_, __) => Show();
            Hide();
            addQ.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Quiz q)
                {
                    if (e.ColumnIndex == delete.Index)
                    {
                        DialogResult result = MessageBox.Show("Apakah Anda Yakin Menghapus Quiz ini ?", "Hapus",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            db.Quiz.Remove(q);
                            db.SaveChanges();
                        }

                        OnLoad(EventArgs.Empty);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error di : {ex}");
            }
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            quizBindingSource.DataSource = db.Quiz.Where(x => x.UserID == user.ID).ToList();
            lSesion.Text = user.FullName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
