using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
	class Program
	{
		static void Main(string[] args)
		{
			Point A = new Point();  //Классы в C# являются ссылочными типами, 
									//и для них обязательно выделяется память оператором 'new'.
									//В языке C# оператор 'delete' отсутсвует, поскольку объекты 
									//удаляет сборщик мусора (Garbage Collector), который является
									//частью CLR - Common Language Runtime.
									//Объект удаляется из память только в том случае,
									//когда на этот объект
									//нет ни единой ссылки.
									//Point A - это всего лишь ссылка на объект,
									//сам объект хрантся в динамической памяти.
			A.Print();
			A.X = 2;//A.SetX(2);
			A.Y = 3;//A.SetY(3);
			A.Print();

			Point B = new Point(50);
			//B.X = 7000;
			//B.Y = 8000;
			B.Print();

			Point C = new Point(7, 8);
			C.Print();

			int a = 2;
			int b = 3;
			int c = a + b;
			Console.WriteLine("\n--------------------------\n");
			Point D = A + B;
			D.Print();
		}
	}
}
