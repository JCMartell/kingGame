using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	abstract class DomainItem {
		public int Level { get; set; }
		public List<Resources> UpgradeCost { get; set; }
		public int GoldCost { get; set; }
		public int PointsReward { get; set; }
		public bool MaxLevel { get; set; }

		public DomainItem() {
			Level = 0;
			GoldCost = 0;
			MaxLevel = false;
		}

		public virtual void Upgrade() {
			Level++;
			if (Level == 3) {
				MaxLevel = true;
			}
		}
	}
}
