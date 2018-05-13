using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Campaign {
	class Fields : CampaignItem {
		public Fields() : base() {
			UpgradeCost = new List<Resources> {
				new Resources(Type.Wheat),
				new Resources(Type.Wheat),
				new Resources(Type.Wheat)
			};
		}
	}
}
