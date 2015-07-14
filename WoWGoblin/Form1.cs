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

namespace WoWGoblin {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Item item = new Item();
            string json = JsonConvert.SerializeObject(item);
            string url = "http://api.tradeskillmaster.com/sample_auction_data.json";
            Item deserializedProduct = JsonConvert.DeserializeObject<Item>(json);
            label1.Text = deserializedProduct.itemName;
            using (var w = new WebClient()) {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try {
                    json_data = w.DownloadString(url);
                } catch (Exception error) {
                    MessageBox.Show(error.Message);
                }
                
            }
        }
    }
}
