using System;

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
            Console.WriteLine(strumpan1.ThingsToDo.Count);

            CalcTotalResistance();
            
        }

        static void CalcTotalResistance()
        {

        }
    }
}
