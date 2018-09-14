using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Campaign {
	class Fields : CampaignItem {
		public Fields() : base() {
			UpgradeCost = new List<Resources> {
				new Resources(Type.Wheat),
				new Resources(Type.Wheat),
				new Resources(Type.Wheat)
			};
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			Capacity += 1;

			if (Level == 1) {
				UpgradeCost.Add(new Resources(Type.Wheat));
				UpgradeCost.Add(new Resources(Type.Wheat));
			} else if (Level == 2) {
				UpgradeCost.Add(new Resources(Type.Wheat));
				UpgradeCost.Add(new Resources(Type.Wheat));
				UpgradeCost.Add(new Resources(Type.Steel));
			} else {
				UpgradeCost.Clear();
				Capacity += 1;
			}
		}
	}
}
