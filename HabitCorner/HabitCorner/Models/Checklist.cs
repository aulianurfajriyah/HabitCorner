using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitCorner_Class
{
    class Checklist
    {
        //Instance variable
        private int checklistID;
        private bool checklistStatus;
        private bool birthDate;

        public int ChecklistID { get => checklistID; set => checklistID = value; }
        public bool ChecklistStatus { get => checklistStatus; set => checklistStatus = value; }
        public bool BirthDate { get => birthDate; set => birthDate = value; }

        public static void checkChecklist()
        {
            //Implement checklist check here
        }
    }
}
