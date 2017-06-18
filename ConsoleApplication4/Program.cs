using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int row =0; row<7; row++)
            {
                for (int col = 0; col<7; col++)
                {
                    if (row ==0 || row ==6 || col==0 || col==6 || row == col || row+col==6 )
         
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                
                  }
                Console.WriteLine();  
              }
            Console.ReadKey();
        }
        
    }
}
