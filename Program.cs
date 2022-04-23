using System;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stdOne = new Student(10321, "Iskov", "Andrey", "Olegovich");
            Console.WriteLine(stdOne);
            Classroom classOne = new Classroom("420A", 5);
            Console.WriteLine(classOne);
            classOne.std = stdOne;
            Console.WriteLine(classOne);
            Classroom classTwo = new Classroom("421B", 30);
            Console.WriteLine(classTwo);
            Console.WriteLine("--------------");
            Faculty facultyOne = new Faculty();
            Console.WriteLine(facultyOne);
            Console.WriteLine("--------------");
            Faculty facultyTwo = new Faculty("FMK");
            Console.WriteLine(facultyTwo);
            Console.WriteLine("------------------------");
            Faculty facultyThree = new Faculty("FTRU", classOne, classTwo);
            Console.WriteLine(facultyThree);
            Console.WriteLine("-----------------------");
            Faculty facultyFour = new Faculty("FP", "320N", "908K", "804R");
            Console.WriteLine(facultyFour);
            Console.WriteLine("-----------------------");
            Student stdTwo = new Student(10322, "Ivanov", "Ivan", "Ivanch");
            Console.WriteLine(stdTwo);
            Student stdThree = new Student(10323, "Petrov", "Oleg", "Alekseevich");
            Console.WriteLine(stdThree);
            Console.WriteLine();
            Console.WriteLine(stdOne.LandingRequest(facultyFour));
            Console.WriteLine("---------------------------------");
            /*Console.WriteLine($"student {stdOne.LastName + " " + stdOne.FirtsName} requests landing in the audience at the faculty {facultyThree.Name}");
            code_analysis(stdOne.LandingRequest(facultyThree));
            Console.WriteLine(facultyThree);*/
            //Console.WriteLine("---------------------------------");
            Console.WriteLine($"student {stdTwo.LastName + " " + stdOne.FirtsName} requests landing in the audience at the faculty {facultyThree.Name}");
            code_analysis(stdTwo.LandingRequest(facultyThree));
            Console.WriteLine(facultyThree);
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"student {stdTwo.LastName + " " + stdOne.FirtsName} requests landing in the audience at the faculty {facultyThree.Name}");
            code_analysis(stdTwo.LandingRequest(facultyThree));
            Console.WriteLine(facultyThree);
            /*Console.WriteLine("---------------------------------");
            Console.WriteLine($"student {stdThree.LastName + " " + stdOne.FirtsName} requests landing in the audience at the faculty {facultyThree.Name}");
            code_analysis(stdThree.LandingRequest(facultyThree));
            Console.WriteLine(facultyThree);*/
            Console.WriteLine(stdOne);
            Console.WriteLine(stdTwo);
            Console.WriteLine(stdThree);
        }

        static void code_analysis(int code)
        {// статический метод - показать результат запроса аудитории
            switch (code)
            {
                case -1: Console.WriteLine("denied. You already have an audidence."); break;
                case 0: Console.WriteLine("denied. No free audiences"); break;
                case 1: Console.WriteLine("received. You have a audience."); break;
            }
        }

    }
}
