using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Campaign {
	class Forest : CampaignItem {
		public Forest() : base() {
			UpgradeCost = new List<Resources> {
				new Resources(Type.Wood),
				new Resources(Type.Wood),
				new Resources(Type.Wood)
			};
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			Capacity += 1;

			if (Level == 1) {
				UpgradeCost.Add(new Resources(Type.Wood));
				UpgradeCost.Add(new Resources(Type.Wood));
			} else if (Level == 2) {
				UpgradeCost.Add(new Resources(Type.Wood));
				UpgradeCost.Add(new Resources(Type.Wood));
				UpgradeCost.Add(new Resources(Type.Steel));
			} else {
				UpgradeCost.Clear();
				Capacity += 1;
			}
		}
	}
}
