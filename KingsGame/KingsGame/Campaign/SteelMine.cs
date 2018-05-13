using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Campaign {
	class SteelMine : CampaignItem {
		public int GoldCost { get; set; }

		public SteelMine() {
			UpgradeCost = new List<Resources> {
				new Resources(Type.Clay),
				new Resources(Type.Wood),
				new Resources(Type.Wheat),
				new Resources(Type.Rock)
			};
			GoldCost = 1;
		}
	}
}
