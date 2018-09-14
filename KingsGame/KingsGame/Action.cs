using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame {
	class Action {
		public bool IsSeigneurial { get; set; }

		public Action(bool isSeigneurial) {
			IsSeigneurial = isSeigneurial;
		}
	}
}
