using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
        //public Motorcycle()
        //{
        //}
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The morotcycle is driving.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle Virtual Drive Method");
        }
    }
}

