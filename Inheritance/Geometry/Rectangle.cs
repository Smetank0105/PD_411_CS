using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
	class Rectangle:Shape
	{
		double sideX;
		double sideY;
		public double SideX
		{
			get { return sideX; }
			set { if (value > 0) sideX = value; }
		}
		public double SideY
		{
			get { return sideY; }
			set { if (value > 0) sideY = value; }
		}
		public Rectangle(double sideX, double sideY, Color color) : base(color)
		{
			SideX = sideX;
			SideY = sideY;
		}
		public override double GetArea()
		{
			return SideX * SideY;
		}
		public override double GetPerimeter()
		{
			return (SideX + SideY) * 2;
		}
		public override void Draw(Graphics graphics, int x, int y)
		{
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
					Console.WindowLeft, Console.WindowTop,
					Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
			e.Graphics.DrawRectangle(new Pen(Color, 2), x, y, (int)SideX, (int)SideY);
		}
		public override void Info()
		{
			Console.WriteLine($"Длина сторон: A[{SideX}], B[{SideY}]");
			base.Info();
		}
	}
}
