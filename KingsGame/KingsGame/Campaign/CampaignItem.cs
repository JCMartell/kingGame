using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Campaign {
	abstract class CampaignItem {
		public int Level { get; set; }
		public int Capacity { get; set; }
		public List<Resources> UpgradeCost { get; set; }
		public int PointsReward { get; set; }
		public int GoldReward { get; set; }
		public bool MaxLevel { get; set; }

		public CampaignItem() {
			Level = 0;
			Capacity = 1;
			PointsReward = 3;
			GoldReward = 2;
			MaxLevel = false;
		}

		public virtual void Upgrade() {
			Level++;
			PointsReward += 2;
			GoldReward += 1;
			if (Level == 3) {
				MaxLevel = true;
			}
		}
	}
}
