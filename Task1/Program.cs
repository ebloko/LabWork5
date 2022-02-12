using System;

namespace Task1
{
   
    class Program
    {   
        static void Main(string[] args)
        {
            Abiturient Name = new Abiturient("Петр Петров Петров", 9, 4.5);
            Abiturient Name1 = new Abiturient("Иван Иванов Иванович", 11, 5);
            Abiturient Name2 = new Abiturient("Сергей Иванов Янович", 9, 5);
            Abiturient Name3 = new Abiturient("Владимир Иванов Янович", 9, 5);
            Abiturient Name4 = new Abiturient("Ян Иванов Янович", 11, 5);
            Abiturient Name5 = new Abiturient("Ян Иванов Янович", 11, 5);
            Abiturient Name6 = new Abiturient("Ян Иванов Янович", 11, 5);

            Abiturient.Output();
            Name1.Print();
            
        }

    }
}
