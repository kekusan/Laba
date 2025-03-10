/********************************************************
 * MainForm.cs
 * 
 * Основная логика работы будильника.
 * Включает:
 * - Настройку и хранение пути к выбранной музыке
 * - Запуск/остановку будильника
 * - Обработку нажатий кнопок инкремента/декремента
 * - Воспроизведение выбранной музыки (как тест, так и при срабатывании)
 * - Диалог при срабатывании ("Отключить" или "Отложить на 5 минут")
 * - Список запланированных будильников, с возможностью удаления
 *
 *******************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace WinForms_Alarm
{
    public partial class MainForm : Form
    {
        /*
           Переменные-состояния будильника и музыки:
           Music = 1 означает, что музыка играет.
           Music = 0 означает, что музыка не играет.
        */
        private int Music = 0;

        /*
           Часы, минуты, секунды, введённые пользователем
           (то, на какое время будет установлен будильник)
        */
        private string Hour = "";
        private string Minutes = "";
        private string Seconds = "";

        /*
           Текущее системное время (часы, минуты, секунды)
           в формате строк
        */
        private string HourNow = "";
        private string MinutesNow = "";
        private string SecondsNow = "";

        /*
           Объект Windows Media Player для воспроизведения mp3
        */
        private WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

        /*
           Список всех запланированных будильников.
        */
        private List<AlarmItem> alarms = new List<AlarmItem>();

        /*
           Храним здесь "последнее обработанное время" (ЧЧММСС),
           чтобы не вызвать повторный диалог за один и тот же System Time
        */
        private string lastAlarmCheckTime = "";

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие загрузки формы.
        /// Здесь восстанавливаем путь к музыке из настроек
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            string hh = h < 10 ? "0" + h : h.ToString();
            string mm = m < 10 ? "0" + m : m.ToString();
            string ss = s < 10 ? "0" + s : s.ToString();

            textBoxHours.Text = hh;
            textBoxMinutes.Text = mm;
            textBoxSeconds.Text = ss;

            string savedPath = Properties.Settings.Default.MusicPath;
            if (!string.IsNullOrEmpty(savedPath) && File.Exists(savedPath))
            {
                UpdateMusicPath(savedPath);
            }
            else
            {
                labelCurrentMusic.Text = "Музыка не выбрана";
            }
        }

        /// <summary>
        /// Обновляет метку, показывающую путь к текущей музыке.
        /// </summary>
        private void UpdateMusicPath(string fullPath)
        {
            if (string.IsNullOrEmpty(fullPath))
            {
                labelCurrentMusic.Text = "Музыка не выбрана";
                return;
            }

            string shortName = Path.GetFileName(fullPath);
            if (shortName.Length > 28)
            {
                shortName = shortName.Substring(0, 28) + "...";
            }

            labelCurrentMusic.Text = $"Текущая музыка: {shortName}";
        }

        /********************************************************
         * Обработка инкремента/декремента для Часов, Минут, Секунд
         ********************************************************/
        private void btnIncrementHours_Click(object sender, EventArgs e)
        {
            int h = int.Parse(textBoxHours.Text);
            h = (h + 1) % 24;
            textBoxHours.Text = h < 10 ? "0" + h : h.ToString();
        }

        private void btnDecrementHours_Click(object sender, EventArgs e)
        {
            int h = int.Parse(textBoxHours.Text);
            h = (h - 1) < 0 ? 23 : (h - 1);
            textBoxHours.Text = h < 10 ? "0" + h : h.ToString();
        }

        private void btnIncrementMinutes_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBoxMinutes.Text);
            m = (m + 1) % 60;
            textBoxMinutes.Text = m < 10 ? "0" + m : m.ToString();
        }

        private void btnDecrementMinutes_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBoxMinutes.Text);
            m = (m - 1) < 0 ? 59 : (m - 1);
            textBoxMinutes.Text = m < 10 ? "0" + m : m.ToString();
        }

        private void btnIncrementSeconds_Click(object sender, EventArgs e)
        {
            int s = int.Parse(textBoxSeconds.Text);
            s = (s + 1) % 60;
            textBoxSeconds.Text = s < 10 ? "0" + s : s.ToString();
        }

        private void btnDecrementSeconds_Click(object sender, EventArgs e)
        {
            int s = int.Parse(textBoxSeconds.Text);
            s = (s - 1) < 0 ? 59 : (s - 1);
            textBoxSeconds.Text = s < 10 ? "0" + s : s.ToString();
        }

        /********************************************************
         * Обработчики полей ввода (Ч, М, С)
         ********************************************************/
        private void textBoxHours_Leave(object sender, EventArgs e)
        {
            if (textBoxHours.Text.Length == 1)
            {
                textBoxHours.Text = "0" + textBoxHours.Text;
            }
        }

        private void textBoxMinutes_Leave(object sender, EventArgs e)
        {
            if (textBoxMinutes.Text.Length == 1)
            {
                textBoxMinutes.Text = "0" + textBoxMinutes.Text;
            }
        }

        private void textBoxSeconds_Leave(object sender, EventArgs e)
        {
            if (textBoxSeconds.Text.Length == 1)
            {
                textBoxSeconds.Text = "0" + textBoxSeconds.Text;
            }
        }

        private void textBoxHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            if (!char.IsDigit(e.KeyChar) || textBoxHours.Text.Length >= 2)
            {
                e.Handled = true;
            }
        }

        private void textBoxMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            if (!char.IsDigit(e.KeyChar) || textBoxMinutes.Text.Length >= 2)
            {
                e.Handled = true;
            }
        }

        private void textBoxSeconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            if (!char.IsDigit(e.KeyChar) || textBoxSeconds.Text.Length >= 2)
            {
                e.Handled = true;
            }
        }

        /********************************************************
         * Главное меню (Файл: Выбрать музыку, Прослушать, Выход;
         *               Справка: О программе)
         ********************************************************/
        private void chooseMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Music == 1)
            {
                wplayer.controls.stop();
                Music = 0;
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                string extension = Path.GetExtension(file);

                if (!extension.Equals(".mp3", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Выберите mp3 файл!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Properties.Settings.Default.MusicPath = file;
                Properties.Settings.Default.Save();

                UpdateMusicPath(file);
                MessageBox.Show("Музыка успешно выбрана и сохранена!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void previewMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentPath = Properties.Settings.Default.MusicPath;

            if (string.IsNullOrEmpty(currentPath) || !File.Exists(currentPath))
            {
                MessageBox.Show("Музыка не выбрана или файл недоступен!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Music == 0)
            {
                wplayer.URL = currentPath;
                wplayer.controls.play();
                Music = 1;
                previewMusicToolStripMenuItem.Text = "Остановить прослушивание";
            }
            else
            {
                wplayer.controls.stop();
                Music = 0;
                previewMusicToolStripMenuItem.Text = "Прослушать музыку";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Будильник (WinForms)\n\n" +
                "Версия: 1.0.0\n" +
                "Разработчик: Ваше_Имя\n\n" +
                "Данный будильник позволяет:\n" +
                "- Установить время срабатывания\n" +
                "- Выбрать и сохранить MP3-файл\n" +
                "- Прослушать выбранную мелодию\n" +
                "- Запланировать несколько будильников\n" +
                "- При срабатывании будильника: отключить или перенести на 5 минут\n" +
                "- Работает даже после перезапуска, т.к. путь к музыке сохраняется",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /********************************************************
         * Логика добавления/удаления будильников
         ********************************************************/
        private void buttonAddAlarm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxHours.Text) ||
                string.IsNullOrWhiteSpace(textBoxMinutes.Text) ||
                string.IsNullOrWhiteSpace(textBoxSeconds.Text))
            {
                MessageBox.Show("Укажите часы, минуты и секунды!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int h = int.Parse(textBoxHours.Text);
            int m = int.Parse(textBoxMinutes.Text);
            int s = int.Parse(textBoxSeconds.Text);

            if (h > 23)
            {
                MessageBox.Show("Часы не могут превышать 23!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (m > 59 || s > 59)
            {
                MessageBox.Show("Минуты и секунды не могут превышать 59!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newAlarm = new AlarmItem(h, m, s);
            alarms.Add(newAlarm);
            listBoxAlarms.Items.Add(newAlarm);
            MessageBox.Show("Будильник добавлен в список!", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRemoveAlarm_Click(object sender, EventArgs e)
        {
            if (listBoxAlarms.SelectedIndex >= 0)
            {
                int idx = listBoxAlarms.SelectedIndex;
                alarms.RemoveAt(idx);
                listBoxAlarms.Items.RemoveAt(idx);
                MessageBox.Show("Будильник удалён!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите будильник для удаления!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /********************************************************
         * Логика запуска/остановки будильника (кнопка "Запустить")
         ********************************************************/
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text == "Стоп")
            {
                timer1.Stop();
                textBoxHours.ReadOnly = false;
                textBoxMinutes.ReadOnly = false;
                textBoxSeconds.ReadOnly = false;
                buttonStart.Text = "Запустить";

                if (Music == 1)
                {
                    wplayer.controls.stop();
                    Music = 0;
                    previewMusicToolStripMenuItem.Text = "Прослушать музыку";
                }
                return;
            }

            if (alarms.Count == 0)
            {
                MessageBox.Show("Список будильников пуст! Сначала добавьте будильник.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxHours.ReadOnly = true;
            textBoxMinutes.ReadOnly = true;
            textBoxSeconds.ReadOnly = true;

            buttonStart.Text = "Стоп";
            timer1.Start();
        }

        /// <summary>
        /// Срабатывает каждые 500 мс, проверяет текущее время
        /// и сравнивает с каждым будильником из списка.
        /// Если время совпало, запускаем диалог.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            HourNow = h < 10 ? "0" + h : h.ToString();
            MinutesNow = m < 10 ? "0" + m : m.ToString();
            SecondsNow = s < 10 ? "0" + s : s.ToString();
            // Собираем текущее время в "ЧЧММСС"
            string currentTime = HourNow + MinutesNow + SecondsNow;
            // Если уже обрабатывали это время (за ту же секунду), выходим
            if (currentTime == lastAlarmCheckTime)
            {
                return;
            }
            // Иначе запоминаем, что это время мы уже обрабатываем
            lastAlarmCheckTime = currentTime;
            // Далее перебираем все будильники
            for (int i = 0; i < alarms.Count; i++)
            {
                var alarm = alarms[i];

                string ah = alarm.Hour < 10 ? "0" + alarm.Hour : alarm.Hour.ToString();
                string am = alarm.Minute < 10 ? "0" + alarm.Minute : alarm.Minute.ToString();
                string asx = alarm.Second < 10 ? "0" + alarm.Second : alarm.Second.ToString();

                if (ah == HourNow && am == MinutesNow && asx == SecondsNow)
                {
                    if (Music == 0)
                    {
                        wplayer.URL = Properties.Settings.Default.MusicPath;
                        wplayer.controls.play();
                        Music = 1;
                        previewMusicToolStripMenuItem.Text = "Остановить прослушивание";
                    }

                    DialogResult dr = MessageBox.Show(
                        "Будильник сработал!\n\nДа - Отключить\nНет - Отложить на 5 минут",
                        "Сработка будильника",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    wplayer.controls.stop();
                    Music = 0;
                    previewMusicToolStripMenuItem.Text = "Прослушать музыку";

                    if (dr == DialogResult.Yes)
                    {
                        alarms.RemoveAt(i);
                        listBoxAlarms.Items.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        DateTime dt = DateTime.Now.AddMinutes(5);
                        alarm.Hour = dt.Hour;
                        alarm.Minute = dt.Minute;
                        alarm.Second = dt.Second;
                        listBoxAlarms.Items[i] = alarm;
                    }
                    break;
                }
            }
        }
    }
}
