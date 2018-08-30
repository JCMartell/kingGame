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

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			if (Level == 1) {
				CitizenAvailable += 2;

				UpgradeCost = new List<Resources> {
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood)
				};
			} else if (Level == 2) {
				CitizenAvailable += 3;

				UpgradeCost = new List<Resources> {
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Wood),
					new Resources(Type.Steel)
				};
			} else {
				CitizenAvailable += 4;
				UpgradeCost = new List<Resources>();
			}
		}
	}
}
