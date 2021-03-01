using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeItAll
{
    class Strumpan
    {
        public List<ThingToDo> ThingsToDo = new List<ThingToDo>();
        public int Age { get; set; }
        public string Idea { get; set; }
        public string Reflection { get; set; }
        public string Question { get; set; }

        public Strumpan(int age)
        {
            Age = age;
        }
    }
}
