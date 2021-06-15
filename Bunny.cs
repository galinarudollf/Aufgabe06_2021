using System;

namespace Uebung6
{
	class Bunny: Mammal
	{
		//Delegating constructor:
		public Bunny(string NewName, string NewOwner)
			: base(NewName, NewOwner)
		{

		}

		//Cleaning out the bunny's hutch:
		public override void Attend()
		{
			Console.WriteLine("Cleaning out {0}'s hutch' ...", Name);
		}

		//Scuttle around:
		public override void Move()
		{
			Console.WriteLine("{0} is scuttling around ...", Name);
		}

		//Print the object:
		public override string ToString()
		{
			return string.Format("{0}, the bunny, that belongs to {1}", Name, Owner ?? "nobody");
		}
	}
}
