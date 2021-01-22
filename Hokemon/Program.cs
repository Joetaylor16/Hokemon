using System;

namespace Hokemon
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Hokeworld!");

            Hokemon hokeObject01 = new Hokemon();

            //Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            hokeObject01.get_details();

            Hokemon hoke02 = new Hokemon();

            hoke02.get_details();

            Halor halorHoke01 = new Halor(); // INHERITED Halor-Hokemon
            halorHoke01.get_details();
        }
    }

}
