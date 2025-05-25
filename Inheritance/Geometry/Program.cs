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

			//Shape shape = new Shape(); //Невозможно создать экземпляр абстрактного класса
			Square square = new Square(50, Color.Red);
			square.Info();
			square.Draw(graphics,400,10);
			Console.WriteLine();
			Circle circle = new Circle(25, Color.Green);
			circle.Draw(graphics, 500, 10);
			circle.Info();
			Console.WriteLine();

		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
