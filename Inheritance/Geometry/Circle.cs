using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
	class Circle:Shape
	{
		double radius;
		public double Radius
		{
			get
			{
				return radius;
			}
			set
			{
				if (value > 0) radius = value;
			}
		}
		public Circle(double radius, Color color):base(color)
		{
			Radius = radius;
		}
		public override double GetArea()
		{
			return Radius * Radius * Math.PI;
		}
		public override double GetPerimeter()
		{
			return 2 * Radius * Math.PI;
		}
		public override void Draw(Graphics graphics, int x, int y)
		{
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
					Console.WindowLeft, Console.WindowTop,
					Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
			e.Graphics.DrawEllipse(new Pen(Color, 2), x, y, (int)Radius*2,(int)Radius*2);
		}
		public override void Info()
		{
			Console.WriteLine($"Радиус: {Radius}");
			base.Info();
		}
	}
}
