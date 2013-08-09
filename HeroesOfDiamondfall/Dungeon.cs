using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesOfDiamondfall {
	class Dungeon : Location {
		public string Name {
			get;
			protected set;
		}

		public int Distance;
		public int Level;

		public Dungeon(string Name) {
			this.Name = Name;
		}

		static Random rand = new Random();
		public Dungeon() {
			this.Name = "Dungeon #" + rand.Next(100);
			this.Distance = rand.Next(50) + 1;
			this.Level = rand.Next(11);
		}



		
	}
}
