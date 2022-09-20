using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitCorner_Class
{
    class Reminder
    {
        //Instance variable
        private int reminderID;
        private string reminderTime;
        private int reminderSetting;

        public int ReminderID { get => reminderID; set => reminderID = value; }
        public string ReminderTime { get => reminderTime; set => reminderTime = value; }
        public int ReminderSetting { get => reminderSetting; set => reminderSetting = value; }

        public static void settingReminder()
        {
            //Implement reminder setting here
        }
    }
}
