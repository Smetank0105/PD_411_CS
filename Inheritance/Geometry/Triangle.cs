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
		Point pointA;
		Point pointB;
		Point pointC;
		public Point PointA
		{
			get { return pointA; }
			set { pointA = value; }
		}
		public Point PointB
		{
			get { return pointB; }
			set { pointB = value; }
		}
		public Point PointC
		{
			get { return pointC; }
			set { pointC = value; }
		}
		public Triangle(Point pA, Point pB, Point pC, Color color) : base(color)
		{
			PointA = pA;
			PointB = pB;
			PointC = pC;
		}
		public override double GetArea()
		{
			double sideAB, sideBC, sideCA, p;
			sideAB = Math.Sqrt(Math.Pow(PointB.X-PointA.X,2)+Math.Pow(PointB.Y-PointA.Y,2));
			sideBC = Math.Sqrt(Math.Pow(PointC.X-PointB.X,2)+Math.Pow(PointC.Y-PointB.Y,2));
			sideCA = Math.Sqrt(Math.Pow(PointA.X-PointC.X,2)+Math.Pow(PointA.Y-PointC.Y,2));
			p = (sideAB + sideBC + sideCA) / 2;
;			return Math.Sqrt(p*(p-sideAB)*(p-sideBC)*(p-sideCA));
		}
		public override double GetPerimeter()
		{
			double sideAB, sideBC, sideCA;
			sideAB = Math.Sqrt(Math.Pow(PointB.X - PointA.X, 2) + Math.Pow(PointB.Y - PointA.Y, 2));
			sideBC = Math.Sqrt(Math.Pow(PointC.X - PointB.X, 2) + Math.Pow(PointC.Y - PointB.Y, 2));
			sideCA = Math.Sqrt(Math.Pow(PointA.X - PointC.X, 2) + Math.Pow(PointA.Y - PointC.Y, 2));
			return sideAB + sideBC + sideCA; ;
		}
		public override void Draw(Graphics graphics, int x, int y)
		{
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
					Console.WindowLeft, Console.WindowTop,
					Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
			Point pA = new Point(PointA.X+x,PointA.Y+y);
			Point pB = new Point(PointB.X+x,PointB.Y+y);
			Point pC = new Point(PointC.X+x,PointC.Y+y);
			Point[] points = new Point[] { pA, pB, pC };
			e.Graphics.DrawPolygon(new Pen(Color, 2), points);
		}
		public override void Info()
		{
			Console.WriteLine($"Вершины: A{PointA}, B{PointB}, C{PointC}");
			base.Info();
		}
	}
}
