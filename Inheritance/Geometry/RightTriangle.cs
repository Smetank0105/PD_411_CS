using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class RightTriangle : Triangle
	{
		public RightTriangle(int start_x, int start_y, int line_width, Color color) : base(start_x, start_y, line_width, color) { }
		public RightTriangle(double left_side, double base_side, int start_x, int start_y, int line_width, Color color)
			: base(left_side, Math.Sqrt(Math.Pow(left_side, 2) + Math.Pow(base_side, 2)), base_side, start_x, start_y, line_width, color)
		{
			SetPoint();
		}
		protected override void SetPoint()
		{
			PointA_X = 0;
			PointA_Y = 0;
			PointB_X = 0;
			PointB_Y = (int)BaseSide;
			PointC_X = (int)LeftSide;
			PointC_Y = (int)BaseSide;
		}
		public override void InitRandom(Random rnd)
		{
			base.InitRandom(rnd);

			RightSide = Math.Sqrt(Math.Pow(LeftSide, 2) + Math.Pow(BaseSide, 2));
			SetPoint();
		}
	}
}
