using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gwen.Control;
using GLImp;
using System.Drawing;
using OpenTK;

namespace HeroesOfDiamondfall {
	class Town : Base {
		Building[,] Buildings = new Building[10, 10];

		public Town(Base parent) : base(parent) {
			Array.Clear(Buildings, 0, Buildings.Length);
			Buildings[0, 0] = new Building();
			Buildings[1, 1] = new Building();
			Buildings[2, 2] = new Building();
		}

		public void Draw() {
			GraphicsManager.DrawRectangle(X, Y, Width, Height, Color.Brown);

			Vector2d BuildingSize = new Vector2d(Width / 10, Height / 10);
			for (int x = 0; x < 10; x++) {
				for (int y = 0; y < 10; y++) {
					if (Buildings[x, y] != null) {
						Buildings[x, y].Draw(this.X + (x * BuildingSize.X), this.Y + (y * BuildingSize.Y), BuildingSize.X, BuildingSize.Y);
					}
				}
			}
		}

		public void Update() {

		}
	}
}
