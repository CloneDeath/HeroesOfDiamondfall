using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GLImp;
using System.Drawing;

namespace HeroesOfDiamondfall {
	class Building {
		internal void Draw(double x, double y, double width, double height) {
			GraphicsManager.DrawRectangle(x, y, width, height, Color.Blue);
		}
	}
}
