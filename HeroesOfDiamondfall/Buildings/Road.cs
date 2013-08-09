using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GLImp;

namespace HeroesOfDiamondfall.Buildings {
	class Road : Building {
		static Texture road = new Texture(@"Data\Road.png");
		public override void Draw(double x, double y, double width, double height) {
			road.Draw(x, y, width, height);
		}
	}
}
