﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GLImp;

namespace HeroesOfDiamondfall.Buildings {
	class Shop : Building {
		static Texture house = new Texture(@"Data\Shop.png");
		public override void Draw(double x, double y, double width, double height) {
			house.Draw(x, y, width, height);
		}
	}
}
