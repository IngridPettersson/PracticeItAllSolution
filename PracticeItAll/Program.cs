using System;
using System.Linq;

namespace PracticeItAll
{
    class Program
    {
            public static Strumpan strumpan1 = new Strumpan(33);
            public SoroushTheBaba soroush1 = new SoroushTheBaba("happy1");
        static void Main(string[] args)
        {

            strumpan1.Reflection = "Things are getting wild";
            strumpan1.Question = "Should I - or should I not - have cheese and parsley now?";

            strumpan1.ThingsToDo.Add(new ThingToDo("Practice for test - again", 1));
            strumpan1.ThingsToDo.Add(new ThingToDo("Stop fasting", 3));
            strumpan1.ThingsToDo.Add(new ThingToDo("Sleep", 1));

            Console.WriteLine($"Number of things in Strumpans todo-list: {strumpan1.ThingsToDo.Count}\n");

            int totalResistance = CalcTotalResistance(strumpan1);
            PrintTotalResistance(totalResistance);
            int maxResistance = CalcMaxResistance();
            //CalcMaxResistanceLinq();
            PrintMaxResistance(maxResistance);
        }

        private static void PrintMaxResistance(int maxRes)
        {
            Console.WriteLine($"Max resistance in Strumpans todo-list: {maxRes}");
        }

        private static void CalcMaxResistanceLinq()
        {
            throw new NotImplementedException();
        }

        private static int CalcMaxResistance()
        {
            int maxIndex = strumpan1.ThingsToDo.Count - 1;
            for (int i = maxIndex - 1; i >= 0 ; i--)
            {
                if (strumpan1.ThingsToDo[i].Resistance > maxIndex)
                {
                    maxIndex = strumpan1.ThingsToDo[i].Resistance;
                }
            }
            return maxIndex;
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
