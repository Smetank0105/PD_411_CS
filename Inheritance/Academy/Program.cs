using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Program
	{
		static readonly string  delimiter = "\n----------------------------------------------\n";
		static void Main(string[] args)
		{
			Human human = new Human("Montana", "Antonio", 25);
			human.Info();
			Console.WriteLine(delimiter);

			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
			student.Info();
			Console.WriteLine(delimiter);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			teacher.Info();
			Console.WriteLine(delimiter);

			Human tommy = new Human("Vercetty", "Tommy", 30);
			tommy.Info();
			Console.WriteLine(delimiter);

			Student s_tommy = new Student(tommy, "Theft", "Vice", 95, 98);
			s_tommy.Info();

		}
	}
}
