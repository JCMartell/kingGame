using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.City {
	class Market : CityItem {
		public int ResourcesAvailableOfEachType { get; set; }
		public int MaxPurchase { get; set; }
		public int PurchasePerGold { get; set; }
		public bool SteelAvailable { get; set; }

		public Market() : base() {
			UpgradeCost = new List<Resource> {
				new Resource(Type.Wheat),
				new Resource(Type.Wheat),
				new Resource(Type.Wheat)
			};
			ResourcesAvailableOfEachType = 1;
			MaxPurchase = 2;
			PurchasePerGold = 1;
			SteelAvailable = false;
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			if (Level == 1) {
				ResourcesAvailableOfEachType = 2;
				MaxPurchase += 2;

				UpgradeCost = new List<Resource> {
					new Resource(Type.Wheat),
					new Resource(Type.Wheat),
					new Resource(Type.Wheat),
					new Resource(Type.Wheat)
				};
			} else if (Level == 2) {
				ResourcesAvailableOfEachType = 3;
				MaxPurchase += 2;

				UpgradeCost = new List<Resource> {
					new Resource(Type.Wheat),
					new Resource(Type.Wheat),
					new Resource(Type.Wheat),
					new Resource(Type.Wheat),
					new Resource(Type.Wheat),
					new Resource(Type.Wheat),
					new Resource(Type.Steel)
				};
			} else {
				ResourcesAvailableOfEachType = 5;
				MaxPurchase = int.MaxValue;
				PurchasePerGold = 2;

				UpgradeCost = new List<Resource>();
			}
		}
	}
}
