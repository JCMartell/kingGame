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
	}
}
