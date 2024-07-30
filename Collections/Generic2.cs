using System;

namespace Collections
{
    class Generic2<T>
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }

    class TestGenerics
    {
        static void Main(string[] args)
        {
            Generic2<int> obj = new Generic2<int>();
            obj.Add(10, 20);
            obj.Sub(10, 20);
            obj.Mul(10, 20);
            obj.Div(10, 20);
            Console.ReadLine();
        }
    }
}
