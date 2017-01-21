using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorsOperatorsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(2, 4, 6, 8);
            Vector vector2 = new Vector(1, 2, 4, 3);
            Console.WriteLine(vector1.ToString());
            Console.WriteLine(vector2.ToString());

            Vector vector3 = vector1 + vector2;
            Console.WriteLine(vector3.ToString());

            Vector vector4 = vector3 - vector2;
            Console.WriteLine(vector4.ToString());

            Vector vector5 = vector3 * vector2;
            Console.WriteLine(vector5.ToString());

            Console.ReadKey();
        }
    }
}
