using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsGame {
    public class Resources {
        public Type Type { get; set; }

        public Resources(Type type) {
            Type = type;
        }
    }

    public enum Type {
        Wheat,
        Rock,
        Steel,
        Wood,
        Clay
    }
}
