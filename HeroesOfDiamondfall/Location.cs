using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesOfDiamondfall {
	interface Location {
		string Name {
			get;
			set;
		}

		void Update();

		void AddHero(Hero hero);
	}
}
