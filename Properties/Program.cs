using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel("Bansal");
            person.FirstName = "Prateek";
            
            person.SSN = "161-67-0614";

            Console.WriteLine($"{person.FullName} : {person.SSN}");



            Console.ReadLine();
        }
    }
}
