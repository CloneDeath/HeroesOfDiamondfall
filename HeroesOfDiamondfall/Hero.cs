using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesOfDiamondfall {
	class Hero {
		public int X = 0;
		public int Y = 0;

		public Location CurrentLocation;
		public Location Destination;

		public int Distance;
		string Name;

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
				}
			}
		}
	}
}
