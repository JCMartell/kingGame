using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	class Tools : DomainItem {
		public int ResourcesPerWorker { get; set; }

		public Tools() : base() {
			UpgradeCost = new List<Resource> { new Resource(Type.Wood), new Resource(Type.Wood) };
			PointsReward = 0;
			ResourcesPerWorker = 1;
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			PointsReward += 3;
			ResourcesPerWorker += 1;

			if (Level == 1) {
				UpgradeCost = new List<Resource> {
					new Resource(Type.Wood),
					new Resource(Type.Wood),
					new Resource(Type.Wood),
					new Resource(Type.Wood),
					new Resource(Type.Wheat)
				};
			} else if (Level == 2) {
				UpgradeCost = new List<Resource> {
					new Resource(Type.Wood),
					new Resource(Type.Wood),
					new Resource(Type.Wood),
					new Resource(Type.Wood),
					new Resource(Type.Wood),
					new Resource(Type.Wood),
					new Resource(Type.Wheat),
					new Resource(Type.Wheat),
					new Resource(Type.Wheat)
				};

				GoldCost = 2;
			} else {
				UpgradeCost = null;
			}
		}
	}
}
