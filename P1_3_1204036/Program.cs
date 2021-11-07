using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_3_1204036
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear(); 
            Console.Write("ANAK AYAM TURUN ");
            int hayam = Convert.ToInt16(Console.ReadLine());

            int ayam = hayam;
            Console.WriteLine("");

            {
                if (ayam > 10 )
                {
                    Console.WriteLine("Harap Inputkan 1 - 10 !");
                } else if(ayam < 1)                
                {
                    Console.WriteLine("Harap Inputkan 1 - 10 !");
                }
                    else
                    {
                for (int i = ayam; i> 0; i--)
                    {
                      if(i > 1)
                        {
                            Console.WriteLine("Anak ayam turunlah " + Convert.ToString(i) + " mati satu tingallah " + Convert.ToString(i - 1));

                        }
                      else if(i == 1)
                        {
                            Console.Write("Anak ayam turunlah "+i+ ", mati satu tinggal induknya");                    
                            Console.WriteLine("");
                        }
                    }                    
                }
            }
        }
    }
}