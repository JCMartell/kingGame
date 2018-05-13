using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.City {
	class Palace : CityItem {
		public int AvailablePlaces { get; set; }
		public bool PeasantCanDoSeigneurailAction { get; set; }
		public int FlatPoints { get; set; }
		public int GoldPerExtraPoints { get; set; }

		public Palace() : base() {
			UpgradeCost = new List<Resources> {
				new Resources(Type.Rock),
				new Resources(Type.Rock),
				new Resources(Type.Rock),
				new Resources(Type.Rock)
			};
			AvailablePlaces = 1;
			PeasantCanDoSeigneurailAction = false;
			FlatPoints = 1;
			GoldPerExtraPoints = 2;
		}
	}
}
