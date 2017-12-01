using System;


namespace ConsoleApp1
{
	abstract class Animal
	{
		public string Name;
		public string Breed;
		public Animal(string name, string breed)
		{
			if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(breed)
				&& string.IsNullOrWhiteSpace(breed) && string.IsNullOrWhiteSpace(breed))
			{
				throw new ArgumentException("FirstName and LastName cannot be empty, null or whitespace");

			}
			else
			{
				this.Name = name;
				this.Breed = breed;
			}

		}

		public virtual void Introduce()
		{
			Console.WriteLine("I'm an animal human after all...");
		}
	}


}
