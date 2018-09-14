using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.City {
	class Tavern : CityItem {
		public int MercenariesAvailable { get; set; }
		public int Price { get; set; }
		public int MercenariesPerPurchase { get; set; }

		public Tavern() : base() {
			UpgradeCost = new List<Resource> {
				new Resource(Type.Clay),
				new Resource(Type.Clay),
				new Resource(Type.Clay),
				new Resource(Type.Clay)
			};
			MercenariesAvailable = 1;
			MercenariesPerPurchase = 1;
			Price = 1;
		}

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			if (Level == 1) {
				MercenariesAvailable = 2;

				UpgradeCost = new List<Resource> {
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay)
				};
			} else if (Level == 2) {
				MercenariesAvailable = 3;

				UpgradeCost = new List<Resource> {
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Clay),
					new Resource(Type.Steel)
				};
			} else {
				MercenariesAvailable = 6;
				MercenariesPerPurchase = 3;
				Price = 2;

				UpgradeCost = new List<Resource>();
			}
		}
	}
}
