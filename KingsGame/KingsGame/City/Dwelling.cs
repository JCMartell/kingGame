using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.City {
	class Dwelling : CityItem {
		public int CitizenAvailable { get; set; }

		public Dwelling() : base() {
			UpgradeCost = new List<Resources> {
				new Resources(Type.Wood),
				new Resources(Type.Wood),
				new Resources(Type.Wood),
				new Resources(Type.Wood)
			};
			CitizenAvailable = 2;
		}
	}
}
