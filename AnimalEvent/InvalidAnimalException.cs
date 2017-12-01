using System;


namespace ConsoleApp1
{
	[Serializable]
	class InvalidAnimalException : Exception
	{
		public InvalidAnimalException()
		{

		}

		public InvalidAnimalException(string name)
			: base(String.Format("Invalid Animal Name: {0}", name))
		{

		}

	}


}
