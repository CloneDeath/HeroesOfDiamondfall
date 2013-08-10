using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeroesOfDiamondfall.Buildings;

namespace HeroesOfDiamondfall.Character.Needs {
	class ArmorNeed : Need {
		public ArmorNeed(Hero Hero) : base(Hero) {
		}

		internal override void Resolve() {
			bool Found = false;
			int BestX = 0;
			int BestY = 0;
			for (int x = 0; x < 10; x++) {
				for (int y = 0; y < 10; y++) {
					if (Hero.world.Town.Buildings[x, y] == null) continue;

					if (Hero.world.Town.Buildings[x, y].GetType() == typeof(Blacksmith)) {
						if (Found == false) {
							Found = true;
							BestX = x;
							BestY = y;
							continue;
						}

						int ThisDist = Math.Abs(Hero.X - x) + Math.Abs(Hero.Y - y);
						if (ThisDist < Math.Abs(Hero.X - BestX) + Math.Abs(Hero.Y - BestY)) {
							BestX = x;
							BestY = y;
						}
					}
				}
			}

			if (Found) {
				if (Hero.X < BestX) {
					Hero.X++;
				} else if (Hero.X > BestX) {
					Hero.X--;
				} else if (Hero.Y < BestY) {
					Hero.Y++;
				} else if (Hero.Y > BestY) {
					Hero.Y--;
				} else {
					Hero.Equipment.Armor = new Armor();
					Fulfilled = true;
				}
			}
		}
	}
}
