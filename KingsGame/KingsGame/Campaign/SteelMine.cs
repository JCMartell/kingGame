using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Campaign {
	class SteelMine : CampaignItem {
		public int GoldCost { get; set; }

		public SteelMine() : base() {
			UpgradeCost = new List<Resource> {
				new Resource(Type.Clay),
				new Resource(Type.Wood),
				new Resource(Type.Wheat),
				new Resource(Type.Rock)
			};
			GoldCost = 1;
			PointsReward = 5;
			GoldReward = 3;
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			Capacity += 1;

			if (Level == 1) {
				UpgradeCost.Clear();
				for (int i = 0; i < 2; i++) {
					UpgradeCost.Add(new Resource(Type.Steel));
					UpgradeCost.Add(new Resource(Type.Rock));
					UpgradeCost.Add(new Resource(Type.Wood));
				}
			} else if (Level == 2) {
				UpgradeCost.Clear();
				for (int i = 0; i < 3; i++) {
					UpgradeCost.Add(new Resource(Type.Steel));
					UpgradeCost.Add(new Resource(Type.Clay));
					UpgradeCost.Add(new Resource(Type.Wheat));
				}
			} else {
				UpgradeCost.Clear();
				Capacity += 1;
			}
		}
	}
}
