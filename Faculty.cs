using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class Faculty
    {
        private string name;
        private Classroom[] classrooms;

        public string Name { get => name; set => name = value; }

        public Faculty()
        {
            Name = "Noname";
            classrooms = new Classroom[1];
            classrooms[0] = new Classroom("simple", 10);    // композиция
        }
        public Faculty(string name) : this(name, "simple")
        {
            //Name = name;
            //classrooms = new Classroom[1];
            //classrooms[0] = new Classroom("simple", 10);
        }

        public Faculty(string name, params Classroom[] classrooms) : this(name)
        {
            this.classrooms = classrooms;   //агрегация
        }
        public Faculty(string name, params string[] classromNames)
        {
            Name = name;
            classrooms = new Classroom[classromNames.Count()];
            for (int i = 0; i < classromNames.Count(); i++)
            {
                classrooms[i] = new Classroom(classromNames[i], 20);//композиция
            }
        }

        public int LandingAudience (Student stud)
        {
            // 0 - нет свободных аудиторий
            // 1 - аудитория выделена
            // -1 - аудитория уже выделена этому студенту

            for (int i = 0; i < classrooms.Count(); i++)
            {
                if (classrooms[i]?.std?.LastName == stud.LastName + stud.FirtsName)
                {
                    return -1;
                }
            }
            for (int i = 0; i < classrooms.Count(); i++)
            {
                if (classrooms[i].std == null)
                {
                    classrooms[i].std = stud;
                    stud.clsRoom = classrooms[i];
                    return 1;
                }

            }
            return 0;

        }

        public override string ToString()
        {
            string str = "Faculty - " + Name + ", Classroom - " + classrooms.Count() + "\n";
            for (int i = 0; i < classrooms.Count(); i++)
            {
                str += classrooms[i].ToString() + "\n";

            }
            return str;
        }


    }
}
