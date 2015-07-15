using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWGoblin {
    class ItemsList {
        public List<Item> items { get; set; }

        public ItemsList() {
            items = new List<Item>();
        }
    }
}
