using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gwen.Control;

namespace HeroesOfDiamondfall {
	class Game : Base {
		Town MainTown;
		List<Dungeon> Dungeons = new List<Dungeon>();
		List<Hero> Heroes = new List<Hero>();

		public Game() : base(MainCanvas.GetCanvas()) {
			MainTown = new Town(this);
			MainTown.SetPosition(10, 10);
			MainTown.SetSize(500, 500);


			Dungeons.Add(new Dungeon());
			Heroes.Add(new Hero());
		}

		public void Update() {
			MainTown.Update();
		}

		public void Draw() {
			MainTown.Draw();
		}
	}
}
