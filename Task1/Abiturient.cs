using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Abiturient
    {
        private string FullName;
        private int Class;
        private double AVG;

        public string FullName1 { get => FullName; set => FullName = value; }
        public int Class1 
        { 
            get => Class;
            set
            {
                if (value == 11)
                    Class = value;
            } 
        }
        public double AVG1 { get => AVG; set => AVG = value; }

        public Abiturient(string FullName, int Class, double Avg)
        {
            this.FullName1 = FullName;
            this.Class1 = Class;
            this.AVG1 = AVG1;
        }

        public void Output()
        {
            Console.WriteLine($"ФИО: {FullName1} Класс: {Class1} Среднйи балл: {AVG1}");
        }

        internal Abiturient(string FullName, int Class, int AVG)
        {
            Console.WriteLine($" {FullName} {Class} {AVG}");
        }
        public void Print()
        {
            Console.WriteLine($" {FullName} {Class1 > 9}");

        }



    }
}
