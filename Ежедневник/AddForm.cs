using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Ежедневник
{
    public partial class AddForm : Form
    {
        //поля посилання на головну форму і айді елемента
        MainForm main;
        int id;

        public AddForm(MainForm main, int id)
        {
            InitializeComponent();
            this.main = main;
            this.id = id;
            freq.Text = "0";
            //заповнення полів, якщо ми відкрили на редагування
            if (id != -1)
            {
                DateTime startDate = main.currentData.journal[id].StartDate;
                DateTime endDate = main.currentData.journal[id].EndDate;

                durationHour.Value = Convert.ToInt32((endDate - startDate).ToString("hh"));
                durationMin.Value = Convert.ToInt32((endDate - startDate).ToString("mm"));
                adress.Text = main.currentData.journal[id].Address;
                freq.Text = main.currentData.journal[id].Freq.ToString();
                hourLabel.Value = startDate.Hour;
                minuteLabel.Value = startDate.Minute;
                dateCalendar.Value = startDate;
                ActionField.Text  = main.currentData.journal[id].ActionText;
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime startDate = dateCalendar.Value;
                DateTime endDate = dateCalendar.Value;

                //якщо id == -1 відбувається додавання нової події
                if (id == -1)
                {
                    startDate = startDate.AddHours(Convert.ToDouble(hourLabel.Value) - startDate.Hour);
                    startDate = startDate.AddMinutes(Convert.ToDouble(minuteLabel.Value) - startDate.Minute);

                    endDate = endDate.AddHours(Convert.ToDouble(durationHour.Value) + startDate.Hour - endDate.Hour);
                    endDate = endDate.AddMinutes(Convert.ToDouble(durationMin.Value) + startDate.Minute - endDate.Minute);

                    TimeSpending TimeSpending = new TimeSpending(startDate, endDate, adress.Text, Convert.ToInt32(freq.Text), ActionField.Text);
                    TimeSpending.ShowNotification();
                    main.currentData.Add(TimeSpending);
                    
                    //виведення нагадування                                                                                                                                                   
                    //WaitSomeTime(ActionField.Text);
                }
                //інакше редагуються дані
                else
                {
                    startDate = startDate.AddHours(Convert.ToDouble(hourLabel.Value) - startDate.Hour);
                    startDate = startDate.AddMinutes(Convert.ToDouble(minuteLabel.Value) - startDate.Minute);

                    endDate = endDate.AddHours(Convert.ToDouble(durationHour.Value) + startDate.Hour - endDate.Hour);
                    endDate = endDate.AddMinutes(Convert.ToDouble(durationMin.Value) + startDate.Minute - endDate.Minute);

                    main.currentData.journal[id].Change(startDate, endDate, adress.Text, Convert.ToInt32(freq.Text), ActionField.Text);

                    main.currentData.Sort();
                }

                main.FillData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильні дані, спробуйте знову", "Помилка", MessageBoxButtons.OK);
            }
        }
        //очікування перед нагадуванням
        public async void WaitSomeTime(string title)
        {
            await Task.Delay(5000);
            PopupNotifier popupNotifier = new PopupNotifier();
            popupNotifier.TitleText = title;
            popupNotifier.Popup();
        }
    }
}
