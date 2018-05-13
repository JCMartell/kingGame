using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	class Manor : DomainItem {
		public int Capacity { get; set; }

		public Manor() : base() {
			UpgradeCost = new List<Resources> { new Resources(Type.Rock), new Resources(Type.Rock) };
			Reward = 3;
			Capacity = 1;
		}
	}
}
