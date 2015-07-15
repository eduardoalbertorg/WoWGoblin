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

        private static T _download_serialized_json_data<T>(string url) where T : new() {
            using (var w = new WebClient()) {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try {
                    json_data = w.DownloadString(url);
                } catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }


        private void button1_Click(object sender, EventArgs e) {
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
