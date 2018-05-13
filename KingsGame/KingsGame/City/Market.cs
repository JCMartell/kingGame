using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.City {
	class Market : CityItem {
		public int ResourcesAvailableOfEachType { get; set; }
		public int MaxPurchase { get; set; }
		public bool SteelAvailable { get; set; }

		public Market() : base() {
			UpgradeCost = new List<Resources> {
				new Resources(Type.Wheat),
				new Resources(Type.Wheat),
				new Resources(Type.Wheat)
			};
			ResourcesAvailableOfEachType = 1;
			MaxPurchase = 2;
			SteelAvailable = false;
		}
	}
}
