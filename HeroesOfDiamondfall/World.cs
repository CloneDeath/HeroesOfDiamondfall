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
		public Dungeon Wilderness;

		public World() : base(MainCanvas.GetCanvas()) {
			this.Dock = Gwen.Pos.Fill;
			Town = new Town(this);
			Town.SetPosition(10, 10);
			Town.SetSize(500, 500);

			for (int i = 0; i < 10; i++) {
				Dungeon d = new Dungeon(this);
				d.SetPosition(520, 30);
				Dungeons.Add(d);
			}
			for (int i = 0; i < 10; i++) {
				Heroes.Add(new Hero(this));
			}
			Wilderness = new Dungeon(this, "Wilderness");
			Wilderness.SetPosition(520, 10);
			Wilderness.SetSize(270, 60);
		}

		public void Update() {
			Town.Update();
			Wilderness.Update();

			foreach (Hero hero in Heroes) {
				hero.Update();
			}
		}

		public void Draw() {
			Town.Draw();
		}
	}
}
