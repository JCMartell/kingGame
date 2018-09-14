using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame {
	class Player {
		public List<Action> Actions { get; set; }
		public List<Resource> Resources { get; set; }
		public int Gold { get; set; }
		public Domain.Domain Domain { get; set; }

		public Player() {
			Actions = new List<Action>() { new Action(true), new Action(false) };
			Resources = new List<Resource>();
			Gold = 0;
			Domain = new Domain.Domain();
		}
	}
}
