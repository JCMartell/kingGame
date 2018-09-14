using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.City {
	abstract class CityItem {
		public int Level { get; set; }
		public List<Resource> UpgradeCost { get; set; }
		public int PointsReward { get; set; }
		public int GoldReward { get; set; }
		public bool MaxLevel { get; set; }

		public CityItem() {
			Level = 0;
			PointsReward = 4;
			GoldReward = 4;
			MaxLevel = false;
		}

		public virtual void Upgrade() {
			Level++;
			PointsReward += 4;
			if (Level == 3) {
				MaxLevel = true;
			}
		}
	}
}
