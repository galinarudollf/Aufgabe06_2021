using System;

namespace Uebung6
{
	class Goldfish: Fish, IStrokeable
	{
		//Delegating constructor:
		public Goldfish(string NewName, string NewOwner)
			: base(NewName, NewOwner)
		{

		}

		//Goldfish swim in circles:
		public override void Swim()
		{
			Console.WriteLine("{0} swims round and round ...", Name);
		}

		//Goldfish can actually be stroked if they have an owner!
		public void Stroke()
		{
			if (Owner != null)
			{
				Console.WriteLine("{0}, the goldfish, likes being stroked!", Name);
			}
			else
			{
				Console.WriteLine("{0}, the goldfish, is being stroked, but swims away because he has no owner!", Name);
			}
		}

		//Print the object:
		public override string ToString()
		{
			return string.Format("{0}, the goldfish, that belongs to {1}", Name, Owner ?? "nobody");
		}
	}
}
