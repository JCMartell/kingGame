using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.City {
	class Wall : CityItem {
		public double BonusDefensePerSoldier { get; set; }

		public Wall() : base() {
			UpgradeCost = new List<Resource> {
				new Resource(Type.Wood),
				new Resource(Type.Wood),
				new Resource(Type.Rock),
				new Resource(Type.Rock)
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

				UpgradeCost = new List<Resource> {
					new Resource(Type.Wood),
					new Resource(Type.Wood),
					new Resource(Type.Wood),
					new Resource(Type.Wood),
					new Resource(Type.Rock),
					new Resource(Type.Rock),
					new Resource(Type.Rock),
					new Resource(Type.Rock)
				};
			} else if (Level == 2) {
				BonusDefensePerSoldier = 1;

				UpgradeCost = new List<Resource>() {
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Wheat),
					new Resource(Type.Wheat),
					new Resource(Type.Wheat),
					new Resource(Type.Steel),
					new Resource(Type.Steel),
					new Resource(Type.Steel)
				};
			} else {
				BonusDefensePerSoldier = 2;
				UpgradeCost = new List<Resource>();
			}
		}
	}
}
