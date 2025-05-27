using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
	class Triangle : Shape
	{
		double leftSide;
		double rightSide;
		double baseSide;
		public double LeftSide
		{
			get => leftSide;
			protected set => leftSide = value < MIN_SIZE ? MIN_SIZE : value > MAX_SIZE ? MAX_SIZE : value;
		}
		public double RightSide
		{
			get => rightSide;
			set => rightSide = value < MIN_SIZE ? MIN_SIZE : value > MAX_SIZE ? MAX_SIZE : value;
		}
		public double BaseSide
		{
			get => baseSide;
			set => baseSide = value < MIN_SIZE ? MIN_SIZE : value > MAX_SIZE ? MAX_SIZE : value;
		}
		protected int PointA_X { get; set; }
		protected int PointA_Y { get; set; }
		protected int PointB_X { get; set; }
		protected int PointB_Y { get; set; }
		protected int PointC_X { get; set; }
		protected int PointC_Y { get; set; }
		public Triangle(int start_x, int start_y, int line_width, Color color) : base(start_x, start_y, line_width, color) { }
		public Triangle(double left_side, double right_side, double base_side, int start_x, int start_y, int line_width, Color color) 
			: base(start_x, start_y, line_width, color)
		{
			LeftSide = left_side;
			RightSide = right_side;
			BaseSide = base_side;
			SetPoint();
		}
		public override double GetArea()
		{
			double p;
			p = (LeftSide + RightSide + BaseSide) / 2;
;			return Math.Sqrt(p*(p-LeftSide)*(p-RightSide)*(p-BaseSide));
		}
		public override double GetPerimeter()
		{
			return LeftSide + RightSide + BaseSide; ;
		}
		public override void Draw(PaintEventArgs e)
		{
			Point pA = new Point(PointA_X + StartX, PointA_Y + StartY);
			Point pB = new Point(PointB_X + StartX, PointB_Y + StartY);
			Point pC = new Point(PointC_X + StartX, PointC_Y + StartY);
			Point[] points = new Point[] { pA, pB, pC };
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawPolygon(pen, points);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(GetType());
			Console.WriteLine($"Стороны: AB:{LeftSide}, AC:{RightSide}, BC:{BaseSide}");
			base.Info(e);
		}
		protected virtual void SetPoint()
		{
			if (LeftSide>=RightSide)
			{
				PointA_X = (int)(Math.Sqrt(Math.Pow(LeftSide, 2) - Math.Pow(2 * GetArea() / BaseSide, 2)));
				PointA_Y = 0;
			}
			else
			{
				PointA_X = (int)(BaseSide-Math.Sqrt(Math.Pow(RightSide, 2) - Math.Pow(2 * GetArea() / BaseSide, 2)));
				PointA_Y = 0;
			}
			PointB_X = 0;
			PointB_Y = (int)(2 * GetArea() / BaseSide);
			PointC_X = (int)BaseSide;
			PointC_Y = PointB_Y;
		}
		public override void InitRandom(Random rnd)
		{
			base.InitRandom(rnd);
			LeftSide = rnd.NextDouble() * ((double)MAX_SIZE - (double)MIN_SIZE) + (double)MIN_SIZE;
			RightSide = rnd.NextDouble() * ((double)MAX_SIZE - (double)MIN_SIZE) + (double)MIN_SIZE;
			BaseSide = rnd.NextDouble() * (LeftSide + RightSide - (double)MIN_SIZE) + (double)MIN_SIZE;
			SetPoint();
		}
	}
}
