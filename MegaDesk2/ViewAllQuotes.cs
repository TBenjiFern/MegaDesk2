using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk2
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            this.loadJson();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();
        }

        public void loadJson()
        {
            var quotesFile = @"quotes.json";

            if (File.Exists(quotesFile))
            {
                using (StreamReader r = new StreamReader(quotesFile))
                {
                    string json = r.ReadToEnd();
                    List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);

                    dataGridView.DataSource = deskQuotes.Select(d => new
                    {
                        Date = d.QuoteDate,
                        Customer = d.CustomerName,
                        Depth = d.Desk.Depth,
                        Width = d.Desk.Width,
                        Drawers = d.Desk.NumDrawers,
                        SurfaceMaterial = d.Desk.DesktopMaterial,
                        DeliveryType = d.Shipping,
                        Amount = d.DeskPrice.ToString("c"),
                    }).ToList();
                }
            }
        }
    }
}
