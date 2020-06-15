using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ежедневник
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBoxPasswod.AutoSize = false;
            textBoxPasswod.Size = new Size(textBoxPasswod.Size.Width, 41);
            textBoxPasswod.PasswordChar = '*';
        }
        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxPasswod.Focus();
        }
        private void textBoxPasswod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OkButton_Click(sender, new EventArgs());
        }
        //очищення поля логіну та паролю
        private void CancelButton_Click(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxPasswod.Clear();
        }
        //перехід до форми реєстрації
        private void toRegistationForm_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            Visible = false;
        }
        //перевіряємо чи існує користувач з таким логіном
        private void OkButton_Click(object sender, EventArgs e)
        {   
            Encoding enc = Encoding.GetEncoding(1251);
            StreamReader sr;
            if (File.Exists("Users.txt"))
                sr = new StreamReader("Users.txt", enc);
            else
            {
                MessageBox.Show("Такого користувача не існує");
                textBoxLogin.Clear();
                textBoxPasswod.Clear();
                textBoxLogin.Focus();
                return;
            }
            bool fl = false;
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split('#');
                if (s[0] == textBoxLogin.Text && s[1] == textBoxPasswod.Text)
                {
                    fl = true;
                    break;
                }
            }
            //якщо існує відкриваємо MainForm
            sr.Close();
            if (fl) {
                new MainForm(textBoxLogin.Text).Show();
                Visible = false;
            }
            //якшо ні то це помилка
            else
            {
                MessageBox.Show("Такого користувача не існує");
                textBoxLogin.Clear();
                textBoxPasswod.Clear();
                textBoxLogin.Focus();
                return;

            }
        }
    }
}
