﻿using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		//public Car()
		//{
		//}

        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The car is driving.");
        }
    }
}

