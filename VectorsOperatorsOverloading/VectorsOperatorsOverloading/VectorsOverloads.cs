using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorsOperatorsOverloading
{
    public class Vector
    {
        //Fields
        private MyStruct start;
        private MyStruct end;
        private MyStruct point;
        private double Length;

        //Ctors
        public Vector()
        {

        }
        public Vector(double a, double b)
        {
            start = new MyStruct();
            end = new MyStruct();
            point = new MyStruct(a, b);
            Length = 0;
        }
        public Vector(double a, double b, double c, double d)
        {
            start = new MyStruct(a, b);
            end = new MyStruct(c, d);
            point = new MyStruct(c - a, d - b);
            Length = Math.Sqrt(Math.Pow(point.x, 2) + Math.Pow(point.y, 2));
        }

        //Override method ToString
        public override string ToString()
        {
            if (this.start.x != 0)
                return string.Format($"Vector Information\nVector by points has: {start.x:F1}:{start.y:F1}-{end.x:F1}:{end.y:F1} coordinates\nVector has: {point.x},{point.y} coordinates\nThe length of Vector is: {Length:F2}\n");
            else return string.Format($"Vector Information\nVector has: {point.x:F1}:{point.y:F1} coordinates\n");
        }

        //Operators overloading
        public static Vector operator +(Vector vector1, Vector vector2)
        {

            Vector result = new Vector(vector1.point.x + vector2.point.x, vector1.point.y + vector2.point.y);
            return result;
        }

        public static Vector operator -(Vector vector1, Vector vector2)
        {

            Vector result = new Vector(vector1.point.x - vector2.point.x, vector1.point.y - vector2.point.y);
            return result;
        }

        public static Vector operator *(Vector vector1, Vector vector2)
        {

            Vector result = new Vector(vector1.point.x * vector2.point.x, vector1.point.y * vector2.point.y);
            return result;
        }
    }
}
