using System;

namespace Uebung6
{
	class Cat: Mammal
	{
		//Cats need a random for stroking:
		private static readonly Random StrokingRandom = new Random();

		//Delegating constructor that always sets "null" for the owner:
		public Cat(string NewName, string NewOwner)
			: base(NewName, null)
		{
			if (NewOwner != null)
			{
				Console.WriteLine("Attention, {0}'s owner has been dropped because cats never have owners!", Name);
			}
		}

		//Brush the cat's fur:
		public override void Attend()
		{
			Console.WriteLine("Brushing {0}'s fur ...", Name);
		}

		//Sneak around:
		public override void Move()
		{
			Console.WriteLine("{0} is sneaking around ...", Name);
		}

		//Implement special stroking behavior:
		public override void Stroke()
		{
			base.Stroke();
			
			//Add purring:
			Console.WriteLine("{0} is purring.", Name);

			//Add biting:
			if (Cat.StrokingRandom.Next(5) == 4)
			{
				Console.WriteLine("{0} bites you for no reason!", Name);
			}
		}

		//Print the object:
		public override string ToString()
		{
			return string.Format("{0}, the cat", Name);
		}
	}
}
