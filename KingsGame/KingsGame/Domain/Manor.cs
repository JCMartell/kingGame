using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	class Manor : DomainItem {
		public int Capacity { get; set; }

		public Manor() : base() {
			UpgradeCost = new List<Resource> { new Resource(Type.Rock), new Resource(Type.Rock) };
			PointsReward = 0;
			Capacity = 1;
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			PointsReward += 3;

			if (Level == 1) {
				Capacity = 2;

				UpgradeCost = new List<Resource> {
					new Resource(Type.Rock),
					new Resource(Type.Rock),
					new Resource(Type.Rock),
					new Resource(Type.Clay),
					new Resource(Type.Wood)
				};
			} else if (Level == 2) {
				Capacity = 3;

				UpgradeCost = new List<Resource> {
					new Resource(Type.Rock),
					new Resource(Type.Rock),
					new Resource(Type.Rock),
					new Resource(Type.Rock),
					new Resource(Type.Steel),
					new Resource(Type.Steel),
					new Resource(Type.Steel)
				};
			} else {
				Capacity = 5;

				UpgradeCost = null;
			}
		}
	}
}
