using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	class AdministrationOffice : DomainItem {
		public int GoldPerTurn { get; set; }
		public int SeigniorialSeals { get; set; }

		public AdministrationOffice() : base() {
			UpgradeCost = new List<Resources> { new Resources(Type.Wheat), new Resources(Type.Wheat) };
			PointsReward = 0;
			GoldPerTurn = 0;
			SeigniorialSeals = 1;
		}

		public new void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			PointsReward += 4;

			if (Level == 1) {
				SeigniorialSeals = 2;

				UpgradeCost = new List<Resources> {
					new Resources(Type.Wheat),
					new Resources(Type.Wheat),
					new Resources(Type.Wheat),
					new Resources(Type.Wheat)
				};

				GoldCost = 2;
			} else if (Level == 2) {
				GoldPerTurn = 1;

				UpgradeCost = new List<Resources> {
					new Resources(Type.Wheat),
					new Resources(Type.Wheat),
					new Resources(Type.Wheat),
					new Resources(Type.Wheat),
					new Resources(Type.Wheat),
					new Resources(Type.Clay),
					new Resources(Type.Clay)
				};

				GoldCost = 6;
			} else {
				SeigniorialSeals = 3;
				GoldPerTurn = 2;

				UpgradeCost = null;
			}
		}
	}
}
