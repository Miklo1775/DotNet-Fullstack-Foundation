using System;

namespace classesObjects{

	internal class Student
	{
		// Member variables
		//by default, member variables are private
		public int studentId;
		public string studentName;

		//default Constructor and parameterized Constructor

		//public Student(int id, string name)
		//{
		//	studentId = id;
		//	studentName = name;
		//}

		// Member functions
		public void DisplayDetails()
		{
			Console.WriteLine($"Student ID: {studentId}");
			Console.WriteLine($"Student Name: {studentName}");
		}

		public void EnterDetails()
		{
			bool validEntry = false;
			string readResult;

			do
			{

				Console.WriteLine("Please Enter Student ID: ");
				readResult = Console.ReadLine();
				if (readResult != null)
				{
					validEntry = int.TryParse(readResult, out studentId);
				}
			} while (validEntry == false);

			validEntry = false;

			do
			{

				Console.WriteLine("Enter Student Name: ");
				readResult = Console.ReadLine();
				if (readResult != null)
				{
					studentName = readResult;
					validEntry = true;
				}



			} while (validEntry == false);


		}
	}

}
