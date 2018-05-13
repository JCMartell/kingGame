using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	class Armory : DomainItem {
		public double PowerPerSoldier { get; set; }

		public Armory() : base() {
			UpgradeCost = new List<Resources> { new Resources(Type.Steel) };
			GoldCost = 1;
			Reward = 3;
			PowerPerSoldier = 0.5;
		}
	}
}
