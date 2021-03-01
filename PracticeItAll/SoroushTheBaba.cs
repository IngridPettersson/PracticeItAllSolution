using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeItAll
{
    class SoroushTheBaba
    {
        private string mood;

        public string Mood
        {
            get { return $"The mood of todays is: {mood}"; }
            set { mood = value; }
        }


        public string MyProperty { get; set; }
        public SoroushTheBaba(string mood)
        {
            Mood = mood;
        }
    }
}
