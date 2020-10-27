using System;

namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person1 = new Person("Hengameh Lotfi", 29, 'F', 55, 168);
            Person person2 = new Person("Roya Lotfi", 27, 'F', 57);
            Person person3 = new Person();

            Console.WriteLine(person1.ToString );
            Console.WriteLine(person2.ToString );
            Console.WriteLine(person3.ToString );

        }
    }
}
