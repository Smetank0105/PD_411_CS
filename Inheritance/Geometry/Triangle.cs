using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
	abstract class Triangle : Shape
	{
		public abstract double GetHeight();
		protected Triangle(int start_x, int start_y, int line_width, Color color)
			: base(start_x, start_y, line_width, color) { }
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(GetType());
			base.Info(e);
		}
	}
}
