using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	class DepositOfResources : DomainItem {
		public int MaxResources { get; set; }

		public DepositOfResources() : base() {
			UpgradeCost = new List<Resource> { new Resource(Type.Clay), new Resource(Type.Clay) };
			PointsReward = 0;
			MaxResources = 5;
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			PointsReward += 3;

			if (Level == 1) {
				MaxResources = 7;

				UpgradeCost = new List<Resource> {
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay)
				};
			} else if (Level == 2) {
				MaxResources = 10;

				UpgradeCost = new List<Resource> {
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Steel),
					new Resource(Type.Steel)
				};
			} else {
				MaxResources = 15;

				UpgradeCost = null;
			}
		}
	}
}
