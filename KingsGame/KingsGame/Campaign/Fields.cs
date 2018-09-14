using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Campaign {
	class Fields : CampaignItem {
		public Fields() : base() {
			UpgradeCost = new List<Resource> {
				new Resource(Type.Wheat),
				new Resource(Type.Wheat),
				new Resource(Type.Wheat)
			};
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			Capacity += 1;

			if (Level == 1) {
				UpgradeCost.Add(new Resource(Type.Wheat));
				UpgradeCost.Add(new Resource(Type.Wheat));
			} else if (Level == 2) {
				UpgradeCost.Add(new Resource(Type.Wheat));
				UpgradeCost.Add(new Resource(Type.Wheat));
				UpgradeCost.Add(new Resource(Type.Steel));
			} else {
				UpgradeCost.Clear();
				Capacity += 1;
			}
		}
	}
}
