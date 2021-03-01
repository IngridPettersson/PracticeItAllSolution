using System;
using System.Linq;

namespace PracticeItAll
{
    class Program
    {
        static void Main(string[] args)
        {
            Strumpan strumpan1 = new Strumpan(33);

            strumpan1.Reflection = "Things are getting wild";

            strumpan1.ThingsToDo.Add(new ThingToDo("Practice for test - again", 1));
            strumpan1.ThingsToDo.Add(new ThingToDo("Stop fasting", 3));

            Console.WriteLine($"Number of things in Strumpans todo-list: {strumpan1.ThingsToDo.Count}\n");

            int totalResistance = CalcTotalResistance(strumpan1);
            PrintTotalResistance(totalResistance);
            
        }

        static void PrintTotalResistance(int totalResistance)
        {
            Console.WriteLine($"The total built up resistance for Strumpan right now, for all her todos: {totalResistance}\n");
        }

        static int CalcTotalResistance(Strumpan strumpan)
        {
            return strumpan.ThingsToDo.Sum(x => x.Resistance);
        }
    }
}
