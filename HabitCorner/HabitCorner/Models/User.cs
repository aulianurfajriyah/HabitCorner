using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitCorner_Class
{
    class User
    {
        //Instance variable
        private int userID;
        private string userName;
        private string birthDate;

        //Property
        public int UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }

        public static void editData()
        {
            //Implement edit data here
        }
    }
}
