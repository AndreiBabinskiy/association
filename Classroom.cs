using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class Classroom
    {
        private string audience;
        private int square;
        public Student std;

        public Classroom(string audience, int square)
        {
            Audience = audience;
            Square = square;
        }

        public string Audience { get => audience; set => audience = value; }
        public int Square { get => square; set => square = value; }

        public override string ToString()
        {
            string str = "Audience - " + Audience + "," + " Square - " + Square;
            if (std == null)
                str += " - audience is free";
            else
                str += " - busy student " + std.LastName + " " + std.FirtsName;
            return str;

        }
    }
}
