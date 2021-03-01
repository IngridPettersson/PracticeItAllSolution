using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeItAll
{
    public class ThingToDo
    {
        public string Todo { get; set; }
        public int Resistance { get; set; }
        public ThingToDo(string todo, int resistance)
        {
            Todo = todo;
            Resistance = resistance;
        }
    }
}
