using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.City {
	class Wall : CityItem {
		public double BonusDefensePerSoldier { get; set; }

		public Wall() : base() {
			UpgradeCost = new List<Resources> {
				new Resources(Type.Wood),
				new Resources(Type.Wood),
				new Resources(Type.Rock),
				new Resources(Type.Rock)
			};
			BonusDefensePerSoldier = 0.5;
		}
	}
}
