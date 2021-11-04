using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the Transport type (exe. taxi , bus , Truck)");
            string mNov = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Time spent in the parking lot");
            double time = Convert.ToInt32(Console.ReadLine());
            if (mNov == "taxi" || mNov=="Taxi" || mNov=="TAXI" )
            {
                Console.WriteLine(taxi(time));
            }
            else if (mNov == "bus" || mNov == "Bus" || mNov=="BUS")
            {
                Console.WriteLine(bus(time));
            }
            else if(mNov == "truck" || mNov=="Truck" || mNov=="TRUCK" )
            {
                Console.WriteLine(truck(time));
            }
            else
            {
                Console.WriteLine("Error, Please writing correctly");
            }

        }

        public static double taxi (double time)
        {
            double td = 5,tn=0;
            if (time > 1)
            {
                for (int i = 0; i < time; i++)
                {
                    
                      tn =tn + (5 * 0.2);
                    
                }
                return tn;
            }
            else if (time >0 || time <=1)
            {
                return td;
            }
            return tn;
            
        }
        public static double bus(double time)
        {
            double bd = 6, bn = 0;
            for (int i = 0; i < time; i++)
            {
                bn = bn + (bd * 25 / 100);
            }
            return bn;
        }

        public static double truck(double time)
        {
            double trd = 6, trn = 0;
            for (int i = 0; i < time; i++)
            {
                trn = trn + (trd * 30 / 100);
            }
            return trn;
        }

    }
}
