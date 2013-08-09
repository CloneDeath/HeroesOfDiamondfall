using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GLImp;
using System.Drawing;
using System.Diagnostics;

namespace HeroesOfDiamondfall {
	class Program {
		static void Main(string[] args) {
			Camera2D Primary = new Camera2D();
			Primary.OnRender += new GraphicsManager.Renderer(Primary_OnRender);

			GraphicsManager.SetTitle("Heroes of Diamondfall");
			GraphicsManager.SetResolution(800, 600);
			GraphicsManager.EnableMipmap = false;

			GraphicsManager.Update += new GraphicsManager.Updater(GraphicsManager_Update);

			Initialize();
			GraphicsManager.Start();
		}
		static Game game;
		static Stopwatch timer;

		private static void Initialize() {
			game = new Game();
			timer = new Stopwatch();
			timer.Start();
		}

		static void GraphicsManager_Update() {
			if (timer.Elapsed.TotalSeconds > 1) {
				timer.Elapsed.Subtract(new TimeSpan(0, 0, 1)); //subtract a second
				game.Update();
			}
		}

		static void Primary_OnRender() {
			game.Draw();
		}
	}
}
