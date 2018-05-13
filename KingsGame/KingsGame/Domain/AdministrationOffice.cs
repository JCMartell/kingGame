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
			PointsReward = 4;
			GoldPerTurn = 0;
			SeigniorialSeals = 1;
		}
	}
}
