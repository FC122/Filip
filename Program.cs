using System;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Rex=new Dog();
            int age;
            Rex.SetAge(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(Rex.GetAge());
            

        }
    }
}
