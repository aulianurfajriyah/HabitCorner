using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitCorner_Class
{
    class Checklist : Habit
    {
        //Instance variable
        private int checklistID;
        private bool checklistStatus;
        private bool birthDate;
        private static int habitID;
        private static string habitName;

        public int ChecklistID { get => checklistID; set => checklistID = value; }
        public bool ChecklistStatus { get => checklistStatus; set => checklistStatus = value; }
        public bool BirthDate { get => birthDate; set => birthDate = value; }

        public Checklist (int checklistID, bool checklistStatus, bool birthDate) : base(habitID, habitName)
        {
            //Implement Checklist here
        }

        public static void checkChecklist()
        {
            //Implement checklist check here
        }
    }
}
