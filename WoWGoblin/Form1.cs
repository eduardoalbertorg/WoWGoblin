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
    public partial class frmWoWGoblin : Form {
        public frmWoWGoblin() {
            InitializeComponent();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e) {
            string url = "http://api.tradeskillmaster.com/sample_auction_data.json";
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
                    dgvItems.Rows.Add(item.Value.itemName);
                }
            }
        }
    }
}
