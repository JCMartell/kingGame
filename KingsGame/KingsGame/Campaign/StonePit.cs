using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Campaign {
	class StonePit : CampaignItem {
		public StonePit() : base() {
			UpgradeCost = new List<Resources> {
				new Resources(Type.Rock),
				new Resources(Type.Rock),
				new Resources(Type.Rock)
			};
		}
	}
}
