using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
	class Point
	{

		//double x;
		//double y;

		//public double X
		//{
		//	get
		//	{
		//		return x;
		//	}
		//	set
		//	{
		//		if (value > 1000) value = 800;
		//		this.x = value;	//Ключевое слово 'value' возвращает принимаемое значение.
		//	}
		//}
		//public double Y
		//{
		//	get
		//	{
		//		return y;
		//	}
		//	set
		//	{
		//		if (value > 1000) value = 600;
		//		this.y = value;
		//	}
		//}

		//public double GetX()
		//{
		//	return x;
		//}
		//public double GetY()
		//{
		//	return y;
		//}
		//public void SetX(double x)
		//{
		//	this.x = x;
		//	//this - это указатель на объект, для которого вызывается метод
		//}
		//public void SetY(double y)
		//{
		//	this.y = y;
		//}

		//Модификатор доступа распространяется только на одно поле (переменную, либо метод)
		public double X { get; set; }
		public double Y { get; set; }

		//				Constructors:
		public Point(double x = 0, double y = 0)
		{
			X = x;
			Y = y;
			Console.WriteLine($"Constructor:\t{this.GetHashCode()}");
		}
		~Point()
		{
			Console.WriteLine($"Destructor:\t{this.GetHashCode()}");
		}


		//Operators:
		public static Point operator+(Point left, Point right)
		{
			Point result = new Point();
			result.X = left.X + right.X;
			result.Y = left.Y + right.Y;
			return result;
		}

		public void Print()
		{
			Console.WriteLine($"X = {X}, Y = {Y}");
		}
		void Method()
		{
			//У этого метода уже будет модификатор по умолчанию - 'private'.
		}
	}
}
/*
---------------------------------------------------
			МОДИФИКАТОРЫ ДОСТУПА:
Кроме 'private', 'public' и 'protected' в языке C#
так же есть 
internal - делает поле доступным в пределах сборки (Assembly);
protected internal - делает поля доступными как для 
					 дочерних классов в пределах данной сборки.
---------------------------------------------------
Get/Set-методы
---------------------------------------------------
Properties - это синтаксические конструкции, которые объединяют в себе Get и Set методы,
			 и позволяют использовать их как обычные public переменные.
			 Свойства всегда называют так же, как переменные члены класса, но с большой буквы.
---------------------------------------------------
AutoProperties:
	public type Name{get; set;}
---------------------------------------------------
 */