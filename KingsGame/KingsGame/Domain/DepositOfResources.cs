using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	class DepositOfResources : DomainItem {
		public int MaxResources { get; set; }

		public DepositOfResources() : base() {
			UpgradeCost = new List<Resources> { new Resources(Type.Clay), new Resources(Type.Clay) };
			PointsReward = 0;
			MaxResources = 5;
		}

		public new void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			PointsReward += 3;

			if (Level == 1) {
				MaxResources = 7;

				UpgradeCost = new List<Resources> {
					new Resources(Type.Clay),
					new Resources(Type.Clay),
					new Resources(Type.Clay),
					new Resources(Type.Clay)
				};
			} else if (Level == 2) {
				MaxResources = 10;

				UpgradeCost = new List<Resources> {
					new Resources(Type.Clay),
					new Resources(Type.Clay),
					new Resources(Type.Clay),
					new Resources(Type.Clay),
					new Resources(Type.Clay),
					new Resources(Type.Steel),
					new Resources(Type.Steel)
				};
			} else {
				MaxResources = 15;

				UpgradeCost = null;
			}
		}
	}
}
