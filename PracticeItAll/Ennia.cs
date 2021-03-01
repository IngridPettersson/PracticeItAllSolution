using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeItAll
{

    class Ennia
    {
    private bool hasAPhase;

    public bool HasAPhase
    {
        get { return hasAPhase; }
        set
            {
                if (hasAPhase)
                {
                    Console.Write("Please verify this condition [y/n]: ");
                    if (ConsoleKey.Y == Console.ReadKey(true).Key)
                    
                    {
                        hasAPhase = value;
                    }
                    else
                    {
                        hasAPhase = false;
                    }
                }
                hasAPhase = value;
            }
    }
        public Ennia(bool hasAPhase)
        {

        }
    }
}
