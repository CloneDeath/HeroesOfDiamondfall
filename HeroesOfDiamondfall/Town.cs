using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gwen.Control;
using GLImp;
using System.Drawing;
using OpenTK;
using HeroesOfDiamondfall.Buildings;

namespace HeroesOfDiamondfall {
	class Town : Base, Location {
		static Texture Dirt = new Texture(@"Data\Dirt.png");
		Building[,] Buildings = new Building[10, 10];

		public Town(Base parent) : base(parent) {
			Array.Clear(Buildings, 0, Buildings.Length);
			Buildings[0, 0] = new House();
			Buildings[1, 0] = new Blacksmith();
			Buildings[2, 0] = new Church();
			Buildings[3, 0] = new MagicShop();
			Buildings[4, 0] = new Shop();

			Buildings[0, 1] = new Road();
			Buildings[1, 1] = new Road();
			Buildings[2, 1] = new Road();
			Buildings[3, 1] = new Road();
			Buildings[4, 1] = new Road();
		}

		public void Draw() {
			Dirt.Subimage(0, 0, Width / 2, Height/2).Draw(X, Y, Width, Height);

			Vector2d BuildingSize = new Vector2d(Width / 10, Height / 10);
			for (int x = 0; x < 10; x++) {
				for (int y = 0; y < 10; y++) {
					if (Buildings[x, y] != null) {
						Buildings[x, y].Draw(this.X + (x * BuildingSize.X), this.Y + (y * BuildingSize.Y), BuildingSize.X, BuildingSize.Y);
					}
				}
			}

			foreach (Hero hero in Heroes) {
				hero.Draw(this.X + (hero.X * BuildingSize.X), this.Y + (hero.Y * BuildingSize.Y), BuildingSize.X, BuildingSize.Y);
			}
		}

		List<Hero> Heroes = new List<Hero>();

		public void Update() {
			Heroes.Clear();
		}

		Random rand = new Random();
		public void AddHero(Hero hero) {
			Heroes.Add(hero);
		}
	}
}
