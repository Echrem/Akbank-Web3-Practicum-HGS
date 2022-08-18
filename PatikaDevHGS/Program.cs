using System;

namespace PatikaDevHGS

{ 
    
   public class Program
    {
        
        public static void Main(string[] args)
        {
        Int64 althgsNumber= 0;
            string select="";
           

            ogsSystem OGS = new ogsSystem();
            hgsSystem HGS = new hgsSystem();
            Vehicle Car1 = new Vehicle();
            Vehicle Van1 = new Vehicle();
            Vehicle Bus1 = new Vehicle();

            Car1.hgsNumber = 1111111111;
            Car1.ownerName = "Satoshi Nakamoto";
            Car1.vehicleType = "Car";
            

            Van1.hgsNumber = 2222222222;
            Van1.ownerName = "Vitalik Buterin";
            Van1.vehicleType = "Van";
           

            Bus1.hgsNumber = 3333333333;
            Bus1.ownerName = "Alan Turing";
            Bus1.vehicleType = "Bus";
            
            p1:
            Console.WriteLine("Choose Action: ");
            Console.WriteLine("1- Pass a car");
            Console.WriteLine("2- Pass a van");
            Console.WriteLine("3- Pass a bus");
            Console.WriteLine("4- List earning");
             
            select = Console.ReadLine();
            if (select == "1")
            {
                althgsNumber = 1111111111;
                HGS.hgsPay(althgsNumber);
                OGS.earning(althgsNumber);
                goto p1;
            }
            else if (select == "2")
            {
                althgsNumber = 2222222222;               
                HGS.hgsPay(althgsNumber);
                OGS.earning(althgsNumber);
                goto p1;
            }
            else if (select == "3")
            {
                althgsNumber = 3333333333;
                HGS.hgsPay(althgsNumber);
                OGS.earning(althgsNumber);
                goto p1;
            }
            else if (select == "4")
            {         
                OGS.listEarning();
                althgsNumber = 0;

                goto p1;
            }

            


            
            

        }
      
    }
}
