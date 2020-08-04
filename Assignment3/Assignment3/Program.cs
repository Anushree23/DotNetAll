using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3;
namespace Assignment3
{
    class Program
    {
    
        
        static void Main(string[] args)
        {
            Vehicle veh = new Vehicle("Cielo" , "red",4,1,2);
            veh.start();
            veh.stop();
            veh.Display();

        }
    }
}



