# Operators Overloading for Matematical Vectors 
# C#6.0  .NET FRAMEWORK 4.6

This project allow You work with Vector object, for which the basic operators are overloaded.

----

### Purpose

Show operators overloading and make a useful class Vector, with own overloaded operators.
----
### Vector class implementation
```c#
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
```
### Description of Vector class
The vector class represents the matematical vectors. There are vector start and end point represented by MyStruct structure, that have two double x and y fields(This structure implemented in another file), the vector coordinate represented by MyStruct structure and Length field, which indicates the leng.th of vector. Also there are several constructor, overrided ToString method and operators overloading in the clas.

### MyStruct structure implementation 
```c#
 public struct MyStruct
{
        public double x;
        public double y;
        public MyStruct(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }
}
```
### Description MyStruct structure
In this structure we declare two double x and y fields, which define the coordinates of points and the constructor,

### Test 
We creare vectors objects, do some actions with them, by overloaded operators and show the resuklt by the overrided ToString() method.
```c#
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
```
### Result

![N|Solid](https://github.com/shtigran/VectorsOperatorsOverloading/blob/master/OperatorsOverloading.png)

As You can see we create several Vector object, do the basic actions with them and printed the results by ToString() overrided method.
