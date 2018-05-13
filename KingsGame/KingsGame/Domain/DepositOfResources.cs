using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	class DepositOfResources : DomainItem {
		public int MaxResources { get; set; }

		public DepositOfResources() : base() {
			UpgradeCost = new List<Resources> { new Resources(Type.Clay), new Resources(Type.Clay) };
			Reward = 3;
			MaxResources = 5;
		}
	}
}
