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
	}
}
