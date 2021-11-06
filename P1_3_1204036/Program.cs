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
            Console.WriteLine("");
            
            for (int i = hayam; hayam > 1; i = i - 1)
            {
                if (i > 1 )
                {
                    Console.WriteLine("Anak ayam turunlah " + Convert.ToString(i) + " mati satu tingallah " + Convert.ToString(i - 1));
                } else if(i == 1)                
                {
                    Console.Write("Anak ayam turunlah 1, mati satu tinggal induknya");                    
                }
            }
        }
    }
}