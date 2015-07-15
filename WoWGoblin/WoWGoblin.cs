using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WoWGoblin {
    public partial class WoWGoblinFrm : Form {
        public WoWGoblinFrm() {
            InitializeComponent();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e) {
            string url = "http://api.tradeskillmaster.com/sample_auction_data.json";
            int marketValueInGold = 0;
            int minBuyoutInGold = 0;
            using (var w = new WebClient()) {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try {
                    json_data = w.DownloadString(url);
                } catch (Exception error) {
                    MessageBox.Show(error.Message);
                }
                var result = JsonConvert.DeserializeObject<Dictionary<string, Item>>(json_data);
                foreach (var item in result) {
                    marketValueInGold = Convert.ToInt32(Convert.ToInt64(item.Value.marketValue) / 1000);
                    minBuyoutInGold = Convert.ToInt32(Convert.ToInt64(item.Value.minBuyout) / 1000);
                    itemsDgv.Rows.Add(item.Key, item.Value.itemName, marketValueInGold.ToString("N"), minBuyoutInGold.ToString("N"));
                }
                MessageBox.Show("Update succesful");
            }
        }
    }
}
