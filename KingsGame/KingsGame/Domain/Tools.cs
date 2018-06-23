using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	class Tools : DomainItem {
		public int ResourcesPerWorker { get; set; }

		public Tools() : base() {
			UpgradeCost = new List<Resources> { new Resources(Type.Wood), new Resources(Type.Wood) };
			PointsReward = 0;
			ResourcesPerWorker = 1;
		}

		public new void Upgrade() {
			base.Upgrade();

			PointsReward += 3;
			ResourcesPerWorker += 1;

			if (Level == 1) {
				UpgradeCost = new List<Resources> {
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wheat)
				};
			} else if (Level == 2) {
				UpgradeCost = new List<Resources> {
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wheat),
					new Resources(Type.Wheat),
					new Resources(Type.Wheat)
				};

				GoldCost = 2;
			} else {
				UpgradeCost = new List<Resources>();
			}
		}
	}
}
