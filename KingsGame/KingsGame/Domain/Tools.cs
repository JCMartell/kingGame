using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	class Tools : DomainItem {
		public int ResourcesPerWorker { get; set; }

		public Tools() : base() {
			UpgradeCost = new List<Resources> { new Resources(Type.Wood), new Resources(Type.Wood) };
			Reward = 3;
			ResourcesPerWorker = 1;
		}
	}
}
