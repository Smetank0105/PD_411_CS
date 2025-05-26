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
			get => sideX;
			set => sideX = value < MIN_SIZE ? MIN_SIZE : value > MAX_SIZE ? MAX_SIZE : value;
		}
		public double SideY
		{
			get => sideY;
			set => sideY = value < MIN_SIZE ? MIN_SIZE : value > MAX_SIZE ? MAX_SIZE : value;
		}
		public Rectangle(double sideX, double sideY, int start_x, int start_y, int line_width, Color color) 
			: base(start_x, start_y, line_width, color)
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
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (float)SideX, (float)SideY);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(GetType());
			Console.WriteLine($"Длина сторон: A[{SideX}], B[{SideY}]");
			base.Info(e);
		}
	}
}
