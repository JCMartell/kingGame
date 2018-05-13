using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.City {
	class City {
		public Palace Palace { get; set; }
		public Market Market { get; set; }
		public Tavern Tavern { get; set; }
		public Wall Wall { get; set; }
		public Dwelling Dwelling { get; set; }

		public City() {
			Palace = new Palace();
			Market = new Market();
			Tavern = new Tavern();
			Wall = new Wall();
			Dwelling = new Dwelling();
		}
	}
}
