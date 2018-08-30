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

		public override void Upgrade() {
			if (MaxLevel) {
				return;
			}

			base.Upgrade();

			if (Level == 1) {
				AvailablePlaces = 2;
				PeasantCanDoSeigneurailAction = true;

				UpgradeCost = new List<Resources>() {
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock)
				};
			} else if (Level == 2) {
				AvailablePlaces = 3;
				FlatPoints = 2;

				UpgradeCost = new List<Resources>() {
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Rock),
					new Resources(Type.Steel)
				};
			} else {
				AvailablePlaces = 5;
				FlatPoints = 4;
				GoldPerExtraPoints = 1;

				UpgradeCost = new List<Resources>();
			}
		}
	}
}
