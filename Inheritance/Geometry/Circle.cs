using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
	class Circle:Shape,IHaveDiameter
	{
		double radius;
		public double Radius
		{
			get => radius;
			set => radius = value < MIN_SIZE/2 ? MIN_SIZE/2 : value > MAX_SIZE/2 ? MAX_SIZE/2 : value;
		}
		public Circle(double radius, int start_x, int start_y, int line_width, Color color)
			:base(start_x, start_y, line_width, color)
		{
			Radius = radius;
		}
		public double GetDiameter()
		{
			return Radius * 2;
		}
		public override double GetArea()
		{
			return Radius * Radius * Math.PI;
		}
		public override double GetPerimeter()
		{
			return GetDiameter() * Math.PI;
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX, StartY, (float)GetDiameter(),(float)GetDiameter());
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(GetType());
			Console.WriteLine($"Радиус: {Radius}");
			Console.WriteLine($"Диаметр: {GetDiameter()}");
			base.Info(e);
		}
	}
}
