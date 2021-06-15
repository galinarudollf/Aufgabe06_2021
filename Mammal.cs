using System;

namespace Uebung6
{
	abstract class Mammal: Pet, IStrokeable
	{
		//All mammals can move:
		public abstract void Move();

		//Delegating constructor:
		public Mammal(string NewName, string NewOwner)
			: base(NewName, NewOwner)
		{

		}

		//All mammals can be stroked.
		//By default, they just enjoy it.
		//This method must be virtual to allow overriding!
		public virtual void Stroke()
		{
			Console.WriteLine("{0} enjoys being stroked!", Name);
		}
	}
}
