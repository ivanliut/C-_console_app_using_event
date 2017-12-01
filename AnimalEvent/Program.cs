using System;


namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{

				FactoryMetod();

			}
			catch (InvalidAnimalException e)
			{

				Console.WriteLine("Something went wrong... " + e.Message);

			}
			catch (Exception e)
			{

				Console.WriteLine("Something went wrong... " + e.Message);

			}


			Console.ReadKey();

		}

		private static void FactoryMetod()
		{
			Dog d1 = new Dog("PitDog", "PitBull");
			Cat c1 = new Cat("CatCatty", "Siamese");

			Dog d2 = new Dog("PitDog2", "PitBull2");
			Cat c2 = new Cat("CatCatty2", "Siamese2");

			PetsShop ps = new PetsShop();
			ps.AnimalCreated += ps.IntroduceAll;
			ps.AddAnimal(d1);
			ps.AddAnimal(c1);

			ps.AddAnimal(d2);
			ps.AddAnimal(c2);


		}
	}


}
