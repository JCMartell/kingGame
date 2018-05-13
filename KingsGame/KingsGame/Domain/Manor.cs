using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	class Manor : DomainItem {
		public int Capacity { get; set; }

		public Manor() : base() {
			UpgradeCost = new List<Resources> { new Resources(Type.Rock), new Resources(Type.Rock) };
			PointsReward = 3;
			Capacity = 1;
		}

		public new void Upgrade() {
			base.Upgrade();

			PointsReward += 3;

			if (Level == 1) {
				UpgradeCost = new List<Resources> {
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Clay),
					new Resources(Type.Wood)
				};
				Capacity = 2;
			} else if (Level == 2) {
				UpgradeCost = new List<Resources> {
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Steel),
					new Resources(Type.Steel),
					new Resources(Type.Steel)
				};
				Capacity = 3;
			} else {
				UpgradeCost = new List<Resources>();
				Capacity = 5;
			}
		}
	}
}
