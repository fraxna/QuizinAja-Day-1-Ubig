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
    public partial class CreateAccForm : Form
    {
        private QuizinAjaEntities db = new QuizinAjaEntities();
        public CreateAccForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tUsername.Text) || string.IsNullOrEmpty(tFullname.Text)
               || string.IsNullOrEmpty(tConfirmPassword.Text) || string.IsNullOrEmpty(tPassword.Text))
            {
                MessageBox.Show("Mohon Isi Seluruh Data Terlebih Dahulu");
                return;
            }
            
            if(tPassword.Text != tConfirmPassword.Text)
            {
                MessageBox.Show("Password tidak sama, coba lagi!");
                return;
            }

            if(db.User.Any(x => x.Username == tUsername.Text))
            {
                MessageBox.Show("Username telah digunakan");
                return;
            }

            db.User.Add(new User()
            {
                Username = tUsername.Text,
                FullName = tFullname.Text,
                DateOfBirth = dDateOfBirth.Value,
                Password = tPassword.Text
            });

            db.SaveChanges();

            this.Close();
        }
    }
}
