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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            List<DesktopMaterial> materialsList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            comFilterSurface.DataSource = materialsList;

            comFilterSurface.SelectedIndex = -1;

            this.loadJson();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
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

                    dataGridSearch.DataSource = deskQuotes.Select(d => new
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

        private void comFilterSurface_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedValue = comFilterSurface.SelectedIndex;
            DesktopMaterial desktopMaterial = (DesktopMaterial)selectedValue;
            this.loadJson(desktopMaterial);
        }

        public void loadJson(DesktopMaterial desktopMaterial)
        {
            var quotesFile = @"quotes.json";

            if (File.Exists(quotesFile))
            {
                using (StreamReader r = new StreamReader(quotesFile))
                {
                    string json = r.ReadToEnd();
                    List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);

                    dataGridSearch.DataSource = deskQuotes.Select(d => new
                    {
                        Date = d.QuoteDate,
                        Customer = d.CustomerName,
                        Depth = d.Desk.Depth,
                        Width = d.Desk.Width,
                        Drawers = d.Desk.NumDrawers,
                        SurfaceMaterial = d.Desk.DesktopMaterial,
                        DeliveryType = d.Shipping,
                        Amount = d.DeskPrice.ToString("c"),
                    }).Where(q => q.SurfaceMaterial == desktopMaterial).ToList();
                }
            }
        }
    }
}
