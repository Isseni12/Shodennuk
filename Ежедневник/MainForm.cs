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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Ежедневник
{
    public partial class MainForm : Form
    {
        //поля поточних даних і дати, яка відображається
        public TimeSpendJournal currentData;
        DateTime look;


        private string login;
        //конструктор, який ініціалізує стартові дані MainForm
        public MainForm(string login)
        {
            this.login = login;

            InitializeComponent();
            timer1.Start();
            currentData = new TimeSpendJournal();
            look = DateTime.Now;
            GDlabel.Text = GDlabel.Text + ", "  + login;
            
        }

        //виклик форми додавання
        private void addButton_Click(object sender, EventArgs e)
        {
            var x = new AddForm(this, -1);
            x.Show();
        }

        //виклик форми редагування
        private void rewriteButton_Click(object sender, EventArgs e)
        {

            try {

                //визначення індексу редагованого елемента
                int id = 0;
            foreach (var x in currentData.journal)
            {
                if (timetableListBox.SelectedItem.ToString() != x.ToString())
                    id++;
                else
                    break;
            }
            var y = new AddForm(this, id);
            y.Show(); }
            catch (Exception ex) {
                MessageBox.Show("Оберіть зі списку", "Помилка", MessageBoxButtons.OK);
            }
        }

        //видалення
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try {
                currentData.Remove(timetableListBox.SelectedItem.ToString());
                FillData();
            }
            catch (Exception ex) {
                MessageBox.Show("Оберіть зі списку", "Помилка", MessageBoxButtons.OK);
            }
        }

        //зміщення дня, що проглядаєтсья, на 1 назад
        private void leftButton_Click(object sender, EventArgs e)
        {
            look = look.AddDays(-1);
            FillData();
        }

        //зміщення дня, що проглядаєтсья, на 1 вперед
        private void rightButton_Click(object sender, EventArgs e)
        {
            look = look.AddDays(1);
            FillData();
        }

        //таймер викликає методи зсуву старих справ і визначення найближчого
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentData.Move();
            informationTextBox.Text = currentData.Nearest();
        }

        //завантаження файлу при запуску
        private void MainForm_Load(object sender, EventArgs e)
        {
            TimeSpendJournal temp = new TimeSpendJournal();
            try
            {
                //відкриття потоку і десеріалізація бінарного файлу
                FileStream fs = new FileStream(Environment.CurrentDirectory + @"\UserData\" + login + ".data", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                temp = (TimeSpendJournal)bf.Deserialize(fs);

                foreach (TimeSpending TimeSpending in temp.journal)
                {
                    if(TimeSpending.StartDate > look)
                    {
                        TimeSpending.ShowNotification();
                    }
                }

                fs.Close();
            }
            catch (SerializationException)
            {
                MessageBox.Show("Неправильний формат", "Помилка", MessageBoxButtons.OK);
            }
            //створення файлу в разі відсутності такого
            catch (FileNotFoundException)
            {
                using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\UserData\" + login + ".data", false)) { }
            }
            //заповнення даними форми
            currentData = temp;
            FillData();

        }

        //збереження при закритті програми
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = new FileStream(Environment.CurrentDirectory + @"\UserData\" + login + ".data", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                bf.Serialize(fs, currentData);
            }
            catch (Exception)
            {
                MessageBox.Show("Не вдалося зберегти", "Помилка", MessageBoxButtons.OK);
            }
            finally
            {
                fs.Close();
            }
        }

        //заповнення даними по даті, що переглядається
        public void FillData()
        {
            dateLabel.Text = look.Day + "/" + look.Month + "/" + look.Year;
            timetableListBox.Items.Clear();
            foreach (var x in currentData.journal)
            {
                if (x.StartDate.Day == look.Day && x.StartDate.Month == look.Month && x.StartDate.Year == look.Year)
                    timetableListBox.Items.Add(x.ToString());
            }
        }
        //повний показ інформації про подію
        private void timetableListBox_DoubleClick(object sender, EventArgs e)
        {
            var value = this.timetableListBox.SelectedItem;
            MessageBox.Show(value.ToString());
        }
        //перегляд за вибраною датою
        private void MainDateCalendar_ValueChanged(object sender, EventArgs e)
        {
            look = MainDateCalendar.Value;
            FillData();
        }
         // підключення кнопки інструкції
        private void buttonInctruction_Click(object sender, EventArgs e)
        {
            new Insruction().Show();
        }

    }
}
