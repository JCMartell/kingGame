using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Campaign {
	class Campaign {
		public Forest Forest { get; set; }
		public Fields Fields { get; set; }
		public ClayMine ClayMine { get; set; }
		public StonePit StonePit { get; set; }
		public SteelMine SteelMine { get; set; }

		public Campaign() {
			Forest = new Forest();
			Fields = new Fields();
			ClayMine = new ClayMine();
			StonePit = new StonePit();
			SteelMine = new SteelMine();
		}
	}
}
