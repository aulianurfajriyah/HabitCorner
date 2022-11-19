using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitCorner_Class
{
    class Habit
    {
        //Instance variable
        private int habitID;
        private string habitName;
        private string habitStart;
        private string habitPeriode;
        private string habitDeadline;



        public int HabitID { get => habitID; set => habitID = value; }
        public string HabitName { get => habitName; set => habitName = value; }
        public string HabitStart { get => habitStart; set => habitStart = value; }
        public string HabitPeriode { get => habitPeriode; set => habitPeriode = value; }
        public string HabitDeadline { get => habitDeadline; set => habitDeadline = value; }

        public Habit(int habitID, string habitName)
        {
            HabitID = habitID;
            HabitName = habitName;
        }

        public static void CreateHabit()
        {
            //Implement create habit here
        }

        public static void UpdateHabit()
        {
            //Implement update habit here
        }

        public static void DeleteHabit()
        {
            //Implement delete habit here
        }

    }
}
