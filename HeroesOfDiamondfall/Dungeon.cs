using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gwen.Control;

namespace HeroesOfDiamondfall {
	class Dungeon : Base, Location {
		public string Name {
			get;
			set;
		}

		public int Distance;
		public int Level;
		static Random rand = new Random();

		public Dungeon(Base parent) : base(parent) {
			Init();
		}
		public Dungeon(Base parent, string Name) : base(parent) {
			Init();
			this.Name = Name;
		}		
		public void Init() {
			this.Name = "Dungeon #" + rand.Next(100);
			this.Distance = rand.Next(50) + 1;
			this.Level = rand.Next(11);

			herobox = new ListBox(this);
			herobox.SetPosition(0, 0);
			herobox.Dock = Gwen.Pos.Fill;
		}

		ListBox herobox;


		public List<Hero> Heroes = new List<Hero>();

		public void Update() {
			Heroes.Clear();
			herobox.Clear();
		}


		public void AddHero(Hero hero) {
			Heroes.Add(hero);
			herobox.AddRow(hero.Name + " - " + hero.Distance + "km", "", hero);
		}
	}
}
