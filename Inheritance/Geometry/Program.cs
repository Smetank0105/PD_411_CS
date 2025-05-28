//#define ABSTRACT_BASE_CLASS
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
#if ABSTRACT_BASE_CLASS
			//Shape shape = new Shape(); //Невозможно создать экземпляр абстрактного класса
			Square square = new Square(50, 400, 100, 2, Color.Red);
			square.Info(e);
			Console.WriteLine();

			Circle circle = new Circle(25, 500, 100, 4, Color.Green);
			circle.Info(e);
			Console.WriteLine();

			Rectangle rectangle = new Rectangle(50, 75, 600, 100, 8, Color.Yellow);
			rectangle.Info(e);
			Console.WriteLine();

			EquilateralTriangle e_triangle = new EquilateralTriangle(50, 700, 100, 2, Color.Blue);
			e_triangle.Info(e);
			Console.WriteLine(); 
#endif
			Shape[] shapes = new Shape[]
			{
				new Square(50, 400, 100, 2, Color.Red),
				new Circle(25, 500, 100, 4, Color.Green),
				new Rectangle(50, 75, 600, 100, 8, Color.Yellow),
				new EquilateralTriangle(50, 700, 100, 2, Color.Blue)
			};
			for(int i = 0; i < shapes.Length; i++)
			{
				if(shapes[i] is IHaveDiameter)shapes[i].Draw(e);
			}
		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
