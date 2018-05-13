using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.City {
	class Tavern : CityItem {
		public int MercenariesAvailable { get; set; }
		public int GoldPerMercenaries { get; set; }
		public bool MaxLevel { get; set; }

		public Tavern() : base() {
			UpgradeCost = new List<Resources> {
				new Resources(Type.Clay),
				new Resources(Type.Clay),
				new Resources(Type.Clay),
				new Resources(Type.Clay)
			};
			MercenariesAvailable = 1;
			GoldPerMercenaries = 1;
			MaxLevel = false;
		}
	}
}
