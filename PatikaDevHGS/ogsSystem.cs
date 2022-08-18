using System;
using System.Collections.Generic;
using System.Text;

namespace PatikaDevHGS
{
    
    public class ogsSystem
    {
        int dailyEarning;

        public void earning(Int64 althgsNumber)
        {
            if(althgsNumber == 1111111111)
            {
                dailyEarning += 50;
            }
       
            else if (althgsNumber == 2222222222)
            {
                dailyEarning += 100;
            }
            else if ( althgsNumber == 3333333333)
            {
                dailyEarning += 160;
            }
        }
        public void listEarning()
        {
            Console.WriteLine("günlük kazanç: " + dailyEarning);
        }
        
        }



}

