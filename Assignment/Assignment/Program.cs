using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment
{
    abstract class Quadrilateral
    {
        int length;
        int breadth;
         public abstract int area( int length , int breadth);
        public  Quadrilateral(int L , int B)
        {
            length = L;
            breadth = B;
        }
    }

    class Square : Quadrilateral
    {
        public Square(int L , int B) : base ( L , B  )
        {

        }
        public override int area(int length , int breadth)
        {
            return length * length;
        }
        

    }
   

    class Rectangle : Quadrilateral
    {
        int breadth;
        public Rectangle(int L , int B) : base(L,B)
        {

        }
      
        public override int area(int length , int breadth)
        {
            return length * breadth ;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle(4,5);
           R.area(4,5);
            Console.WriteLine("area of rec= {0}" , R.area(4,5));
          

           Square S = new Square(4 , 0);
            S.area(4 , 0);

            Console.WriteLine("area of square= {0}", S.area(4,0));

        }

    }
}
