using System;
using System.Collections.Generic;



namespace ConsoleApp1
{
	class PetsShop
	{
		public event EventHandler<AnimalEventArgs> AnimalCreated;
		

		public static List<Animal> al;
		public PetsShop()
		{
			al = new List<Animal>();
		}

		public void AddAnimal(Animal p)
		{
			al.Add(p);
			AnimalCreated?.Invoke(this, new AnimalEventArgs() { MyProperty = p});
		}

		public List<Animal> ShowPets()
		{
			return al;
		}

		public void IntroduceAll(object src, AnimalEventArgs e)
		{
			foreach (var p in al)
			{
				p.Introduce();
			}

			Console.WriteLine(e.MyProperty.Name);
			Console.WriteLine(src);
		}


	}

	class AnimalEventArgs : EventArgs
	{

		public Animal MyProperty { get; set; }

	}


}
