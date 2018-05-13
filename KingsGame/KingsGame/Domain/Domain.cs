using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame.Domain {
	class Domain {
		public Manor Manor { get; set; }
		public DepositOfResources Deposit { get; set; }
		public AdministrationOffice AdministrationOffice { get; set; }
		public Tools Tools { get; set; }
		public Armory Armory { get; set; }

		public Domain() {
			// Initialize domain
		}
	}
}
