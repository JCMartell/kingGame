using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Campaign {
	class StonePit : CampaignItem {
		public StonePit() : base() {
			UpgradeCost = new List<Resources> {
				new Resources(Type.Rock),
				new Resources(Type.Rock),
				new Resources(Type.Rock)
			};
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			Capacity += 1;

			if (Level == 1) {
				UpgradeCost.Add(new Resources(Type.Rock));
				UpgradeCost.Add(new Resources(Type.Rock));
			} else if (Level == 2) {
				UpgradeCost.Add(new Resources(Type.Rock));
				UpgradeCost.Add(new Resources(Type.Rock));
				UpgradeCost.Add(new Resources(Type.Steel));
			} else {
				UpgradeCost.Clear();
				Capacity += 1;
			}
		}
	}
}
