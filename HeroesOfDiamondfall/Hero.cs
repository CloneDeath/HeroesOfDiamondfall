using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GLImp;

namespace HeroesOfDiamondfall {
	class Hero {
		static Texture WariorTex = new Texture(@"Data\Warior.png");

		public int X = 0;
		public int Y = 0;

		public Location CurrentLocation;
		public Location Destination;

		public int Distance;
		public string Name;

		static Random rand = new Random();

		public World world;
		public Hero(World World) {
			Name = "Hero #" + rand.Next(1000);
			Distance = rand.Next(20) + 1;
			this.world = World;

			Destination = World.Town;
			CurrentLocation = World.Wilderness;
		}

		internal void Update() {
			if (Destination != CurrentLocation) {
				if (--Distance <= 0) {
					CurrentLocation = Destination;
					if (Destination == world.Town) {
						int pos = rand.Next(36); //Circle
						if (pos < 10) {
							this.Y = 0;
							this.X = pos;
						} else if (pos < 20) {
							this.Y = 9;
							this.X = pos - 10;
						} else if (pos < 28) {
							this.X = 0;
							this.Y = pos - 19;
						} else {
							this.X = 9;
							this.Y = pos - 27;
						}
					}
				} else {
					world.Wilderness.AddHero(this);
					return;
				}
			}

			CurrentLocation.AddHero(this);
		}

		public void Draw(double x, double y, double width, double height) {
			WariorTex.Draw(x + ((rand.NextDouble() - 0.5) * width), y + ((rand.NextDouble() - 0.5) * height), width, height);
		}
	}
}
