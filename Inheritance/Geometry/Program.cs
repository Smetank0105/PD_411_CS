//#define TEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Geometry
{
	class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
			(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
			);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);

			//Shape shape = new Shape(); //Невозможно создать экземпляр абстрактного класса
#if TEST
			Square square = new Square(50, 500, 100, 2, Color.Red);
			square.Info(e);
			Console.WriteLine();

			Circle circle = new Circle(25, 600, 100, 4, Color.Green);
			circle.Info(e);
			Console.WriteLine();

			Triangle triangle = new Triangle(50, 50, 50, 700, 100, 6, Color.Blue);
			triangle.Info(e);
			Console.WriteLine();

			Rectangle rectangle = new Rectangle(75, 50, 800, 100, 8, Color.Yellow);
			rectangle.Info(e);
			Console.WriteLine();

			RightTriangle r_triangle = new RightTriangle(50, 50, 500, 200, 2, Color.White);
			r_triangle.Info(e);
			Console.WriteLine();

			EquilateralTriangle e_triangle = new EquilateralTriangle(50, 600, 200, 4, Color.Cyan);
			e_triangle.Info(e);
			Console.WriteLine();

			IsoscelesTriangle i_triangle = new IsoscelesTriangle(50, 70, 700, 200, 6, Color.HotPink);
			i_triangle.Info(e);
			Console.WriteLine(); 
#endif
			Shape shape;
			Random rnd = new Random();
			for (int i = 0; i < 7; i++)
			{
				shape = ShapeFactory(rnd.Next(1, 8));
				shape.StartX = 800;
				shape.StartY = i * 100;
				shape.InitRandom(rnd);
				shape.Info(e);
				Console.WriteLine();
			}
		}
		public static Shape ShapeFactory(int typeId)
		{
			switch (typeId)
			{
				case 1: return new Rectangle(0, 0, 1, Color.Red);
				case 2: return new Square(0, 0, 1, Color.Red);
				case 3: return new Circle(0, 0, 1, Color.Red);
				case 4: return new Triangle(0, 0, 1, Color.Red);
				case 5: return new RightTriangle(0, 0, 1, Color.Red);
				case 6: return new EquilateralTriangle(0, 0, 1, Color.Red);
				case 7: return new IsoscelesTriangle(0, 0, 1, Color.Red);
				default: return new Circle(0, 0, 1, Color.Red); ;
			}
		}

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
