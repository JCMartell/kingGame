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
			BonusDefensePerSoldier = 0;
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			if (Level == 1) {
				BonusDefensePerSoldier = 0.5;

				UpgradeCost = new List<Resources> {
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock)
				};
			} else if (Level == 2) {
				BonusDefensePerSoldier = 1;

				UpgradeCost = new List<Resources>() {
					new Resources(Type.Clay),
					new Resources(Type.Clay),
					new Resources(Type.Clay),
					new Resources(Type.Wheat),
					new Resources(Type.Wheat),
					new Resources(Type.Wheat),
					new Resources(Type.Steel),
					new Resources(Type.Steel),
					new Resources(Type.Steel)
				};
			} else {
				BonusDefensePerSoldier = 2;
				UpgradeCost = new List<Resources>();
			}
		}
	}
}
