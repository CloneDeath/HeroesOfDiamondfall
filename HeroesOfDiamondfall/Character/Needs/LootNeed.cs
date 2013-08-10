using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesOfDiamondfall.Character.Needs {
	class LootNeed : Need {
		public LootNeed(Hero Hero) : base(Hero) {
		}

		static Random rand = new Random();
		internal override void Resolve() {
			if (!typeof(Dungeon).IsAssignableFrom(Hero.Destination.GetType())) {
				Hero.Destination = Hero.world.Dungeons[rand.Next(Hero.world.Dungeons.Count)];
				Hero.Distance = ((Dungeon)Hero.Destination).Distance;
				return;
			}

			if (Hero.CurrentLocation == Hero.world.Town) {
				if (Hero.Y > 0 && Hero.Y < 5) {
					Hero.Y--;
				} else if (Hero.Y >= 5 && Hero.Y < 9) {
					Hero.Y++;
				} else {
					Hero.CurrentLocation = Hero.world.Wilderness;
				}
			} else if (Hero.CurrentLocation == Hero.Destination) {
				Fulfilled = true;
			}
		}
	}
}
