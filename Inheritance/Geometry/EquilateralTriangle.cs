using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class EquilateralTriangle : Triangle
	{
	public EquilateralTriangle(int start_x, int start_y, int line_width, Color color) : base(start_x, start_y, line_width, color) { }
	public EquilateralTriangle(double side, int start_x, int start_y, int line_width, Color color)
			: base(side, side, side, start_x, start_y, line_width, color) { }
		public override void InitRandom(Random rnd)
		{
			base.InitRandom(rnd);
			RightSide = LeftSide;
			BaseSide = LeftSide;
			SetPoint();
		}
	}
}
