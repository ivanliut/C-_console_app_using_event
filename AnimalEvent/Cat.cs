using System;


namespace ConsoleApp1
{
	class Cat : Animal
	{
		public Cat(string name, string breed) : base(name, breed)
		{

		}

		public override void Introduce()
		{
			Console.WriteLine($"I'm {this.Name} of {this.Breed} and I'm a cat");
		}
	}


}
