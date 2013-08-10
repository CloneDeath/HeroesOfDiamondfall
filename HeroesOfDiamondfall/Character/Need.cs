using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesOfDiamondfall.Character {
	abstract class Need {
		public bool Fulfilled;
		protected Hero Hero;

		public Need(Hero Hero) {
			this.Hero = Hero;
		}

		internal abstract void Resolve();
	}
}
