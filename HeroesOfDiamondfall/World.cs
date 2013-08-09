using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gwen.Control;

namespace HeroesOfDiamondfall {
	class World : Base {
		public Town Town;
		public List<Dungeon> Dungeons = new List<Dungeon>();
		public List<Hero> Heroes = new List<Hero>();
		public Dungeon Wilderness = new Dungeon("Wilderness");

		public World() : base(MainCanvas.GetCanvas()) {
			Town = new Town(this);
			Town.SetPosition(10, 10);
			Town.SetSize(500, 500);

			for (int i = 0; i < 10; i++) {
				Dungeons.Add(new Dungeon());
			}
			for (int i = 0; i < 10; i++) {
				Heroes.Add(new Hero(this));
			}
		}

		public void Update() {
			Town.Update();

			foreach (Hero hero in Heroes) {
				hero.Update();
			}
		}

		public void Draw() {
			Town.Draw();
		}
	}
}
