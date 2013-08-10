using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeroesOfDiamondfall.Character.Needs;

namespace HeroesOfDiamondfall.Character {
	class NeedList {
		Hero Hero;

		public NeedList(Hero parent) {
			this.Hero = parent;
			CurrentNeed = null;
		}

		private Need CurrentNeed;

		public Need GetNeed() {
			if (CurrentNeed != null && CurrentNeed.Fulfilled) {
				CurrentNeed = null;
			}

			if (CurrentNeed != null) {
				return CurrentNeed;
			}

			if (Hero.Equipment.Sword == null) {
				CurrentNeed = new SwordNeed(Hero);
			} else if (Hero.Equipment.Armor == null) {
				CurrentNeed = new ArmorNeed(Hero);
			} else {
				CurrentNeed = new LootNeed(Hero);
			}
			return CurrentNeed;
		}
	}
}
