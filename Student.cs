using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class Student
    {
        private int numberGroup; //номер группы 
        private string lastName; //фамилия
        private string firtsName; //имя
        private string middleName; //отчество

        public Classroom clsRoom;

        public Student(int numberGroup, string lastName, string firtsName, string middleName)
        {
            NumberGroup = numberGroup;
            LastName = lastName;
            FirtsName = firtsName;
            MiddleName = middleName;
        }

        public int LandingRequest (Faculty fc)
        {            
            return fc.LandingAudience(this);
        } 

        public int NumberGroup { get => numberGroup; set => numberGroup = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirtsName { get => firtsName; set => firtsName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }

        public override string ToString()
        {
            string str = "Student: " + NumberGroup + " " + LastName + " " + FirtsName + " " + MiddleName;
            if (clsRoom == null)
            {
                str += " - audience is not allocated for the student";
            }
            else
            {
                str += " - audience allocated for the student - " + clsRoom.Audience;
            }
            return str;

        }
    }
}
