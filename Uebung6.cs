using System;
using System.Collections.Generic;

namespace Uebung6
{
	class Uebung6Main
	{
		static void Main(string[] args)
		{
			//Garden:
			var Garden = new List<Mammal>
			{
				new Cat("Mr Snuffles", null),
				new Bunny("Fluffy", "Martin"),
				new Cat("Frieda", "Jonas"),
				new Cat("Garfield", "Ben"),
				new Bunny("Günther", "Richard"),
				new Cat("Horst", "Lorenzo"),
				new Bunny("Manfred", "Harald"),
				new Bunny("Klaus", "Siggi")
			};

			//Aquarium:
			var Aquarium = new List<Fish>
			{
				new Goldfish("Goldini", "Richard"),
				new Guppy("GupGup", "Jonas"),
				new Guppy("Hugo", "Martin"),
				new Goldfish("Herbert", null),
				new Guppy("LoneStar", null)
			};

			//Make the mammals move:
			Console.WriteLine("Garden:\n");

			foreach (Mammal CurrMammal in Garden)
			{
				Console.WriteLine(CurrMammal);
				CurrMammal.Move();
				Console.WriteLine();
			}

			//Let the fish swim:
			Console.WriteLine("Aquarium:\n");

			foreach (Fish CurrFish in Aquarium)
			{
				Console.WriteLine(CurrFish);
				CurrFish.Swim();
				Console.WriteLine();
			}

			//Build the zoo:
			var Zoo = new List<Pet>(Garden);
			Zoo.AddRange(Aquarium);

			//Attend and stroke:
			Console.WriteLine("Zoo:\n");

			foreach (Pet CurrPet in Zoo)
			{
				Console.WriteLine(CurrPet);
				CurrPet.Attend();

				//Try to cast to IStrokeable:
				IStrokeable CurrStrokeable = CurrPet as IStrokeable;

				if (CurrStrokeable != null)
				{
					CurrStrokeable.Stroke();
				}
				else
				{
					Console.WriteLine("Unfortunalety, {0} cannot be stroked :(", CurrPet.Name);
				}

				Console.WriteLine();
			}
		}
	}
}
