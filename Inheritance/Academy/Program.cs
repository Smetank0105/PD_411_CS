//#define INHERITANCE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Program
	{
		static readonly string delimiter = "\n----------------------------------------------\n";
		static void Main(string[] args)
		{
#if INHERITANCE
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
			Console.WriteLine(delimiter);

			Graduate g_tommy = new Graduate(s_tommy, "How to make money");
			g_tommy.Info();
			Console.WriteLine(delimiter);

			Graduate graduate = new Graduate("Schreder", "Hank", 40, "Criminalistic", "OBN", 70, 80, "How to catch Heizenberg");
			graduate.Info();
			Console.WriteLine(delimiter); 
#endif
			//Generalization(обобщение):
			Human[] group = new Human[]
				{
					//Upcast - преобразование объекта дочернего класса в объект базового класса
					new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96),
					new Teacher("White", "Walter", 50, "Chemistry", 25),
					new Graduate("Vercetty", "Tommy", 30, "Theft", "Vice", 95, 98, "How to make money"),
					new Graduate("Schreder", "Hank", 40, "Criminalistic", "OBN", 70, 80, "How to catch Heizenberg"),
					new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20)
				};
			//Specialisation(Уточнение):
			Console.WriteLine(delimiter);
			for(int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
				//group[i].Info();
				Console.WriteLine(delimiter);
			}
		}
	}
}
