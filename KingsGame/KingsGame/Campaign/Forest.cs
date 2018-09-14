using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Campaign {
	class Forest : CampaignItem {
		public Forest() : base() {
			UpgradeCost = new List<Resource> {
				new Resource(Type.Wood),
				new Resource(Type.Wood),
				new Resource(Type.Wood)
			};
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			Capacity += 1;

			if (Level == 1) {
				UpgradeCost.Add(new Resource(Type.Wood));
				UpgradeCost.Add(new Resource(Type.Wood));
			} else if (Level == 2) {
				UpgradeCost.Add(new Resource(Type.Wood));
				UpgradeCost.Add(new Resource(Type.Wood));
				UpgradeCost.Add(new Resource(Type.Steel));
			} else {
				UpgradeCost.Clear();
				Capacity += 1;
			}
		}
	}
}
