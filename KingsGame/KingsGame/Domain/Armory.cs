using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	class Armory : DomainItem {
		public double PowerPerSoldier { get; set; }

		public Armory() : base() {
			UpgradeCost = new List<Resources> { new Resources(Type.Steel) };
			GoldCost = 1;
			PointsReward = 0;
			PowerPerSoldier = 0.5;
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			PointsReward += 3;

			PowerPerSoldier *= 2;

			if (Level == 1) {
				UpgradeCost = new List<Resources> {
					new Resources(Type.Steel)
				};

				GoldCost = 1;
			} else if (Level == 2) {
				UpgradeCost = new List<Resources> {
					new Resources(Type.Steel),
					new Resources(Type.Steel),
					new Resources(Type.Steel)
				};

				GoldCost = 2;
			} else {
				UpgradeCost = null;
			}
		}
	}
}
