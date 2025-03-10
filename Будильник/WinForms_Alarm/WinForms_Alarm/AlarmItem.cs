namespace WinForms_Alarm
{
    /// <summary>
    /// Класс, описывающий один будильник (часы, минуты, секунды).
    /// </summary>
    public class AlarmItem
    {
        public int Hour;
        public int Minute;
        public int Second;

        /// <summary>
        /// Конструктор с заданием времени будильника.
        /// </summary>
        public AlarmItem(int h, int m, int s)
        {
            Hour = h;
            Minute = m;
            Second = s;
        }

        /// <summary>
        /// Отображать время будильника в формате ЧЧ:ММ:СС.
        /// </summary>
        public override string ToString()
        {
            return $"{Hour:00}:{Minute:00}:{Second:00}";
        }
    }
}
