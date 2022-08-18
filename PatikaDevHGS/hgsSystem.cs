using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace PatikaDevHGS
{
    public class hgsSystem
    {


        int carFee = 50, vanFee = 100, busFee = 160;
       public int newCarBudget = 1200, newVanBudget = 3000, newBusBudget = 1800;
        ArrayList hgsArray = new ArrayList(); 
        
        public void hgsPay(Int64 althgsNumber)
        {
            Vehicle Car1 = new Vehicle();
            Vehicle Van1 = new Vehicle();
            Vehicle Bus1 = new Vehicle();
            Car1.budget = newCarBudget;
            Van1.budget = newVanBudget;
            Bus1.budget = newBusBudget;
            if (althgsNumber == 1111111111 && Car1.budget > 0)
            {
                
                Console.WriteLine("The Type Is Car");
                Console.WriteLine("Pass Fee is: " + carFee+"TL");
                newCarBudget -= carFee;
                Car1.budget = newCarBudget;

                Console.WriteLine("Gecis Yaptigi Tarih Ve Saat: "+ DateTime.Now);
                Console.WriteLine("New Budget: " + Car1.budget);
                
            }
            else if(althgsNumber == 2222222222 && Van1.budget > 0)
            {
                
                Console.WriteLine("The Type Is Van");
                Console.WriteLine("Pass Fee is: " + vanFee + "TL");
                newVanBudget -= vanFee;
                Van1.budget = newVanBudget;
                Console.WriteLine("Gecis Yaptigi Tarih Ve Saat: " + DateTime.Now);
                Console.WriteLine("New Budget: " + Van1.budget);
            }
            else if (althgsNumber == 3333333333 && Bus1.budget>0)
            {
               
                Console.WriteLine("The Type Is Bus");
                Console.WriteLine("Pass Fee is: " +busFee + "TL");
                newBusBudget -= busFee;
                Bus1.budget = newBusBudget;
                Console.WriteLine("Gecis Yaptigi Tarih Ve Saat: " + DateTime.Now);
                Console.WriteLine("New Budget: " + Bus1.budget);

            }
            hgsArray.Add(althgsNumber);
            


        }


    }
}
