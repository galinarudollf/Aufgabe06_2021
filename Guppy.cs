using System;

namespace Uebung6
{
	class Guppy: Fish
	{
		//Delegating constructor:
		public Guppy(string NewName, string NewOwner)
			: base(NewName, NewOwner)
		{

		}

		//Guppies swim back and forth:
		public override void Swim()
		{
			Console.WriteLine("{0} swims back and forth ...", Name);
		}

		//Print the object:
		public override string ToString()
		{
			return string.Format("{0}, the guppy, that belongs to {1}", Name, Owner ?? "nobody");
		}
	}
}
