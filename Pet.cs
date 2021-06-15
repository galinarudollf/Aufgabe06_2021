using System;

namespace Uebung6
{
	abstract class Pet
	{
		//The name of the pet:
		public string Name
		{
			get;
			set;
		}

		//Attend the pet:
		public abstract void Attend();

		//The owner of the pet:
		public string Owner
		{
			get;
			private set;
		}

		//The constructor to set the owner and the name:
		public Pet(string NewName, string NewOwner)
		{
			Name = NewName;
			Owner = NewOwner;
		}
	}
}
