using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class IsoscelesTriangle : Triangle
	{
		public IsoscelesTriangle(int start_x, int start_y, int line_width, Color color) : base(start_x, start_y, line_width, color) { }
		public IsoscelesTriangle(double side, double base_side, int start_x, int start_y, int line_width, Color color)
			: base(side, side, base_side, start_x, start_y, line_width, color) { }
		public override void InitRandom(Random rnd)
		{
			base.InitRandom(rnd);
			LeftSide = rnd.NextDouble() * ((double)MAX_SIZE - (double)MIN_SIZE) + (double)MIN_SIZE;
			RightSide = LeftSide;
			BaseSide = rnd.NextDouble() * (LeftSide + RightSide - (double)MIN_SIZE) + (double)MIN_SIZE;
			SetPoint();
		}
	}
}
