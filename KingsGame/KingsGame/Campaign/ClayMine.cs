using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Campaign {
	class ClayMine : CampaignItem {
		public ClayMine() : base() {
			UpgradeCost = new List<Resources> {
				new Resources(Type.Clay),
				new Resources(Type.Clay),
				new Resources(Type.Clay)
			};
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			Capacity += 1;

			if (Level == 1) {
				UpgradeCost.Add(new Resources(Type.Clay));
				UpgradeCost.Add(new Resources(Type.Clay));
			} else if (Level == 2) {
				UpgradeCost.Add(new Resources(Type.Clay));
				UpgradeCost.Add(new Resources(Type.Clay));
				UpgradeCost.Add(new Resources(Type.Steel));
			} else {
				UpgradeCost.Clear();
				Capacity += 1;
			}
		}
	}
}
