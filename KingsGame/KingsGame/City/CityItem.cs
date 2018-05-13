using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.City {
	abstract class CityItem {
		public int Level { get; set; }
		public List<Resources> UpgradeCost { get; set; }
		public int PointsReward { get; set; }
		public int GoldReward { get; set; }

		public CityItem() {
			Level = 0;
			PointsReward = 4;
			GoldReward = 4;
		}
	}
}
