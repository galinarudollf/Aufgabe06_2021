using System;

namespace Uebung6
{
	abstract class Fish: Pet
	{
		//All fish can swim:
		public abstract void Swim();

		//Delegating constructor:
		public Fish(string NewName, string NewOwner)
			: base(NewName, NewOwner)
		{

		}

		//Attending is the same for all fish:
		public override void Attend()
		{
			Console.WriteLine("Changing water for {0} ...", Name);
		}
	}
}
